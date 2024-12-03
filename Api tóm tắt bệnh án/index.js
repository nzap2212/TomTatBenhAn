const express = require('express');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
const cors = require('cors');
const logger = require('morgan');

// Kết nối với MongoDB
mongoose.connect('mongodb+srv://sman888123:d0nRcNi0wwOUIbfc@cluster0.wdpkn.mongodb.net/', {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});
const db = mongoose.connection;
db.on('error', console.error.bind(console, 'MongoDB connection error:'));
db.once('open', () => console.log('Connected to MongoDB'));



// Khởi tạo ứng dụng Express
const app = express();
app.use(express.json());    
app.use(bodyParser.json());
app.use(cors());
app.use(logger('dev'));
// Import routes
const userRoutes = require('./routes/userRoutes');
app.use('/api/users', userRoutes);

// Serve dashboard
app.use(express.static(__dirname));

// Chạy server
const PORT = 3000;
app.listen(PORT, () => console.log(`Server running on http://localhost:${PORT}`));
