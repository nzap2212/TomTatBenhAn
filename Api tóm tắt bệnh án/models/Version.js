
const mongoose = require('mongoose');

const VersionSchema = new mongoose.Schema({
  version: { type: String, required: true },
  url: { type: String, required: true },
  createdAt: { type: Date, default: Date.now }
});

module.exports = mongoose.model('Version', VersionSchema);
