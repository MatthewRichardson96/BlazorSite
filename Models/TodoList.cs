using System.ComponentModel.DataAnnotations;
using BlazorApp.Constants.Helpers.Validation;

namespace BlazorApp.Components.Models;

public class TodoItem
{
    [RegularExpression(RegularExpressions.NoNumbersAndSpecialCharacters)]
    public string? Title { get; set; }
    
    public bool IsDone { get; set; }
}