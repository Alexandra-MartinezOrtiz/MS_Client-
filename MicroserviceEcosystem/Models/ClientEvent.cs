using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroserviceEcosystem.Models {
    [Table("clientEvent", Schema = "cli")]

    public class ClientEvent
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("msUser_user_id")]
        public int MsUserUserId { get; set; }

        [Column("action")]
        public string Action { get; set; } = null!;
        [Column("module")]
        public string Module { get; set; } = null!;
        [Column("message")]
        public string Message { get; set; } = null!;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }


    }

}
 