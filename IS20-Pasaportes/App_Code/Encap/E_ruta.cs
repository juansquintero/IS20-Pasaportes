using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

///Declaracion de variables tabla: ruta

[Serializable]
[Table("ruta", Schema = "proyecto")]
public class E_ruta
{
    private int id;
    private string ruta;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("ruta")]
    public string Ruta { get => ruta; set => ruta = value; }
}