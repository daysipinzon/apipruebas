using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APIPRUEBAS1.Models;

[Table("CATEGORIA")]
public partial class Categoria
{
    [Key]
    public int IdCategoria { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    
    public virtual ICollection<Producto> Producto { get; set; } = new List<Producto>();
}
