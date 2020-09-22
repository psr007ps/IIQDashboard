# IIQDashboard

The application is built as a dashboard to manage Sailpoint Identity IQ and needs connection string of IIQ database, IIQ server names and Active Directory server names(for login).

Connection strings, server names and other such dependencies are intentionlly removed because it was used to connect to a specific version of IIQ which was proprietary. These dependencies can be added as per the application the dashboard is connecting to. Files that require the changes are: app.config, mainwindow.xaml.cs, login.xaml.cs. A selenium script is also present in mainwindow.xaml.cs which can be uncommented and optimized as per requirement.
