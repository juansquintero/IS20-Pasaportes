using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for RNG_Gen
/// </summary>
public class RNG_Gen
{
    public static string RNG_gen()
    {
        string rng = Path.GetRandomFileName();
        rng = rng.Replace(".", "");
        return rng;
    }
}