namespace WebAPISimple.Models
{

    public class User
    {
        public int Id { get; set; } // pragma warning disable deb ozilsa warninglarni ko'rsatmedi
        public string? FirstName { get; set; }  // ? bu anashu propertyni null bo'pqolishi mumkinligini bildiradi
        public string? LastName { get; set; }
    }
}
