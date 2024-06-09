namespace TicTacToe
{
    public class Player : User
    {
        public string PlayerID { get; set; }

        public Player(string id, string pass) : base(id, pass)
        {
            PlayerID = id;
        }

        public override void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }

        public bool verifyLogin(string id, string password)
        {
            return this.user_id == id && this.user_password == password;
        }
    }
}
