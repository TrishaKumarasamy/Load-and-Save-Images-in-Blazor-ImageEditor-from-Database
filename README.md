# Blazor Image Editor Database Integration

A modern web application demonstrating how to integrate image upload, editing, and persistence with a SQL Server database using Blazor components.

## Overview

This project showcases a complete implementation of image management in Blazor, featuring:

- **Upload & Save** - Store images as binary data in SQL Server
- **Load & Edit** - Retrieve images from the database and edit them with ImageEditor
- **Real-time Updates** - Save edited images back to the database instantly
- **RESTful API** - Clean API endpoints for image operations

## Features

### Core Functionality
- **Image Upload** - Seamless file upload with validation and storage in SQL Server database
- **Image Editor** - Built-in image editing capabilities using ImageEditor component with tools for cropping, filtering, and transformation
- **Database Persistence** - Reliable storage and retrieval of image data using Entity Framework Core
- **RESTful API Endpoints** - Well-structured controller endpoints for CRUD operations on images

### User Interface
- **Responsive Design** - Mobile-friendly Bootstrap-based layout that adapts to all screen sizes
- **Interactive Components** - Blazor components for seamless user interactions without page reloads
- **Real-time Feedback** - Live updates as images are uploaded, edited, and saved
- **Navigation Menu** - Easy-to-use sidebar navigation for accessing different application sections

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/Load-and-Save-Images-in-Blazor-ImageEditor-from-Database.git
cd Load-and-Save-Images-in-Blazor-ImageEditor-from-Database
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```
## References

- [Blazor DataGrid Documentation](https://blazor.syncfusion.com/documentation/datagrid/getting-started-with-web-app)
- [Online ImageEditor Demo](https://blazor.syncfusion.com/demos/image-editor/default-functionalities?theme=fluent2)
- [Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor)


