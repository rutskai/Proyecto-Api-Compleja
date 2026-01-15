const express = require("express");
const moviesRoutes = require("../routes/movies");
const scoresRoutes = require("../routes/scores");

const app = express();
app.use(express.json());

// --- Endpoints de pelícuklas ---
app.use("/movies", moviesRoutes);
app.use("/scores", scoresRoutes);

/**
 * @desc Inicializa el servidor en el puerto 3000 y muestra un mensaje en consola
 */

const port = 3000;
app.listen(port, () => {
  console.log(`Servidor corriendo en http://localhost:${port}\n`);
});

