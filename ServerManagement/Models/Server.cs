using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models;

public class Server
{
    public Server()
    {
        var random = new Random();
        var randomNumber = random.Next(0, 2);
        IsOnline = randomNumber == 0 ? false : true;
    }

    public int ServerId { get; set; }

    public bool IsOnline { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    public string City { get; set; } = string.Empty;
}
