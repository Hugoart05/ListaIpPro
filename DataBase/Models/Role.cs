namespace DataBase.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}