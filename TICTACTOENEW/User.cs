using System.Collections.Generic;

namespace TicTacToe
{
    public abstract class User
    {
        protected string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            user_id = id;
            user_password = pass;
        }

        public string UserID
        {
            get { return user_id; }
        }

        public string Password
        {
            get { return user_password; }
        }

        public virtual void updatePassword(string newPassword)
        {
            user_password = newPassword;
        }
    }

    public class Administrator : User
    {
        private List<Player> players = new List<Player>();

        public Administrator(string id, string password) : base(id, password)
        {
        }

        public Administrator(string id, string password, string additionalParam) : base(id, password)
        {
        }

        public void CreatePlayer(string id, string password)
        {
            players.Add(new Player(id, password));
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        public void UpdatePlayerPassword(Player player, string newPassword)
        {
            player.updatePassword(newPassword);
        }

        public bool verifyLogin(string id, string password)
        {
            return this.UserID == id && this.Password == password;
        }
    }
}
