using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


///Declaracion de variables tabla: usuario

[Serializable]
[Table("usuario", Schema = "proyecto")]
public class E_user
{
    private int id;
    private Nullable<int> id_rol;
    private int? id_ruta;
    private string name;
    private string last_name;
    private string user_name;
    private string pass;
    private int? pasaporte_numero;
    private bool? activo;
    private string sesion;
    private Nullable<DateTime> lastModified;
    private int? id_driver;
    private string qr_hash;
    private string mail;
    private string token;
    private DateTime? end_token;
    private int? state_id;
    private string profile_pic;
   
    //FK

    private string name_empresa;
    private int driver_total_pasaporte;
    private string name_rol;
    private string name_ruta;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("id_rol")]
    public int? Id_rol { get => id_rol; set => id_rol = value; }
    [Column("name")]
    public string Name { get => name; set => name = value; }
    [Column("last_name")]
    public string Last_name { get => last_name; set => last_name = value; }
    [Column("user_name")]
    public string User_name { get => user_name; set => user_name = value; }
    [Column("pass")]
    public string Pass { get => pass; set => pass = value; }
    [Column("pasaporte_numero")]
    public int? Pasaporte_numero { get => pasaporte_numero; set => pasaporte_numero = value; }
    [Column("activo")]
    public bool? Activo { get => activo; set => activo = value; }
    [Column("sesion")]
    public string Sesion { get => sesion; set => sesion = value; }
    [Column("last_modified")]
    public Nullable<DateTime> LastModified { get => lastModified; set => lastModified = value; }
    [Column("id_driver")]
    public int? Id_driver { get => id_driver; set => id_driver = value; }
    [Column("id_ruta")]
    public int? Id_ruta { get => id_ruta; set => id_ruta = value; }
    [Column("qr_hash")]
    public string Qr_hash { get => qr_hash; set => qr_hash = value; }
    [Column("mail")]
    public string Mail { get => mail; set => mail = value; }
    [Column("token")]
    public string Token { get => token; set => token = value; }
    [Column("end_token")]
    public DateTime? EndToken { get => end_token; set => end_token = value; }
    [Column("state_id")]
    public int? State_Id { get => state_id; set => state_id = value; }
    [Column("profile_pic")]
    public string Profile_pic { get => profile_pic; set => profile_pic = value; }


    //FK

    [NotMapped]
    public string Name_empresa { get => name_empresa; set => name_empresa = value; }
    [NotMapped]
    public int Driver_total_pasaporte { get => driver_total_pasaporte; set => driver_total_pasaporte = value; }
    [NotMapped]
    public string Name_rol { get => name_rol; set => name_rol = value; }
    [NotMapped]
    public string Name_ruta { get => name_ruta; set => name_ruta = value; }
    
}