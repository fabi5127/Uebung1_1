﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuestionsAppSimple.DB;

public class Questions
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Content { get; set; } = "";
    public int Votes { get; set; } = 0;
    
    
}
