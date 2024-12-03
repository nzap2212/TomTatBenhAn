const User = require('../models/user');

// Thêm user mới
exports.addUser = async (req, res) => {
  try {
    const { name, department, employeeCode } = req.body;
    
    // Kiểm tra user đã tồn tại chưa
    const existingUser = await User.findOne({ name, department, employeeCode });
    if (existingUser) {
      return res.status(200).json({ 
        message: 'User already exists in this department'
      });
    }

    // Nếu chưa tồn tại thì tạo mới
    const user = new User({ name, department, employeeCode });
    await user.save();
    res.status(201).json({ message: 'User added successfully', user });
  } catch (error) {
    res.status(500).json({ message: 'Error adding user', error });
  }
};

// Cập nhật số lượt sử dụng
exports.updateUsage = async (req, res) => {
  try {
    const { name, department, employeeCode } = req.body;
    const user = await User.findOneAndUpdate(
      { name, department, employeeCode },
      { $inc: { usageCount: 1 } },
      { new: false }
    );
    if (!user) return res.status(404).json({ message: 'User not found' });
    res.status(200).json({ message: 'Usage updated successfully', user });
  } catch (error) {
    res.status(500).json({ message: 'Error updating usage', error });
  }
};

// Lấy danh sách user
exports.getUsers = async (req, res) => {
  try {
    const users = await User.find();
    res.status(200).json(users);
  } catch (error) {
    res.status(500).json({ message: 'Error fetching users', error });
  }
};

exports.deleteAllUsers = async (req, res) => {
  try {
    await User.deleteMany({});
    res.status(200).json({ message: 'All users have been deleted successfully' });
  } catch (error) {
    res.status(500).json({ message: 'Error deleting users', error });
  }
};