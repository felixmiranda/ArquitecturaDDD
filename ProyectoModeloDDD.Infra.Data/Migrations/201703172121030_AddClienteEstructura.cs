namespace ProyectoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClienteEstructura : DbMigration
    {
        public override void Up()
        {
           // RenameTable(name: "dbo.Clientes", newName: "Cliente");
            AlterColumn("dbo.Cliente", "Nombre", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Apellido", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Email", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Email", c => c.String());
            AlterColumn("dbo.Cliente", "Apellido", c => c.String());
            AlterColumn("dbo.Cliente", "Nombre", c => c.String());
           // RenameTable(name: "dbo.Cliente", newName: "Clientes");
        }
    }
}
