using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Meu.Namespace;

public partial class Category
{
    [Key]
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    [ForeignKey("CategoryId")]
    [InverseProperty("Categories")]
    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
