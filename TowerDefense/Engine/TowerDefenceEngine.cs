using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerDefense.Factory;
using TowerDefense.Interfaces;
using TowerDefense.Models;
using TowerDefense.Utils;

namespace TowerDefense.Engine
{
    public sealed class TowerDefenceEngine : IEngine
    {

        private const string InvalidCommand = "Invalid command!";

        private const string UserAlreadyExist = "User {0} already exist. Choose a different username!";
        private const string UserLoggedInAlready = "User {0} is logged in! Please log out first!";
        private const string UserRegisterеd = "User {0} registered successfully!";
        private const string UserNotLogged = "You are not logged! Please login first!";
        private const string NoSuchUser = "There is no user with username {0}!";
        private const string UserLoggedOut = "You logged out!";
        private const string UserLoggedIn = "User {0} successfully logged in!";
        private const string WrongUsernameOrPassword = "Wrong username or password!";
        private const string YouAreNotAnAdmin = "You are not an admin!";

        private const string CommentAddedSuccessfully = "{0} added comment successfully!";
        private const string CommentRemovedSuccessfully = "{0} removed comment successfully!";

        private const string towerRemovedSuccessfully = "{0} removed tower successfully!";
        private const string towerAddedSuccessfully = "{0} added tower successfully!";

        private const string RemovedtowerDoesNotExist = "Cannot remove comment! The tower does not exist!";
        private const string RemovedCommentDoesNotExist = "Cannot remove comment! The comment does not exist!";

        private const string CommentDoesNotExist = "The comment does not exist!";
        private const string towerDoesNotExist = "The tower does not exist!";

        //private static readonly IEngine SingleInstance = new DealershipEngine();
        private static readonly IEngine SingleInstance = new TowerDefenceEngine();

        IList<ITower> Towers { get; set; } // IList<Itower> towers { get; }

        private readonly ITowerDefenceFactory factory; // private readonly IDealershipFactory factory;
        private readonly ICollection<IUser> users;
        private IUser loggedUser;

        public static IEngine Instance
        {
            get
            {
                return SingleInstance;
            }
        }

        public void Start()
        {
            var commands = this.ReadCommands();
            var commandResult = this.ProcessCommands(commands);
            this.PrintReports(commandResult);
        }

        public TowerDefenceEngine()
        {
            this.factory = new TowerDefenceFactory();
            this.users = new List<IUser>();
            this.loggedUser = null;
        }


        private IList<ICommand> ReadCommands()
        {
            var commands = new List<ICommand>();

            var currentLine = Console.ReadLine();

            while (!string.IsNullOrEmpty(currentLine))
            {
                var currentCommand = new Command(currentLine);
                commands.Add(currentCommand);

                currentLine = Console.ReadLine();
            }

            return commands;
        }

        private IList<string> ProcessCommands(IList<ICommand> commands)
        {
            var reports = new List<string>();

            foreach (var command in commands)
            {
                try
                {
                    var report = this.ProcessSingleCommand(command);
                    reports.Add(report);
                }
                catch (Exception ex)
                {
                    reports.Add(ex.Message);
                }
            }

            return reports;
        }

        private void PrintReports(IList<string> reports)
        {
            var output = new StringBuilder();

            foreach (var report in reports)
            {
                output.AppendLine(report);
                output.AppendLine(new string('#', 20));
            }

            Console.Write(output.ToString());
        }

