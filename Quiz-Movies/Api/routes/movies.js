// routes/movies.js
const express = require("express");
const router = express.Router();
const MoviesApi = require("../data/movies"); 

const movies = MoviesApi.loadMovies();

router.get("/", (req, res) => {
  res.json(movies);
});

router.get("/random", (req, res) => {
  const randomIndex = Math.floor(Math.random() * movies.length);
  res.json(movies[randomIndex]);
});

module.exports = router;