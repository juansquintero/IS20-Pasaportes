using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

///Declaracion de variables tabla: rol

[Serializable]
[Table("rol", Schema = "proyecto")]
public class E_rol
{
    private int id;
    private string rol_name;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("rol_name")]
    public string Rol_name { get => rol_name; set => rol_name = value; }
}