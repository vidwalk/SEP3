package tier2.controller;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.net.UnknownHostException;

import com.google.gson.Gson;

import tier2.view.Tier2MovieCreatorView;
import common.Movie;
import common.Package;

public class Tier2MovieCreatorThreadHandler implements Runnable {

	private Socket clientSocket;
	private Socket serverSocket;
	private DataInputStream inputStream;
	private DataOutputStream outputStream;
	private Tier2MovieCreatorView view;
	private String ip;

	public Tier2MovieCreatorThreadHandler(Socket clientSocket, Tier2MovieCreatorView view) throws IOException {
		super();
		// Connecting to client socket
		this.clientSocket = clientSocket;
		// Connecting to server socket, remove hard coding
		serverSocket = new Socket("localhost", 1097);
		// Read from client stream
		inputStream = new DataInputStream(clientSocket.getInputStream());

		// Write into client stream
		outputStream = new DataOutputStream(clientSocket.getOutputStream());

		this.view = view;

		this.ip = clientSocket.getInetAddress().getHostAddress();
		view.show(ip + " connected");
	}

	/**
	 * This method waits for a request Package from the client then sends a reply
	 * Package back to him
	 * 
	 * @see operation
	 * @see Package
	 */
	@Override
	public void run() {
		boolean continueCommuticating = true;
		try {
			while (continueCommuticating) {

				String line = inputStream.readUTF();
				view.show(ip + "> " + line);

				// convert from JSon
				// getting request from client
				Gson gson = new Gson();
				System.out.println(line);
				Package request = gson.fromJson(line, Package.class);
				view.show("package: " + request.getHeader());

				// creating reply by communicating with tier 3 server
				Package reply = operation(request);

				// convert to JSon
				// sending reply to client
				String json = gson.toJson(reply);
				outputStream.writeUTF(json);
				view.show("Server to " + ip + "> " + reply);
				if (reply.getHeader().equalsIgnoreCase("EXIT")) {
					continueCommuticating = false;
				}
			}
			view.show("Closing connection to client: " + ip);

		} catch (Exception e) {
			String message = e.getMessage();
			if (message == null) {
				message = "Connection lost";
			}
			view.show("Error for client: " + ip + " - Message: " + message);
		}
	}

	/**
	 * Method that takes the request Package then uses the model to create a reply
	 * Package depending on the request
	 * 
	 * @param request The Package received from the client
	 * @return a Package containing what the client requested
	 * @throws IOException
	 * @throws UnknownHostException
	 * @see Package
	 */

//Are we using packages or something else? What about the package class itself?
	private Package operation(Package request) throws UnknownHostException, IOException {
		DataInputStream inputStream;
		DataOutputStream outputStream;
		Gson gson = new Gson();
		String json = "";
		String line = "";
		Package replyFromServer;
		Package requestToServer;
		this.ip = clientSocket.getInetAddress().getHostAddress();
		view.show(ip + " connected");
		switch (request.getHeader()) {
		case Package.GET:
			// Read from server stream
			inputStream = new DataInputStream(serverSocket.getInputStream());

			// Write into server stream
			outputStream = new DataOutputStream(serverSocket.getOutputStream());
			// sending request to tier 3 server
			
			json = gson.toJson(request);
			outputStream.writeUTF(json);

			// getting reply from tier 3 server
			line = inputStream.readUTF();
			view.show(ip + "> " + line);

			// convert from JSon

			replyFromServer = gson.fromJson(line, Package.class);
			view.show("package: " + replyFromServer.getBody());
			// Close the streams when you are done
			inputStream.close();
			outputStream.close();
			return replyFromServer;
		case Package.ADD:
			// Read from server stream
			inputStream = new DataInputStream(serverSocket.getInputStream());

			// Write into server stream
			outputStream = new DataOutputStream(serverSocket.getOutputStream());
			// sending request to tier 3 server
			gson = new Gson();
			requestToServer = new Package("ADD", request.getMovie());
			json = gson.toJson(requestToServer);
			outputStream.writeUTF(json);

			// getting reply from tier 3 server
			line = inputStream.readUTF();
			view.show(ip + "> " + line);

			// convert from JSon

			replyFromServer = gson.fromJson(line, Package.class);
			view.show("package: " + replyFromServer.getBody());
			// Close the streams when you are done
			inputStream.close();
			outputStream.close();
			return replyFromServer;
		default:
			return new Package("WRONG FORMAT");

		}
	}

	public void close() {
		try {
			inputStream.close();
			outputStream.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}