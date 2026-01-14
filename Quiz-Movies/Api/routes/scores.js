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
    Date: new Date().toString("yyyy-MM-dd"),
    Message: "Score inicial"
  };
  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
}


router.get("/", (req, res) => {
  scoreData.Date = new Date();
  scoreData.Message = "Score actual";

  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
  res.json(scoreData);
});


router.post("/update", (req, res) => {
  scoreData.Points += 20;
  scoreData.Date = new Date();
  scoreData.Message = "Score añadido correctamente";

  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
  res.json(scoreData);
});


router.delete("/reset", (req, res) => {
  scoreData.Points = 0;
  scoreData.Date = new Date();
  scoreData.Message = "Score reiniciado correctamente";

  fs.writeFileSync(file, JSON.stringify(scoreData, null, 2), "utf8");
  res.json(scoreData);
});

module.exports = router;
