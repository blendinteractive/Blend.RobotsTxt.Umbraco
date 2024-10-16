Blend RobotsTxt
=====

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![NuGet version (Our.Umbraco.Blend.RobotsTxt)](https://img.shields.io/nuget/v/Our.Umbraco.Blend.RobotsTxt.svg?style=flat-square)](https://www.nuget.org/packages/Our.Umbraco.Blend.RobotsTxt/)

This is a lightweight package that enables /robots.txt root of the umbraco website. This package is configured using appSettings.

## Installation in Umbraco CMS
---
Command Line
```
donet add package Our.Umbraco.Blend.RobotsTxt
```

Or Nuget
```
Install-Package Our.Umbraco.Blend.RobotsTxt
```

## Setup
---
In the `Startup.cs` there is a configuration you need to add for `/robots.txt` path to render.

In the `app.UseUmbraco()` Under `.WithEndpoints(u =>` add:
```
u.EndpointRouteBuilder.MapControllers();
```
This will use the route `/robots.txt` declared in the controller.

## Default
---
If there are not any configurations in the appSettings.json file and no environment is found the default robots.txt will be:
```
User-agent: *
Allow: /
Disallow: /umbraco
```

If an environment is found and the name is `Production` the above will be rendered. For all other environments will be:
```
User-agent: *
Disallow: /
```

The `/umbraco` is global path that is set in appSettings. If this is set to a different path this path will update.

## Configuration
---
In the root of your `appSettings.json` you can configure custom settings. You can also use `appSettings.[Environment].json` to have specific settings for every environment.
```
"Robots": [
    {
        "UserAgent": "*",
        "Allow": [ "/" ],
        "Disallow": [ "/umbraco" ],
        "Sitemap": "/sitemap.xml"
    }
]
```

`Robots` is an array of objects to be configured as needed to your use case.

`UserAgent` is an optional string. If left blank will use `*`.

`Allow` is an optional string array. Array of paths to allow.

`Disallow` is an optional string array. Array of paths not to allow.

`Sitemap` is an optional string. If left blank will not include.

If `Allow` and `Disallow` are both empty, will set to `Allow: /`
