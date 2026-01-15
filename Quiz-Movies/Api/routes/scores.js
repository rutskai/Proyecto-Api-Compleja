const express = require("express");
const router = express.Router();
const fs = require("fs");

const file = "score.json"; 

let scoreData;


if (fs.existsSync(file)) {
  const data = fs.readFileSync(file, "utf8");
  scoreData = JSON.parse(data);
} else {
  scoreData = {
    Points: 0,
    Date: new Date(),
    Message: "Score inicial"
  };
  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
}


/**
 * @route GET /
 * @desc Obtiene la puntuación actual del usuario.
 * Actualiza la fecha y el mensaje antes de enviar la respuesta.
 * @returns {Object} scoreData - Objeto con Points, Date y Message.
 */
router.get("/", (req, res) => {
  scoreData.Date = new Date();
  scoreData.Message = "Score actual";

  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
  res.json(scoreData);
});

/**
 * @route PUT /update
 * @desc Incrementa la puntuación del usuario en 20 puntos.
 * Actualiza la fecha y el mensaje antes de enviar la respuesta.
 * @returns {Object} scoreData - Objeto actualizado con Points, Date y Message.
 */

router.put("/update", (req, res) => {
  scoreData.Points += 20;
  scoreData.Date = new Date();
  scoreData.Message = "Score añadido correctamente";

  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
  res.json(scoreData);
});

/**
 * @route DELETE /reset
 * @desc Reinicia la puntuación del usuario a 0.
 * Actualiza la fecha y el mensaje antes de enviar la respuesta.
 * @returns {Object} scoreData - Objeto actualizado con Points = 0, Date y Message.
 */
router.delete("/reset", (req, res) => {
  scoreData.Points = 0;
  scoreData.Date = new Date();
  scoreData.Message = "Score reiniciado correctamente";

  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
  res.json(scoreData);
});

module.exports = router;
