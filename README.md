# jsreport sdk for .net

> **Warning!** This is pre alfa version of future c# sdks for jsreport. So far you may only try fiddling with it using the steps below so far. 

## The first fiddling
1. install [preview version of VS 2017](https://www.visualstudio.com/vs/preview/) - don't worry you can easily run your current VS with the preview side by side
2. clone this repository
3. run `clone-all.bat`
4. open `jsreport.development.sln`
5. run the startup project `WebApp` or `ConsoleApp` to see the basics


**Pdf rendering, Excel rendering and other reporting features right in the .net core**
jsreport sdk for .net includes c# based rest client to the [jsreport](https://jsreport.net) reporting server as well as assemblies running local jsreport right from the .net project. Please find the guides, documentation and get started examples on the 

## sdk packages
The jsreport sdk for .net consists of several repositories / nuget packages were each has its specific purpose.

|   |   |   |  |
|---|---|---|  |
|[jsreport.client](https://github.com/jsreport/jsreport-dotnet-client) | build | nuget |
|[jsreport.local](https://github.com/jsreport/jsreport-dotnet-local) | build | nuget |
|[jsreport.mvc](https://github.com/jsreport/jsreport-dotnet-mvc) | build | nuget |
|[jsreport.types](https://github.com/jsreport/jsreport-dotnet-types) | build | nuget |
|[jsreport.shared](https://github.com/jsreport/jsreport-dotnet-shared) | build | nuget |
|[jsreport.binary](https://github.com/jsreport/jsreport-dotnet-binary) | build | nuget |
|[jsreport.vstools](https://github.com/jsreport/jsreport-dotnet-vstools) | build | nuget |

## Development
The individual parts of sdk are separated in its own packages and repositories. If you plan to change just single repository at a time, you should clone it and use the VS solution in particular repository. In case you plan to modify multiple packages at once, the easiest is to clone this repository. Run `clone-all.bat` to get all the repositories. And finally use `jsreport-development.sln` to startup whole sdk at once.


## Roadmap

1. Add documentation
2. Release preview nugets
3. Add linux support
4. Stabilize interfaces and API
5. Final release should come in Q3 together with the .net core 2.0

## Contributions
Yes please. We are looking forward every contribution! Just make sure you add test and the CI passes. Then we will gladly accept your PRs.

## License
MIT