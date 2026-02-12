## Database Setup

To recreate the database for this project:

1. Open **SQL Server Management Studio (SSMS)** or your preferred SQL client.
2. Connect to your local SQL Server instance.
3. Create a new empty database (for example: `SistemaReservas`).
4. Open the script located in the `DatabaseScripts/` folder (`SistemaReservas.sql`).
5. Execute the script to generate all tables, relationships, and seed data.

### Notes
- The repository does **not** include `.bak`, `.mdf`, or `.ldf` files to keep it lightweight and portable.
- Always use the provided `.sql` scripts to recreate the database.
- If you need to reset the database, simply drop it and re-run the script.

  ## Running the Application

To run the project after setting up the database:

1. Open the solution file `SistemaReservasLaboratorios.sln` in **Visual Studio**.
2. Make sure the connection string in `appsettings.json` (or in your configuration file) points to the database you created (`SistemaReservas`).
3. Build the solution using **Build > Build Solution**.
4. Run the application by pressing **F5** or selecting **Debug > Start Debugging**.
5. The system will connect to the database and allow you to manage laboratory reservations.

### Notes
- Ensure SQL Server is running before starting the application.
- Update the connection string if your SQL Server instance uses a different name, port, or authentication method.
- If you encounter errors related to missing tables or data, re-run the SQL script located in the `DatabaseScripts/` folder.
