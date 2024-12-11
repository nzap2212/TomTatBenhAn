
const express = require('express');
const router = express.Router();
const versionController = require('../controllers/versionController');

router.get('/latest', versionController.getLatestVersion);
router.post('/check', versionController.checkVersion);
router.post('/add', versionController.addVersion);

module.exports = router;
