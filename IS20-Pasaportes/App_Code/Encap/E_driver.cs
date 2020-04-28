using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

///Declaracion de variables tabla: conductor

[Serializable]
[Table("conductor", Schema = "proyecto")]
public class E_driver
{
    private int id;
    private string empresa;
    private int? total_pasaporte;   

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("empresa")]
    public string Empresa { get => empresa; set => empresa = value; }
    [Column("total_pasaporte")]
    public int? Total_pasaporte { get => total_pasaporte; set => total_pasaporte = value; }
}