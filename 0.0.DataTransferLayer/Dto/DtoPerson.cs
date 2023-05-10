using _0._0.DataTransferLayer.Generic;

namespace _0._0.DataTransferLayer.Dto
{
    public class DtoPerson : DtoGeneric
    {
        #region properties

        public string idPerson { get; set; }
        public string idUser { get; set; }
        public string idCity { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        #endregion

        #region parents

        public DtoUser parentUser { get; set; }
        public DtoCity parentCity { get; set; }

        #endregion
    }
}