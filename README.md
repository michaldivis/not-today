<img src="assets/icon.png?raw=true" width=200>

# NotToday

NotToday is a powerful ASP.NET Core library that brings unparalleled performance gains to your API. With its advanced optimizations and efficient implementation, it enables you to deliver lightning-fast responses to your users, ensuring a smooth and responsive experience.

The magic behing the library is that it will **short-circuit your requests in the middleware pipeline** and return a heart-warming response similar to
> Oh goodie! It seems like there's no response coming. It's just one of those days I guess.

## Installation
NotToday can be easily installed via NuGet package manager. Simply run the following command in the Package Manager Console:
```powershell
Install-Package Divis.NotToday.AspNetCore
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

Enjoy the performance gains! NotToday will automatically optimize request processing, resulting in significantly improved response times and overall API performance. For the price of not returning the desired responses of course.

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