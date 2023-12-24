# ImageMatch Desktop

## Overview

ImageMatch Desktop is a desktop application designed for jewelry inventory management and image matching. The application utilizes image processing techniques and feature extraction to match jewelry items based on uploaded images. Additionally, it provides functionality for inventory management, allowing users to organize and track jewelry items.

## Features

- **Image Upload:** Easily upload images of jewelry items for processing and matching.
- **Image Matching:** Utilize advanced image processing algorithms to find matches within the uploaded images.
- **Inventory Management:** Manage and organize jewelry items, including details such as name, type, description, and location.
**location Management:** Manage locations in ImageMatch Desktop.

## Table of Contents

- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
  - [Main Interface](#main-interface)
  - [Image Matching](#image-matching)
  - [Inventory Management](#inventory-management)
  - [Location Management](#location-management)
- [Configuration](#configuration)
- [Contributing](#contributing)
- [License](#license)

## Getting Started

### Prerequisites

- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework)
- [MySQL Server Version 8.0.35](https://dev.mysql.com/downloads/mysql/)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/ImageMatch-Desktop.git
   ```

2. Open the solution in Visual Studio.

3. Build and run the application.

## Usage

### Main Interface

The main interface presents three primary buttons for image upload, image match, and inventory management. Each button leads to a specific module within the application.

![dashboard](https://github.com/tay121222/ImageMatch_Desktop/assets/6275272/1e00eeb6-7ca6-45b8-a4ed-455f16ab27ac)


### Image Matching

1. **Upload Images:** Navigate to the "Image Upload" section to add images of jewelry items.

2. **Image Match:** Use the "Image Match" button to initiate the image matching process. The application will find and display matching jewelry items based on the uploaded images.

3. **View Matches:** Explore the matched items, including images, labels (IDs), and matching percentages.

![Image_Matching_Interface](https://github.com/tay121222/ImageMatch_Desktop/assets/6275272/f4102a74-22ea-4151-ab86-c74b8737cd3a)


### Inventory Management

1. **Add Items:** In the "Inventory" section, add new jewelry items by providing details such as name, type, description, and location.

2. **Manage Inventory:** View and manage the existing inventory, edit item details, or remove items as needed.

![inventory_management_interface](https://github.com/tay121222/ImageMatch_Desktop/assets/6275272/48a61d83-f5ba-45c4-a432-e172c40972a6)

### Location Management

For managing locations in ImageMatch Desktop:

- Open the main interface and navigate to the "Location Management" section.
- Here, you can add, edit, or delete locations where jewelry items are stored.
- Use the "Add Location" button to insert new locations.
- To remove a location, select it and right-click to Delete Location.

![location_management_interface](https://github.com/tay121222/ImageMatch_Desktop/assets/6275272/de0bd0d6-52b8-43fb-93ff-f4d08d407f7d)


### Database Setup

To set up the required database and tables for ImageMatch Desktop, follow these steps:

1. **Create Database:**

   Execute the `create_database.sql` script to create the necessary database. Use your preferred MySQL client or run the script in the MySQL command line.

   ```bash
   mysql -u your_username -p < create_database.sql
   ```

   Enter your MySQL password when prompted.


3. **Load Location Data:**

   Execute the `location_data.sql` script to populate the `Locations` table with sample data.

   ```bash
   mysql -u your_username -p ImageMatch_Desktop < location_data.sql
   ```

   Enter your MySQL password when prompted.

   This script inserts location data into the `Locations` table, providing sample locations for your jewelry items.
   
![ImageMatch Desktop Data Model](https://github.com/tay121222/ImageMatch_Desktop/assets/6275272/e0eb5ab2-cac0-4fcd-b714-3cd42e22bf29)



## Configuration

Adjust configuration settings such as database connection strings in the `app.config` file.

```xml
<!-- Example Database Connection String -->
<connectionStrings>
  <add name="MyConnectionString" connectionString="Server=localhost;Database=ImageMatch_Desktop;User Id=user;Password=pass;" providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```



## License

This project is licensed under the [MIT License](LICENSE).

