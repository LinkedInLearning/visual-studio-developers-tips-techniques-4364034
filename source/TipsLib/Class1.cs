using System.Text.RegularExpressions;

namespace TipsLib;

public class Class1
{

    // Generate a regex to validate if a string is a valid email address
    public static string EmailRegex { get; } = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    // Generate a method to validate if a string is a valid email address
    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, EmailRegex);
    }
}

// Generate a class that represents a movie
public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public string Rating { get; set; }
    public string Runtime { get; set; }
    public string Plot { get; set; }
    public string Poster { get; set; }
    public string ImdbRating { get; set; }
    // Generate a constructor that takes all the properties as parameters
    public Movie(string title, string director, int year, string genre, string rating, string runtime, string plot, string poster, string imdbRating)
    {
        Title = title;
        Director = director;
        Year = year;
        Genre = genre;
        Rating = rating;
        Runtime = runtime;
        Plot = plot;
        Poster = poster;
        ImdbRating = imdbRating;
    }
}
