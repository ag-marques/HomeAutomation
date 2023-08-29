# HomeAutomation
Sistema desenvolvido em CSharp Razor Pages utilizando método scaffold

# Reference
https://learn.microsoft.com/pt-br/aspnet/core/data/ef-rp/intro?view=aspnetcore-6.0&tabs=visual-studio-code

# Migrations

dotnet ef migrations add yourMigrationName

dotnet ef database update

# Aplicar scaffold 

dotnet aspnet-codegenerator razorpage -m Client -dc HomeAutomation.Data.BudgetContext.cs -udl -outDir Pages\Client --referenceScriptLibraries -sqlite