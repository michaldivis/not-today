<img src="assets/icon.png?raw=true" width=200>

# NotToday

NotToday is a powerful ASP.NET Core library that brings unparalleled performance gains to your API. With its advanced optimizations and efficient implementation, it enables you to deliver lightning-fast responses to your users, ensuring a smooth and responsive experience.

## Features
**Unmatched Performance**: NotToday is designed from the ground up to maximize performance in ASP.NET Core applications. It leverages cutting-edge techniques and optimizations to minimize latency and improve throughput, allowing your API to handle a high volume of requests without breaking a sweat.

**Efficient Request Processing**: NotToday optimizes the request processing pipeline, reducing unnecessary overhead and improving overall performance. It streamlines the handling of incoming requests, ensuring minimal latency and resource consumption, even under heavy loads.

**Highly Scalable**: Thanks to its efficient design and optimized algorithms, NotToday enables your API to scale effortlessly. It can handle a massive number of concurrent requests, making it ideal for applications that require high scalability and responsiveness.

**Transparent Integration**: NotToday seamlessly integrates with your existing ASP.NET Core application. It provides a simple and intuitive API, allowing you to quickly enhance the performance of your API without extensive code changes or complex configuration.

**Easy to Use**: NotToday is designed with developer productivity in mind. It comes with comprehensive documentation and examples, making it easy to get started and leverage its performance benefits in your project. You can quickly integrate it into your solution and start seeing immediate improvements in response times and overall performance.

## Installation
NotToday can be easily installed via NuGet package manager. Simply run the following command in the Package Manager Console:
```powershell
Install-Package NotToday
```

## Usage
Using NotToday in your ASP.NET Core application is straightforward. After installing the package, follow these steps to enable its performance optimizations:

Add the NotToday middleware to your ASP.NET Core pipeline during application startup.

```csharp
using NotToday;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddNotToday(); // <- add this

var app = builder.Build();

app.UseNotToday(); // <- add this

app.Run();
```

Enjoy the performance gains! NotToday will automatically optimize request processing, resulting in significantly improved response times and overall API performance.

## Testimonials

> NotToday has completely transformed the performance of our API. Response times have significantly improved, and our users are delighted with the lightning-fast experience. This library is a game-changer! Doug, United States.

> I've never seen such impressive performance gains in an ASP.NET Core library before. NotToday is a must-have for anyone looking to optimize their API. It's like giving your application a powerful performance boost! Olaf, Denmark.

> NotToday has exceeded my expectations. The seamless integration and the remarkable performance improvements have made a huge impact on our application. Our users are now enjoying a faster and more responsive API. Emily, UK.

## Contributing
We welcome contributions to NotToday! If you encounter any issues or have suggestions for improvements, please feel free to open an issue or submit a pull request on our GitHub repository.

## License
NotToday is released under the MIT License.

## Acknowledgments
We would like to express our gratitude to the open-source community for their valuable contributions and feedback, which have helped shape NotToday into the high-performance library it is today.