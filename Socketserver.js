const express = require('express');
const http = require('http');
const socketIo = require('socket.io');

// Initialize Express app and HTTP server
const app = express();
const server = http.createServer(app);
const io = socketIo(server);

// Serve static files (like HTML, CSS, JS) from the 'public' directory
app.use(express.static('public'));
let counter=0;
// Handle socket connections
io.on('connection', (socket) => {
    counter=counter+1;
  console.log(counter +' user connected');
  
  // Handle a 'message' event from the client
  socket.on('message', (msg) => {
    console.log('message received: ' + msg);
    
    // Broadcast the message to all connected clients
    io.emit('message', msg);
  });

  // Handle disconnection
  socket.on('disconnect', () => {
    console.log('user disconnected');
  });
});

// Start the server on port 3000
server.listen(3000, () => {
  console.log('listening on *:3000');
});


