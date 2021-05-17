namespace SMA.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropTable_Nome : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuario", "Nome_ID", "dbo.Nome");
            DropIndex("dbo.Usuario", new[] { "Nome_ID" });
            AddColumn("dbo.Usuario", "PrimeiroNome", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.Usuario", "UltimoNome", c => c.String(maxLength: 100, unicode: false));
            AddColumn("dbo.Usuario", "Apelido", c => c.String(maxLength: 100, unicode: false));
            DropColumn("dbo.Usuario", "Nome_ID");
            DropTable("dbo.Nome");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.Usuario", "Nome_ID", c => c.Guid());
            DropColumn("dbo.Usuario", "Apelido");
            DropColumn("dbo.Usuario", "UltimoNome");
            DropColumn("dbo.Usuario", "PrimeiroNome");
            CreateIndex("dbo.Usuario", "Nome_ID");
            AddForeignKey("dbo.Usuario", "Nome_ID", "dbo.Nome", "ID");
        }
    }
}
