const express = require('express');
const router = express.Router();
const userController = require('../controllers/userController');

// Route thêm user mới
router.post('/add', userController.addUser);

// Route cập nhật số lượt sử dụng
router.post('/update-usage', userController.updateUsage);

// Route lấy danh sách user
router.get('/list', userController.getUsers);

router.delete('/delete-all', userController.deleteAllUsers);

module.exports = router;
