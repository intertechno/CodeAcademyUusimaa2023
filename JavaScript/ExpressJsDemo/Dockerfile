# Use an official Node.js runtime as a parent image
FROM node:latest

# Set the working directory in the container
WORKDIR /usr/src/app

# Copy package.json and package-lock.json (if available)
COPY package*.json ./

# Install any dependencies
RUN npm install

# Bundle your app's source code inside the Docker image
COPY . .

# Your app binds to port 5400 so you'll use the EXPOSE instruction to have it mapped by the docker daemon
EXPOSE 5400

# Define the command to run your app
CMD [ "node", "app.js" ]
