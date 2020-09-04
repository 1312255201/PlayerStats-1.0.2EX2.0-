using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using Newtonsoft.Json;
using Exiled.API.Features;

namespace YYYLike
{


	public class NetServer
	{

		//单例脚本
		public static readonly NetServer Instance = new NetServer();
		//定义tcp服务器
		private Socket server;
		private int maxClient = 10;
		//定义端口
		private int port = 35353;
		//用户池
		private Stack<NetUserToken> pools;
		private bool kickyes;

		private NetServer()
		{
			//初始化socket
			server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			server.Bind(new IPEndPoint(IPAddress.Any, port));
		}

		//开启服务器
		public void Start()
		{
			server.Listen(maxClient);
			Log.Info("Server OK!");
			//实例化客户端的用户池
			pools = new Stack<NetUserToken>(maxClient);
			for (int i = 0; i < maxClient; i++)
			{
				NetUserToken usertoken = new NetUserToken();
				pools.Push(usertoken);
			}
			//可以异步接受客户端, BeginAccept函数的第一个参数是回调函数，当有客户端连接的时候自动调用
			server.BeginAccept(AsyncAccept, null);
		}

		//回调函数， 有客户端连接的时候会自动调用此方法
		private void AsyncAccept(IAsyncResult result)
		{
			try
			{
				//结束监听，同时获取到客户端
				Socket client = server.EndAccept(result);
				Log.Info("有客户端连接");
				//来了一个客户端
				NetUserToken userToken = pools.Pop();
				userToken.socket = client;
				//客户端连接之后，可以接受客户端消息
				BeginReceive(userToken);

				//尾递归，再次监听是否还有其他客户端连入
				server.BeginAccept(AsyncAccept, null);
			}
			catch (Exception ex)
			{
				Log.Info(ex.ToString());
			}
		}

		//异步监听消息
		private void BeginReceive(NetUserToken userToken)
		{
			try
			{
				//异步方法
				userToken.socket.BeginReceive(userToken.buffer, 0, userToken.buffer.Length, SocketFlags.None,
					EndReceive, userToken);
				string msg = Encoding.UTF8.GetString(userToken.buffer,0,userToken.buffer.Length);
				msg.Trim();
				Log.Info(msg);

			}
			catch (Exception ex)
			{
				Log.Info(ex.ToString());
			}
		}

		//监听到消息之后调用的函数
		private void EndReceive(IAsyncResult result)
		{
			try
			{
				//取出客户端
				NetUserToken userToken = result.AsyncState as NetUserToken;
				//获取消息的长度
				int len = userToken.socket.EndReceive(result);
				if (len > 0)
				{
					byte[] data = new byte[len];
					Buffer.BlockCopy(userToken.buffer, 0, data, 0, len);
					//用户接受消息
					userToken.Receive(data);
					//尾递归，再次监听客户端消息
					string msg = Encoding.UTF8.GetString(data);

					if (msg.Contains("playerlist"))
					{
						List<Playerpython> list_player = new List<Playerpython>();
						foreach (Player r in Player.List)
						{
							Playerpython temp = new Playerpython(r.UserId, r.Nickname, r.Id, r.Role.ToString(), r.Health);
							list_player.Add(temp);
						}
						string jsonStr = JsonConvert.SerializeObject(list_player);
						Log.Info(jsonStr);
						userToken.Send(Encoding.UTF8.GetBytes(jsonStr));
					}
					if (msg.Contains("kick"))
					{
						kickyes = false;
						string[] strArray = msg.ToLower().Split(' ');
						foreach (Player referenceHub in Player.List)
						{
							if (referenceHub.Id.ToString() == strArray[1])
							{
								referenceHub.Kick("你已被服务器t出");
								Log.Info(referenceHub.Nickname + "被请出服务器 玩家编号" + strArray[1]);
								userToken.Send(Encoding.UTF8.GetBytes(referenceHub.Nickname + "被请出服务器 玩家编号" + strArray[1]));
								kickyes = true;
							}
						}
						if(kickyes == false)
						{
							userToken.Send(Encoding.UTF8.GetBytes("踢出失败 不存在玩家编号" + strArray[1]));
						}
					}
					if (msg.Contains("bcp"))
					{
						kickyes = false;
						string[] strArray = msg.ToLower().Split(' ');
						foreach (Player referenceHub in Player.List)
						{
							if (referenceHub.Id.ToString() == strArray[1])
							{
								try
								{
									kickyes = true;
									referenceHub.Broadcast(7, strArray[2]);
									userToken.Send(Encoding.UTF8.GetBytes(referenceHub.Nickname + "私发公告完成" + strArray[2]));
								}
								catch (Exception ex)
								{
									Log.Info(ex.ToString());
									userToken.Send(Encoding.UTF8.GetBytes(referenceHub.Nickname + "私发公告失败 没有传入正确的血量值"));

								}
							}
						}
						if (kickyes == false)
						{
							userToken.Send(Encoding.UTF8.GetBytes("私发公告失败 不存在玩家编号" + strArray[1]));
						}
					}
					else if (msg.Contains("bc"))
					{

						string[] strArray = msg.ToLower().Split(' ');
						foreach (Player referenceHub in Player.List)
						{
							referenceHub.Broadcast(ushort.Parse(strArray[1]), strArray[2]);
						}
						userToken.Send(Encoding.UTF8.GetBytes(strArray[2] + "公告发送完毕"));
					}
					if (msg.Contains("hp"))
					{
						kickyes = false;
						string[] strArray = msg.ToLower().Split(' ');
						foreach (Player referenceHub in Player.List)
						{
							if (referenceHub.Id.ToString() == strArray[1])
							{
								try
								{
									kickyes = true;
									referenceHub.Health = float.Parse(strArray[2]);
									userToken.Send(Encoding.UTF8.GetBytes(referenceHub.Nickname + "血量设置完毕" + strArray[2]));
								}
								catch(Exception ex)
								{
									Log.Info(ex.ToString());
									userToken.Send(Encoding.UTF8.GetBytes(referenceHub.Nickname + "血量设置失败 没有传入正确的血量值"));

								}


							}
						}
						if (kickyes == false)
						{
							userToken.Send(Encoding.UTF8.GetBytes("设置失败 不存在玩家编号" + strArray[1]));
						}
					}

					if (msg.Contains("restart"))
					{
						kickyes = false;
						userToken.Send(Encoding.UTF8.GetBytes("服务器重启完成"));
						GameCore.Console.singleton.TypeCommand("ROUNDRESTART");
					}

					BeginReceive(userToken);
				}

			}
			catch (Exception ex)
			{
				Log.Info(ex.ToString());
			}
		}

	}
}