        private string ProcessSingleCommand(ICommand command)
        {
            if (command.Name != "RegisterUser" && command.Name != "Login")
            {
                if (this.loggedUser == null)
                {
                    return UserNotLogged;
                }
            }

            switch (command.Name)
            {
                case "RegisterUser":
                    var username = command.Parameters[0];
                    var password = command.Parameters[3];


                    return this.RegisterUser(username, password);

                case "Login":
                    username = command.Parameters[0];
                    password = command.Parameters[1];

                    return this.Login(username, password);

                case "Logout":
                    return this.Logout();

                case "AddTower":
                    var type = command.Parameters[0];
                    var cost = int.Parse(command.Parameters[1]);
                    var additionalParam = command.Parameters[2];

                    return this.Addtower(type, cost);

                case "Removetower":
                    var towerIndex = int.Parse(command.Parameters[0]) - 1;

                    return this.Removetower(towerIndex);

                case "AddEnemy":
                    var content = command.Parameters[0];
                    var author = command.Parameters[1];
                    towerIndex = int.Parse(command.Parameters[2]) - 1;
                    
                    //TODO:Implement
                    return null;
                    //return this.AddEnemy(content, towerIndex, author);

                case "RemoveEnemy":
                    towerIndex = int.Parse(command.Parameters[0]) - 1;
                    var commentIndex = int.Parse(command.Parameters[1]) - 1;
                    username = command.Parameters[2];
                    //TODO:Implement
                    return null;
                    //return this.RemoveEnemy(towerIndex, commentIndex, username);

                case "ShowUsers":

                    return this.ShowAllUsers();

                case "Showtowers":
                    username = command.Parameters[0];

                    return this.ShowUsertowers(username);

                default:
                    return string.Format(InvalidCommand, command.Name);
            }
        }

        private string RegisterUser(string username, string password)
        {
            if (this.loggedUser != null)
            {
                return string.Format(UserLoggedInAlready, this.loggedUser.Username);
            }

            if (this.users.Any(u => u.Username.ToLower() == username.ToLower()))
            {
                return string.Format(UserAlreadyExist, username);
            }

            //var user = this.factory.CreateUser(username, password);

            //TODO: fix
            //this.loggedUser = user;
            //this.users.Add(user);

            return string.Format(UserRegisterеd, username);
        }

        private string Login(string username, string password)
        {
            if (this.loggedUser != null)
            {
                return string.Format(UserLoggedInAlready, this.loggedUser.Username);
            }

            var userFound = this.users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (userFound != null && userFound.Password == password)
            {
                this.loggedUser = userFound;
                return string.Format(UserLoggedIn, username);
            }

            return WrongUsernameOrPassword;
        }

        private string Logout()
        {
            this.loggedUser = null;
            return UserLoggedOut;
        }

        private string Addtower(object obj, int value)
        {
           // ITower tower = null;

            //if (obj == "BasicTower")
            //{
            //    tower = this.factory.CreateBasicTower(int X, int Y, int level = 1, int width = 1, int height = 1);
            //}
            //else if (obj == "ArcherTower")
            //{
            //    tower = this.factory.CreateBasicTower(X, Y, level = 1, width = 1, height = 1);
            //}
            //else if (obj == "CannonTower")
            //{
            //    tower = this.factory.CreateBasicTower(X, Y, level = 1, width = 1, height = 1);
            //}

            //this.loggedUser.Addtower(tower);

            return string.Format(towerAddedSuccessfully, this.loggedUser.Username);
        }

        private string Removetower(int towerIndex)
        {
            //ValidateRange(towerIndex, 0, this.loggedUser.towers.Count, RemovedtowerDoesNotExist);

            //var tower = this.loggedUser.towers[towerIndex];

            //this.loggedUser.Removetower(tower);

            return string.Format(towerRemovedSuccessfully, this.loggedUser.Username);
        }

        

        private string ShowAllUsers()
        {

            var builder = new StringBuilder();
            builder.AppendLine("--USERS--");
            var counter = 1;
            foreach (var user in this.users)
            {
                builder.AppendLine(string.Format("{0}. {1}", counter, user.ToString()));
                counter++;
            }

            return builder.ToString().Trim();
        }

        private string ShowUsertowers(string username)
        {
            var user = this.users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower());

            if (user == null)
            {
                return string.Format(NoSuchUser, username);
            }

            return user.ToString();
        }

        private static void ValidateRange(int? value, int min, int max, string message)
        {
            if (value < min || value >= max)
            {
                throw new ArgumentException(message);
            }
        }



    }

}
