using System;
using System.Collections.Generic;

namespace TC5_Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>(); 
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers");
            nombresDePelicula.Add("Bicentennial Man");
            nombresDePelicula.Add("Beetlejuice");
            nombresDePelicula.Add("Silence of the Lambs");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Bad Boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");

            HashSet<string> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Avengers");
            nombresDePeliculaSet.Add("Bicentennial Man");
            nombresDePeliculaSet.Add("Beetlejuice");
            nombresDePeliculaSet.Add("Silence of the Lambs");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Bad Boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");

            Console.WriteLine("Cant. de películas en nombresDePelicula: " + nombresDePelicula.Count);
            Console.WriteLine("Cant. de películas en nombresDePeliculaSet: " + nombresDePeliculaSet.Count);

            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add(new Pelicula("Bad Boys", 1995));
            peliculasSet.Add(new Pelicula("Bad Boys", 1983));
            peliculasSet.Add(new Pelicula("Aladdin", 2019));
            peliculasSet.Add(new Pelicula("Aladdin", 1992));
            //Son objetos distintos incluso si tienen los mismos datos
            peliculasSet.Add(new Pelicula("Aladdin", 1992)); 
            Console.WriteLine("Cant. de películas en nombresDePeliculaSet: " + peliculasSet.Count);

            // Map -> Java
            // Dictionary -> C#, python
            // Object -> Javascript      
            
            Dictionary<string, string> nombresDePeliculaFavorita = new Dictionary<string, string>();
            nombresDePeliculaFavorita.Add("Pablo", "Titanic");
            nombresDePeliculaFavorita.Add("Esteban", "The Fast and the Furious: Tokyo Drift");
            nombresDePeliculaFavorita.Add("Octavio", "Barbie and the 12 dancing princess");

            string nombrePeliculaFavoritaPablo = nombresDePeliculaFavorita.GetValueOrDefault("Pablo");
            Console.WriteLine("nombrePeliculaFavoritaPablo: " + nombrePeliculaFavoritaPablo);

            string nombrePeliculaFavoritaRamiro = nombresDePeliculaFavorita.GetValueOrDefault("Ramiro");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //null
            
            nombrePeliculaFavoritaRamiro = nombresDePeliculaFavorita.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //(Ninguna)

            nombresDePeliculaFavorita.Add("Ramiro", "Avatar");

            nombrePeliculaFavoritaRamiro = nombresDePeliculaFavorita.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("nombrePeliculaFavoritaRamiro: " + nombrePeliculaFavoritaRamiro); //Avatar

            // Uso real de obtener valores de Dictionary 
            // out -> se declara una nueva variable donde se recibirá el resultado (el valor de "salida")
            if (nombresDePeliculaFavorita.TryGetValue("María", out string nombrePeliculaFavoritaMaria))
            {
                Console.WriteLine("nombrePeliculaFavoritaMaría: " + nombrePeliculaFavoritaMaria);
            }
            else
            {
                Console.WriteLine("María no tiene película favorita.");
            }

            //Lista
            Console.WriteLine("---------------");
            Console.WriteLine("Lista");
            for (int i = 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);
            }

            // HashSet
            Console.WriteLine("---------------");
            Console.WriteLine("HashSet");
            // foreach: elemento in conjunto
            foreach (string nombrePelicula in nombresDePeliculaSet)
            {
                Console.WriteLine(nombrePelicula);
            }

            // Dictionary
            Console.WriteLine("---------------");
            Console.WriteLine("Dictionary");
            foreach (var key in nombresDePeliculaFavorita.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in nombresDePeliculaFavorita.Values)
            {
                Console.WriteLine(value);
            }
            foreach (var key in nombresDePeliculaFavorita.Keys)
            {
                Console.WriteLine(key + ":" + nombresDePeliculaFavorita.GetValueOrDefault(key));
            }
        }
    }
}
