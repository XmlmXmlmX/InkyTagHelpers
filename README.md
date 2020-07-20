[![.NET Core](https://github.com/XmlmXmlmX/InkyTagHelpers/workflows/.NET%20Core/badge.svg)](https://github.com/XmlmXmlmX/InkyTagHelpers/actions)
[![Version](https://img.shields.io/nuget/v/InkyTagHelpers.svg "Version")](https://www.nuget.org/packages/InkyTagHelpers/) [![Downloads](https://img.shields.io/nuget/dt/InkyTagHelpers.svg "Downloads")](https://www.nuget.org/packages/InkyTagHelpers/)


# Inky Tag Helpers

## Tag Helpers to render Inky-HTML (Foundation for Emails) in ASP.NET Core.

With this Tag Helper it is possible to render (derived from the latest [zurb/inky](https://github.com/zurb/inky) implementation) the inky syntax in ASP.NET Core.

## Installation

Install the nuget Package `InkyTagHelpers` from nuget.org.

```bash
nuget Install-Package InkyTagHelpers
```

or just `Manage NuGet Packages...` from your projects context menu.

## Usage

To understand wich tag should be used for what, follow the official Foundation for Emails documentation in components: https://foundation.zurb.com/emails/docs/.

In ASP.NET Core, just start with the [Example](#examples) project or from [scratch](https://github.com/XmlmXmlmX/InkyTagHelpers/wiki)

### The supported tags are
`<button>`, `<callout>`, `<columns>`, `<container>`, `<menu>`, `<item>` (only nested inside menu), `<row>`, `<spacer>`, `<wrapper>`.

## Examples

Have a look at the [InkyTagHelpers.Web](https://github.com/XmlmXmlmX/InkyTagHelpers/blob/master/InkyTagHelpers.Web/) project. There you can find some basic usage examples.
