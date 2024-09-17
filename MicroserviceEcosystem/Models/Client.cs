using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroserviceEcosystem.Models
{
    [Table("client", Schema = "cli")]
    public class Client
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; } = null!;

        [Column("last_name")]
        public string LastName { get; set; } = null!;

        [Column("middle_name")]
        public string MiddleName { get; set; } = null!;

        [Column("second_surname")]
        public string SecondSurname { get; set; } = null!;

        [Column("address")]
        public string Address { get; set; } = null!;

        [Column("phone")]
        public int Phone { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]

        public DateTime UpdatedAt { get; set; }

    }

}
