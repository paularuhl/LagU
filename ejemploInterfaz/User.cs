using Interfaces;

namespace Classes
{
    public class User : IUser
    {

        private string Name { get; set; }
        private string LastName { get; set; }

        public User(string name){
            this.Name=name;
        }
        public string GetFullName()
        {
            return string.Format("Nombre: {0} Apellido: {1}",this.Name,this.LastName);
        }

        public void SetLastName(string lastname)
        {
            this.LastName = lastname;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}