# onlineTickets eCommerce Application

This is a full-stack eCommerce application developed using ASP.NET MVC. It provides comprehensive CRUD (Create, Read, Update, Delete) functionality for managing products, orders, and customers. The application is designed to facilitate a seamless online shopping experience.

https://onlinetickets-app.azurewebsites.net/

## Features

- **CRUD Functionality**: The application allows users to perform CRUD operations on products, orders, and customers. This includes creating new items, retrieving and displaying existing records, updating information, and deleting unnecessary data.

- **Secure Payment Processing**: The application is integrated with PayPal for secure and reliable payment processing. Users can make purchases with confidence, knowing that their financial information is protected.

- **Robust Authentication**: The application incorporates robust authentication features, leveraging the latest advancements in .NET 6 technology. User registration, login, and password management are implemented to ensure secure access to the system.

## Technologies Used

- **ASP.NET MVC**: The application is built using the ASP.NET MVC framework, which provides a powerful and flexible architecture for developing web applications.

- **PayPal API**: Integration with the PayPal API allows for seamless and secure payment processing.

- **C#**: The backend logic of the application is implemented using C#, a versatile and object-oriented programming language.

- **Entity Framework**: Entity Framework is utilized as the Object-Relational Mapping (ORM) tool for interacting with the database.

- **HTML/CSS/JavaScript**: The front-end interface is developed using a combination of HTML, CSS, and JavaScript, ensuring an intuitive and user-friendly experience.

## Setup and Usage

To set up and run the application locally, follow these steps:

1. Clone the repository: `git clone https://github.com/your-username/ecommerce-application.git`
2. Open the project in your preferred development environment.
3. Configure the connection string in the `appsettings.json` file to point to your desired database.
4. Run the database migrations to create the necessary tables: `dotnet ef database update`
5. Build and run the application using the development server: `dotnet run`
6. Access the application in your web browser at `http://localhost:5000`.

## Contributing

Contributions to this project are welcome. If you encounter any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).


