const express = require('express')
const app = express()
const port = 5400

app.get('/', (req, res) => {
  res.send('Hello World from DevOps Training!')
})

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
