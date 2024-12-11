
const Version = require('../models/Version');

// Lấy phiên bản mới nhất
exports.getLatestVersion = async (req, res) => {
  try {
    const latestVersion = await Version.findOne().sort({ createdAt: -1 });
    if (!latestVersion) {
      return res.status(404).json({ success: false, message: 'Không có phiên bản nào.' });
    }
    res.json({ success: true, data: latestVersion });
  } catch (err) {
    res.status(500).json({ success: false, message: 'Lỗi server', error: err.message });
  }
};

// Kiểm tra phiên bản hiện tại
exports.checkVersion = async (req, res) => {
  const { currentVersion } = req.body;
  if (!currentVersion) {
    return res.status(400).json({ success: false, message: 'Vui lòng cung cấp phiên bản hiện tại.' });
  }
  try {
    const latestVersion = await Version.findOne().sort({ createdAt: -1 });
    if (!latestVersion) {
      return res.status(404).json({ success: false, message: 'Không có phiên bản nào.' });
    }
    if (currentVersion === latestVersion.version) {
      return res.json({ success: false, message: 'Bạn đang sử dụng phiên bản mới nhất.' });
    }
    res.json({ success: true, message: 'Có bản cập nhật mới.', data: latestVersion });
  } catch (err) {
    res.status(500).json({ success: false, message: 'Lỗi server', error: err.message });
  }
};

// Thêm phiên bản mới
exports.addVersion = async (req, res) => {
  const { version, url } = req.body;
  if (!version || !url) {
    return res.status(400).json({ success: false, message: 'Vui lòng cung cấp đầy đủ thông tin (version, url).' });
  }
  try {
    const newVersion = new Version({ version, url });
    await newVersion.save();
    res.status(201).json({ success: true, data: newVersion });
  } catch (err) {
    res.status(500).json({ success: false, message: 'Lỗi server', error: err.message });
  }
};

