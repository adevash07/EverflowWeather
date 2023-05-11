# EverflowWeatherApp - Local Setup Instructions

This document provides step-by-step instructions to set up a local version of EverflowWeatherApp, a Blazor WebAssembly app that displays the current weather and forecast for different locations using the OpenWeather API. This document covers the setup process for both Visual Studio and Visual Studio Code.

## Prerequisites

Before setting up the EverflowWeatherApp, you must have the following software installed:

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/) with the [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) or another IDE that supports Blazor development
- [Git](https://git-scm.com/downloads) or another Git client

## Visual Studio Setup

Follow these steps to set up the app in Visual Studio:

1. Clone the repository using the command `git clone https://github.com/adevash07/EverflowWeather.git` in your terminal or using a Git client of your choice.
2. Open Visual Studio and select "Open a project or solution."
3. Navigate to the cloned repository and select `EverflowWeather.sln` to open the solution file.
4. Restore the NuGet packages for the solution by right-clicking on the `EverflowWeather` solution in the Solution Explorer and selecting "Restore NuGet Packages."
5. Set the `EverflowWeather.Server` project as the startup project by right-clicking on the project in the Solution Explorer and selecting "Set as Startup Project."
6. Start the server project by pressing `F5` or selecting "Debug" > "Start Debugging" from the menu. This will start the server project and watch for any changes in the code.
7. Launch the Blazor app in your browser by pressing `Ctrl` + `F5` or selecting "Debug" > "Start Without Debugging" from the menu.
8. You can now explore and modify the code of the Blazor app locally. To see the changes, you need to refresh the browser.

## Visual Studio Code Setup

Follow these steps to set up the app in Visual Studio Code:

1. Clone the repository using the command `git clone https://github.com/adevash07/EverflowWeather.git` in your terminal or using a Git client of your choice.
2. Open Visual Studio Code and select "File" > "Open Folder."
3. Navigate to the cloned repository and select the folder to open it in Visual Studio Code.
4. Restore the NuGet packages for the solution by running the command `dotnet restore` in the terminal or using the IDE's built-in tool.
5. Set the `EverflowWeather.Server` project as the startup project by opening the `launch.json` file in the `.vscode` folder and adding the following configuration:

```json
"configurations": [
    {
        "name": "EverflowWeather.Server",
        "type": "coreclr",
        "request": "launch",
        "preLaunchTask": "build",
        "program": "${workspaceFolder}/EverflowWeather.Server/bin/Debug/net6.0/EverflowWeather.Server.dll",
        "args": [],
        "cwd": "${workspaceFolder}/EverflowWeather.Server",
        "stopAtEntry": false,
        "console": "internalConsole"
    }
]
```

6. Start the server project by pressing `F5` or selecting "Debug" > "Start Debugging" from the menu. This will start the server project and watch for any changes in the code.
7. Launch the Blazor app in your browser by opening the `launch.json` file again and adding the following configuration:

```json
"configurations": [
    {
        "name": "EverflowWeather.Client",
        "type": "blazorwasm",
        "request": "launch",
        "cwd": "${workspaceFolder}/EverflowWeather.Client",
        "stopAtEntry": false,
        "webRoot": "${workspaceFolder}/EverflowWeather.Client/wwwroot"
    }
]
```

8. Press `F5` or select "Debug" > "Start Debugging" from the menu to launch the Blazor app in your browser.
9. You can now explore and modify the code of the Blazor app locally. To see the changes, you need to refresh the browser.

## Conclusion

By following these steps, you should now have a working local version of EverflowWeatherApp that you can explore and modify to suit your needs. If you encounter any issues during the setup process, please refer to the documentation or seek help from the project contributors.
