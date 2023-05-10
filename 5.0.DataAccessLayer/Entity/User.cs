using _5._0.DataAccessLayer.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _5._0.DataAccessLayer.Entity
{
    [Table("tuser")]
    public class User : EntityGeneric
    {
        #region properties

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idUser { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        #endregion

        #region children

        [InverseProperty("parentUser")]
        public List<Person> childPerson { get; set; }

        #endregion
    }
}