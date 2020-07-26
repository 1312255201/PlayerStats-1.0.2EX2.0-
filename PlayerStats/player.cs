namespace PlayerStats
{

	public class Playerpython
	{
		private string userId;
		private string nickName;
		private int id;
		private string role;
		private float hp;

		public Playerpython(string userid,string nickname,int id,string role, float hp) {
			this.userId = userid;
			this.nickName = nickname;
			this.id = id;
			this.role = role;
			this.hp = hp;
		}
		public string UserId { get => userId; set => userId = value; }
		public string NickName { get => nickName; set => nickName = value; }
		public int Id { get => id; set => id = value; }
		public string Role { get => role; set => role = value; }
		public float Hp { get => hp; set => hp = value; }
	}
}