# Example_MVC

This is a sample ASP.NET Core MVC application demonstrating the Model-View-Controller architecture.

## Features

- **Model-View-Controller (MVC) Architecture**: Separates the application into three main components to promote organized code structure.
- **Routing**: Configured to direct incoming requests to the appropriate controller actions.
- **Views**: Utilizes Razor syntax for dynamic HTML generation.

## Prerequisites

- [.NET SDK 6.0 or later](https://dotnet.microsoft.com/download)

## Getting Started

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/abdndmn/Example_MVC.git
   cd Example_MVC
   ```

2. **Build the Application**:
   ```bash
   dotnet build
   ```

3. **Run the Application**:
   ```bash
   dotnet run
   ```
   The application will be accessible at `http://localhost:5000` by default.

## Project Structure

- `Controllers/`: Contains the controller classes responsible for handling user input and interactions.
- `Models/`: Contains the model classes representing the application's data and business logic.
- `Views/`: Contains the Razor views for rendering the UI.
- `Program.cs`: Configures the application's services and middleware.

## Configuration

The default route is configured in `Program.cs`:
```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```
This route directs requests to the `HomeController`'s `Index` action by default.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
