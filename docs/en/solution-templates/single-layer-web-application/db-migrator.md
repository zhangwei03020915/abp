# Single Layer Solution: Db Migrator

````json
//[doc-nav]
{
  "Previous": {
    "Name": "Web Applications",
    "Path": "solution-templates/single-layer-web-application/web-applications"
  },
  "Next": {
    "Name": "Built-In Features",
    "Path": "solution-templates/single-layer-web-application/built-in-features"
  }
}
````

Unlike the Layered solution template, the Single Layer solution template does not include a separate database migrator project. Instead, the main application project handles database migration and seed data operations. The `*.DbMigrator` project is excluded from this template. To manage database migrations and seed data, you can use the `migrate-database.ps1` script in the root directory or run the `dotnet run --migrate-database` command from the main application project directory.

![Single Layer Solution: Db Migrator](images/single-layer-db-migrator.png)

After the migration completes, a message will appear in the console. You can verify the success of the migration by checking the database.  