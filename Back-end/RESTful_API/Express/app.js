// Express.js 모듈 가져오기
const express = require('express')
const routes = require('./routes/routes');
// mongoose 모듈 가져오기 (npm install mongoose)
const mongoose = require('mongoose')


// Express 애플리케이션 생성
const app = express();
// 서버를 3030 포트에서 실행
const PORT = 3030;


app.use(express.json());
app.use('/', routes);

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});