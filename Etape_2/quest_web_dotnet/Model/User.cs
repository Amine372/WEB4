using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace quest_web.Models
{
    public enum UserRole
    {
        ROLE_USER,
        ROLE_ADMIN
    }

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [EnumDataType(typeof(UserRole))]
        [Column(TypeName = "varchar(255)")]
        public UserRole Role { get; set; } = UserRole.ROLE_USER;

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }

        public User()
        {
            CreationDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Role: {Role}, CreationDate: {CreationDate}, UpdatedDate: {UpdatedDate}";
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is User user && Id == user.Id;
        }
    }
}
