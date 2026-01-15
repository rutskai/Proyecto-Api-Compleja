const express = require("express");
const router = express.Router();
const MoviesApi = require("../data/movies"); 

const movies = MoviesApi.loadMovies();

/**
 * @route GET /
 * @desc Devuelve todas las películas disponibles.
 * @returns {Array<Object>} Lista completa de películas con propiedades:
 * Id, Title, Director, Year, Genre, Summary.
 */
router.get("/", (req, res) => {
  res.json(movies);
});


/**
 * @route GET /random
 * @desc Devuelve una película aleatoria de la lista de películas.
 * @returns {Object} Un objeto película con propiedades:
 * Id, Title, Director, Year, Genre, Summary.
 */

router.get("/random", (req, res) => {
  const randomIndex = Math.floor(Math.random() * movies.length);
  res.json(movies[randomIndex]);
});

module.exports = router;