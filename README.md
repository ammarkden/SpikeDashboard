# SpikeDashboard

An ASP.NET Core Razor Pages project showcasing reusable dashboard card components with basic data visualization.

## Features

- Modular **Dashboard Card** UI component using Razor Partial Views
- Clean data model separation (`DashboardCardModel`)
- Sample dashboard page showing multiple cards with titles, changes, and values

## Getting Started

### Prerequisites

- [.NET 7 SDK or later](https://dotnet.microsoft.com/download)
- A code editor like [Visual Studio Code](https://code.visualstudio.com/)

### Running the Project

1. Clone the repository or download source code

2. Navigate to project folder:

    ```bash
    cd SpikeDashboard
    ```

3. Run the application:

    ```bash
    dotnet run
    ```

4. Open your browser at: (it may differ from device to device. Check the terminal for the correct one)

    ```
    http://localhost:5200/
    ```

### Project Structure

SpikeDashboard/
├── Pages/
│ ├── Models/
│ │ └── DashboardCardModel.cs #  Data model for dashboard cards
│ ├── Shared/
│ │ └── DashboardCard.cshtml # Reusable dashboard card partial view
│ ├── Index.cshtml # Main dashboard page
│ └── Index.cshtml.cs # Page model with sample data
└── Program.cs # App startup


## How to Use

- Add or update cards data in `Index.cshtml.cs` inside the `Cards` list
- Modify `DashboardCard.cshtml` to change card layout or styling

## Notes

- I reduced the sizes by 10% to be fit and without scroll-bar