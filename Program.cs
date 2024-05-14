using MoviesLab;
using System.Collections.Generic;
using System.ComponentModel;

List<Movie> Movies = new List<Movie>();



//I used comedy instead of scifi !!!

Movies.Add(new Movie() { title = "The Godfather", category = "Drama"});
Movies.Add(new Movie() { title = "Tootsie", category = "Comedy" });
Movies.Add(new Movie() { title = "The Chainsaw Massacre", category = "Horror" });
Movies.Add(new Movie() { title = "The Full Monty", category = "Comedy" });
Movies.Add(new Movie() { title = "Breaking Away", category = "Comedy" });
Movies.Add(new Movie() { title = "Trouble With The Curve", category = "Drama" });
Movies.Add(new Movie() { title = "Mean Machine", category = "Comedy" });
Movies.Add(new Movie() { title = "Ratatouille", category = "Animated" });
Movies.Add(new Movie() { title = "Casablanca", category = "Drama" });
Movies.Add(new Movie() { title = "It Happened One Night", category = "Comedy" });


foreach (Movie m in Movies)
{
    Console.WriteLine(m.title +"  " + m.category);
}


//Get user input
Console.WriteLine(Validator.GetInputChr());





//List<Movie> MyList = new List<Movie>();
//var MyList = (List<Movie>)Movies.Where(m => Movies.Any(m => m.category.StartsWith(Validator.GetInputChr())));

//Console.WriteLine("test");
