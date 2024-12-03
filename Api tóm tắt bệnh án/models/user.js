const mongoose = require('mongoose');

const userSchema = new mongoose.Schema({
  name: { type: String, required: true },
  department: { type: String, required: true },
  employeeCode: { type: String, required: true },
  usageCount: { type: Number, default: 0 },
});

module.exports = mongoose.model('User', userSchema);
