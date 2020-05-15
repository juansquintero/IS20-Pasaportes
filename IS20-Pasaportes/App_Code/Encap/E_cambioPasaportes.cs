using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_cambioPasaportes
/// </summary>
[Serializable]
[Table("cambioPasaportes", Schema = "proyecto")]
public class E_cambioPasaportes
{
        private int id;
        private string session;
        private DateTime? changeDate;
        private string user_name;
        private int? pasaportesAmount;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("session")]
        public string Session { get => session; set => session = value; }
        [Column("changeDate")]
        public DateTime? ChangeDate { get => changeDate; set => changeDate = value; }
        [Column("user_name")]
        public string User_name { get => user_name; set => user_name = value; }
        [Column("pasaportesAmount")]
        public int? PasaportesAmount { get => pasaportesAmount; set => pasaportesAmount = value; }

        
        

}
