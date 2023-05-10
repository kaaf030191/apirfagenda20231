using _5._0.DataAccessLayer.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5._0.DataAccessLayer.Entity
{
    [Table("tperson")]
    public class Person : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idPerson { get; set; }
        public string idUser { get; set; }
        public string idCity { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        #endregion

        #region parents

        [ForeignKey(nameof(idUser))]
        public User parentUser { get; set; }

        [ForeignKey(nameof(idCity))]
        public City parentCity { get; set; }

        #endregion
    }
}