# Entity Framework Scaffold
## Add Migration
```
Add-Migration -OutputDir EFContext\Migrations -Name {MigrationName}
Update-Database -Context MVSRAContext
```

## Replace Migration
```
Update-Database -Context MVSRAContext 0
Remove-Migration
Add-Migration -OutputDir EFContext\Migrations -Name {MigrationName}
Update-Database -Context MVSRAContext
```