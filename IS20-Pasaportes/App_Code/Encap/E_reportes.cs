using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for E_reportes
/// </summary>
[Serializable]
[Table("reportes", Schema = "proyecto")]
public class E_reportes
{
    private int id;
    private string path;
    private DateTime? reportDate;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("path")]
    public string Path { get => path; set => path = value; }
    [Column("reportDate")]
    public DateTime? ReportDate { get => reportDate; set => reportDate = value; }
}
