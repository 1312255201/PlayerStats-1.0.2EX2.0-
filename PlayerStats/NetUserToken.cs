using Exiled.API.Features;
using System.Net.Sockets;

namespace YYYLike
{
    // 表示一个客户端
    public class NetUserToken
    {
        //连接客户端的Socket
        public Socket socket;
        //用于存放接收数据
        public byte[] buffer;

        public NetUserToken()
        {
            buffer = new byte[1024];
        }

        // 接受消息
        // < param name="data">Data.< /param>
        public void Receive(byte[] data)
        {
            Log.Info("接收到消息！");
        }

        // 发送消息
        //< param name="data">Data.< /param>
        public void Send(byte[] data)
        {
            socket.Send(data);
        }
    }
}
