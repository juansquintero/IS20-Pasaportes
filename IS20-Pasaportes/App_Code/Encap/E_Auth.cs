using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

[Serializable]
[Table("autentication", Schema = "security")]
public class E_Auth
{
    private long id;
    private int user_id;
    private string ip;
    private string mac;
    private DateTime fecha_inicio;
    private DateTime? fecha_fin;
    private string session;

    [Key]
    [Column("id")]
    public long Id { get => id; set => id = value; }
    [Column("user_id")]
    public int User_id { get => user_id; set => user_id = value; }
    [Column("ip")]
    public string Ip { get => ip; set => ip = value;}
    [Column("mac")]
    public string Mac { get => mac; set => mac = value; }
    [Column("fecha_inicio")]
    public DateTime fecha_Inicio { get => fecha_inicio; set => fecha_inicio = value; }
    [Column("fecha_fin")]
    public DateTime? fecha_Fin { get => fecha_fin; set => fecha_fin = value; }
    [Column("session")]
    public string Session { get => session; set => session = value; }

}