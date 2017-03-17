namespace ProyectoModeloDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProducto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 250, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Disponible = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .Index(t => t.ClienteId);
            
            AlterColumn("dbo.Cliente", "Nombre", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Cliente", "Apellido", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Cliente", "Email", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.Producto", new[] { "ClienteId" });
            AlterColumn("dbo.Cliente", "Email", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Apellido", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Nombre", c => c.String(maxLength: 100, unicode: false));
            DropTable("dbo.Producto");
        }
    }
}
