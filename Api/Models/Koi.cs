using System.Drawing;

namespace Api.Models;

public class Koi
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public double Weight { get; set; }
    public DateTime Created { get; set; }
}