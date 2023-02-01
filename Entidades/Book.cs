using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Meu.Namespace;

public partial class Book
{
    [Key]
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    [ForeignKey("BookId")]
    [InverseProperty("Books")]
    public virtual ICollection<Category> Categories { get; } = new List<Category>();
}
