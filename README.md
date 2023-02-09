# Running ASP.NET Core in Azure Functions

Using https://github.com/tntwist/NL.Serverless.AspNetCore

In order for this to work correctly, you need to publish WebApp, and then copy the published wwwroot/ folder from WebApp to the Function output due to StaticWebAssets not being included and wwwroot/ content being dropped during Function build.

This is now done directly in .csproj of the Azure Function. It is kinda obscure, I suppose we could reuse the StaticWebAssets targets, but this does the job.