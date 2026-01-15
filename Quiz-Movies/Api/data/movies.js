const express = require("express");

/**
 * @class MoviesApi
 * Clase que proporciona la lista de películas de los años 90.
 */

class MoviesApi {
  
  /**
   * @method loadMovies
   * Carga y devuelve una lista de películas con sus propiedades principales.
   *
   * Cada película incluye:
   * - Id: Identificador único.
   * - Title: Título de la película.
   * - Director: Nombre del director.
   * - Year: Año de estreno.
   * - Genre: Género de la película.
   * - Summary: Breve resumen o sinopsis.
   *
   * @returns {Array<Object>} Lista de películas.
   */

  static loadMovies() {
    const movies = [
      {
        Id: 1,
        Title: "Goodfellas",
        Director: "Martin Scorsese",
        Year: 1990,
        Genre: "Crime",
        Summary:
          "La vida de Henry Hill y sus amigos en la mafia a lo largo de los años.",
      },
      {
        Id: 2,
        Title: "Home Alone",
        Director: "Chris Columbus",
        Year: 1990,
        Genre: "Comedy",
        Summary:
          "Un niño es olvidado en casa durante las vacaciones y defiende su hogar de dos ladrones torpes.",
      },
      {
        Id: 3,
        Title: "The Silence of the Lambs",
        Director: "Jonathan Demme",
        Year: 1991,
        Genre: "Thriller",
        Summary:
          "Una joven agente del FBI busca la ayuda de un asesino en serie encarcelado para atrapar a otro criminal.",
      },
      {
        Id: 4,
        Title: "Terminator 2: Judgment Day",
        Director: "James Cameron",
        Year: 1991,
        Genre: "Sci-Fi",
        Summary:
          "Un cyborg protege a un niño que será clave para salvar al futuro de la humanidad.",
      },
      {
        Id: 5,
        Title: "Jurassic Park",
        Director: "Steven Spielberg",
        Year: 1993,
        Genre: "Adventure",
        Summary:
          "Un parque temático con dinosaurios clonados se convierte en un caos mortal.",
      },
      {
        Id: 6,
        Title: "Schindler's List",
        Director: "Steven Spielberg",
        Year: 1993,
        Genre: "Drama",
        Summary:
          "Un empresario alemán salva a más de mil judíos durante el Holocausto.",
      },
      {
        Id: 7,
        Title: "Pulp Fiction",
        Director: "Quentin Tarantino",
        Year: 1994,
        Genre: "Crime",
        Summary:
          "Historias entrelazadas de crimen, venganza y redención en Los Ángeles.",
      },
      {
        Id: 8,
        Title: "Forrest Gump",
        Director: "Robert Zemeckis",
        Year: 1994,
        Genre: "Drama",
        Summary:
          "La increíble vida de Forrest Gump, un hombre con gran corazón, a lo largo de décadas de historia estadounidense.",
      },
      {
        Id: 9,
        Title: "The Shawshank Redemption",
        Director: "Frank Darabont",
        Year: 1994,
        Genre: "Drama",
        Summary:
          "Un banquero injustamente encarcelado forma una amistad que cambiará su vida dentro de prisión.",
      },
      {
        Id: 10,
        Title: "Se7en",
        Director: "David Fincher",
        Year: 1995,
        Genre: "Thriller",
        Summary:
          "Dos detectives persiguen a un asesino que mata siguiendo los siete pecados capitales.",
      },
      {
        Id: 11,
        Title: "Toy Story",
        Director: "John Lasseter",
        Year: 1995,
        Genre: "Animation",
        Summary:
          "Los juguetes cobran vida y viven aventuras cuando los humanos no están presentes.",
      },
      {
        Id: 12,
        Title: "Braveheart",
        Director: "Mel Gibson",
        Year: 1995,
        Genre: "History",
        Summary:
          "La vida de William Wallace y su lucha por la libertad de Escocia contra Inglaterra.",
      },
      {
        Id: 13,
        Title: "Fargo",
        Director: "Joel Coen",
        Year: 1996,
        Genre: "Crime",
        Summary:
          "Un secuestro planeado sale mal en Minnesota, con consecuencias trágicas y cómicas.",
      },
      {
        Id: 14,
        Title: "Trainspotting",
        Director: "Danny Boyle",
        Year: 1996,
        Genre: "Drama",
        Summary:
          "Un grupo de jóvenes adictos en Edimburgo enfrenta la vida, la droga y la amistad.",
      },
      {
        Id: 15,
        Title: "Titanic",
        Director: "James Cameron",
        Year: 1997,
        Genre: "Romance",
        Summary:
          "Un romance prohibido florece a bordo del lujoso y fatídico barco Titanic.",
      },
      {
        Id: 16,
        Title: "The Big Lebowski",
        Director: "Joel Coen",
        Year: 1998,
        Genre: "Comedy",
        Summary:
          "Un hombre llamado 'El Nota' se ve envuelto en una absurda confusión criminal.",
      },
      {
        Id: 17,
        Title: "Saving Private Ryan",
        Director: "Steven Spielberg",
        Year: 1998,
        Genre: "War",
        Summary:
          "Durante la Segunda Guerra Mundial, un grupo de soldados busca a un paracaidista para salvarlo.",
      },
      {
        Id: 18,
        Title: "The Truman Show",
        Director: "Peter Weir",
        Year: 1998,
        Genre: "Drama",
        Summary:
          "Un hombre descubre que toda su vida ha sido un reality show televisado.",
      },
      {
        Id: 19,
        Title: "American History X",
        Director: "Tony Kaye",
        Year: 1998,
        Genre: "Drama",
        Summary:
          "Un joven neonazi cambia su vida tras pasar tiempo en prisión y enfrentarse a su pasado.",
      },
      {
        Id: 20,
        Title: "The Matrix",
        Director: "The Wachowskis",
        Year: 1999,
        Genre: "Sci-Fi",
        Summary:
          "Un hacker descubre que la realidad es una simulación y lucha por la libertad humana.",
      },
      {
        Id: 21,
        Title: "Fight Club",
        Director: "David Fincher",
        Year: 1999,
        Genre: "Drama",
        Summary:
          "Un hombre insomne crea un club secreto de lucha que se sale de control.",
      },
      {
        Id: 22,
        Title: "The Sixth Sense",
        Director: "M. Night Shyamalan",
        Year: 1999,
        Genre: "Thriller",
        Summary:
          "Un niño que ve muertos busca ayuda de un psicólogo para entender lo que ve.",
      },
      {
        Id: 23,
        Title: "The Green Mile",
        Director: "Frank Darabont",
        Year: 1999,
        Genre: "Drama",
        Summary:
          "Un guardia de prisión descubre que un condenado a muerte tiene poderes extraordinarios.",
      },
      {
        Id: 24,
        Title: "Eyes Wide Shut",
        Director: "Stanley Kubrick",
        Year: 1999,
        Genre: "Drama",
        Summary:
          "Un hombre se embarca en un peligroso y secreto mundo sexual tras descubrir la infidelidad de su esposa.",
      },
      {
        Id: 25,
        Title: "Casino",
        Director: "Martin Scorsese",
        Year: 1995,
        Genre: "Crime",
        Summary:
          "Un hombre administra un casino de Las Vegas mientras enfrenta traiciones y violencia del crimen organizado.",
      },
      {
        Id: 26,
        Title: "Heat",
        Director: "Michael Mann",
        Year: 1995,
        Genre: "Crime",
        Summary:
          "Un ladrón profesional y un detective se enfrentan en un juego mortal de estrategia.",
      },
      {
        Id: 27,
        Title: "Clueless",
        Director: "Amy Heckerling",
        Year: 1995,
        Genre: "Comedy",
        Summary:
          "Una adolescente rica y superficial intenta hacer que todos a su alrededor sean felices y populares.",
      },
      {
        Id: 28,
        Title: "Men in Black",
        Director: "Barry Sonnenfeld",
        Year: 1997,
        Genre: "Sci-Fi",
        Summary:
          "Agentes secretos controlan la actividad alienígena en la Tierra sin que nadie lo sepa.",
      },
      {
        Id: 29,
        Title: "Groundhog Day",
        Director: "Harold Ramis",
        Year: 1993,
        Genre: "Comedy",
        Summary:
          "Un meteorólogo queda atrapado repitiendo el mismo día una y otra vez.",
      },
      {
        Id: 30,
        Title: "The Lion King",
        Director: "Roger Allers",
        Year: 1994,
        Genre: "Animation",
        Summary:
          "El joven león Simba lucha por reclamar su reino tras la traición de su tío.",
      },
      {
        Id: 31,
        Title: "Scream",
        Director: "Wes Craven",
        Year: 1996,
        Genre: "Horror",
        Summary:
          "Un asesino enmascarado aterroriza a un grupo de adolescentes en un pequeño pueblo.",
      },
      {
        Id: 32,
        Title: "The Usual Suspects",
        Director: "Bryan Singer",
        Year: 1995,
        Genre: "Crime",
        Summary:
          "Cinco criminales son interrogados sobre un misterioso jefe criminal llamado Keyser Söze.",
      },
      {
        Id: 33,
        Title: "Independence Day",
        Director: "Roland Emmerich",
        Year: 1996,
        Genre: "Sci-Fi",
        Summary:
          "Alienígenas atacan la Tierra y un grupo de héroes intenta salvar la humanidad.",
      },
      {
        Id: 34,
        Title: "Jerry Maguire",
        Director: "Cameron Crowe",
        Year: 1996,
        Genre: "Romance",
        Summary:
          "Un agente deportivo intenta reconstruir su carrera y su vida amorosa.",
      },
      {
        Id: 35,
        Title: "Blade",
        Director: "Stephen Norrington",
        Year: 1998,
        Genre: "Action",
        Summary:
          "Un hombre mitad humano mitad vampiro lucha para proteger a la humanidad.",
      },
      {
        Id: 36,
        Title: "Rush Hour",
        Director: "Brett Ratner",
        Year: 1998,
        Genre: "Action",
        Summary:
          "Un detective estadounidense y otro chino deben rescatar a una joven secuestrada.",
      },
      {
        Id: 37,
        Title: "The Mask",
        Director: "Chuck Russell",
        Year: 1994,
        Genre: "Comedy",
        Summary:
          "Un hombre tímido encuentra una máscara que le da poderes cómicos y sobrehumanos.",
      },
      {
        Id: 38,
        Title: "Léon: The Professional",
        Director: "Luc Besson",
        Year: 1994,
        Genre: "Crime",
        Summary:
          "Un asesino profesional entrena a una joven que busca venganza por la muerte de su familia.",
      },
      {
        Id: 39,
        Title: "The Blair Witch Project",
        Director: "Daniel Myrick",
        Year: 1999,
        Genre: "Horror",
        Summary:
          "Tres estudiantes desaparecen mientras graban un documental sobre la leyenda de la Bruja de Blair.",
      },
      {
        Id: 40,
        Title: "Being John Malkovich",
        Director: "Spike Jonze",
        Year: 1999,
        Genre: "Fantasy",
        Summary:
          "Un portal permite a la gente entrar en la mente del actor John Malkovich.",
      },
    ];
    return movies;
  }
}


module.exports = MoviesApi;
