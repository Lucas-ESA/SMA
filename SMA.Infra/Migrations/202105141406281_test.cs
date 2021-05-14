namespace SMA.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Senha = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        DtNascimento = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 100, unicode: false),
                        Cargo_ID = c.Guid(),
                        Nome_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cargo", t => t.Cargo_ID)
                .ForeignKey("dbo.Nome", t => t.Nome_ID)
                .Index(t => t.Cargo_ID)
                .Index(t => t.Nome_ID);
            
            CreateTable(
                "dbo.Nome",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        PrimeiroNome = c.String(maxLength: 100, unicode: false),
                        UltimoNome = c.String(maxLength: 100, unicode: false),
                        Apelido = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Nome_ID", "dbo.Nome");
            DropForeignKey("dbo.Usuario", "Cargo_ID", "dbo.Cargo");
            DropIndex("dbo.Usuario", new[] { "Nome_ID" });
            DropIndex("dbo.Usuario", new[] { "Cargo_ID" });
            DropTable("dbo.Nome");
            DropTable("dbo.Usuario");
            DropTable("dbo.Cargo");
        }
    }
}
