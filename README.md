# Expense Tracker

## Overview

The Expense Tracker is a WPF application developed in C# that allows users to manage and track their daily expenses. Users can add expenses, view summaries by month and year, and visualize their spending through graphical representations. This project is ideal for beginners to learn about UI design, data storage, and data visualization.

## Features

- Add expense information (date, amount, description)
- View monthly and yearly expense summaries categorized by type
- Edit and delete existing expenses
- Store data in a local SQLite database
- Search and filter options for expenses
- Graphical representation of expenses using charts

## Prerequisites

- Visual Studio 2022
- .NET Framework 4.7.2 or higher
- NuGet packages:
  - `System.Data.SQLite` for database operations
  - `LiveCharts.Wpf` for charting

## Getting Started

### Step 1: Clone the Repository

Clone the repository to your local machine:

`bash
git clone https://github.com/yourusername/ExpenseTracker.git
cd ExpenseTracker`

### Step 2: Open the Project
Open the project in Visual Studio 2022.</br>
Ensure that the project is set up as a WPF Application.</br>

### Step 3: Install Necessary NuGet Packages
Right-click on your project in Solution Explorer.</br>
Select Manage NuGet Packages.</br>
In the Browse tab, search for and install the following packages:</br>
System.Data.SQLite</br>
LiveCharts.Wpf</br>

### Step 4: Build the Database
The application will create an SQLite database file (expenses.db) on the first run.</br>
Ensure that the application has permission to write to the directory.</br>

### Step 5: Run the Application
Build the project by selecting Build > Build Solution.</br>
Run the application by selecting Debug > Start Without Debugging.</br>

## Usage
Add an Expense: Fill in the description, amount, and date, then click the Add Expense button.</br>
View Summary: Click the View Summary button to see a summary of your expenses and graphical representation.</br>
Edit or Delete Expenses: Implement functionality to modify or remove existing entries as needed.</br>

## Code Structure
MainWindow.xaml: The main user interface layout.</br>
MainWindow.xaml.cs: Logic for handling expenses and database interactions.</br>
Assets: Directory for any additional resources (if applicable).</br>

## Future Enhancements
Implement detailed filtering options for expenses.</br>
Add user authentication for personal expense tracking.</br>
Improve UI/UX for better user experience.</br>
Include export functionality for reports.</br>
