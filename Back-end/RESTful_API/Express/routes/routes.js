const express = require('express')
const router = express.Router();
const Controller = require('../controllers/controller');

// GET
router.get('/api/realtime', Controller.getDistinctDroneList);

module.exports = router;