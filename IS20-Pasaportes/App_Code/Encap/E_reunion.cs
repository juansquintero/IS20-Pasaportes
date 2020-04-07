using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

///Declaracion de variables tabla: reunion

[Serializable]
[Table("reunion", Schema = "proyecto")]
public class E_reunion
{
    private int id;
    private string acta;
    private Nullable<DateTime> fecha;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("acta")]
    public string Acta { get => acta; set => acta = value; }
    [Column("fecha")]
    public DateTime? Fecha { get => fecha; set => fecha = value; }
}