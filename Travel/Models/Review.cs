using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
  public class Review
  {
    public int ReviewId { get; set;}
    public string City { get; set;}
    public string Country { get; set;}
    public string Body { get; set;}
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set;}
    


  }
}