namespace controle.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialisationBDD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Intervenants",
                c => new
                    {
                        idIntervenant = c.Int(nullable: false, identity: true),
                        Matricule = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.idIntervenant);
            
            CreateTable(
                "dbo.Interventions",
                c => new
                    {
                        idIntervention = c.Int(nullable: false, identity: true),
                        AdresseClient = c.String(nullable: false, maxLength: 100),
                        DebutIntervention = c.DateTime(nullable: false),
                        FinIntervention = c.DateTime(nullable: false),
                        Intervenant_idIntervenant = c.Int(),
                    })
                .PrimaryKey(t => t.idIntervention)
                .ForeignKey("dbo.Intervenants", t => t.Intervenant_idIntervenant)
                .Index(t => t.Intervenant_idIntervenant);
            
            CreateTable(
                "dbo.Materiels",
                c => new
                    {
                        IdMateriel = c.Int(nullable: false, identity: true),
                        RefUnique = c.Int(nullable: false),
                        Designation = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        DateAchat = c.DateTime(nullable: false),
                        Intervenant_idIntervenant = c.Int(),
                    })
                .PrimaryKey(t => t.IdMateriel)
                .ForeignKey("dbo.Intervenants", t => t.Intervenant_idIntervenant)
                .Index(t => t.Intervenant_idIntervenant);
            
            CreateTable(
                "dbo.Vehicules",
                c => new
                    {
                        idVehicule = c.Int(nullable: false, identity: true),
                        Immatriculation = c.String(nullable: false, maxLength: 20),
                        Marque = c.String(nullable: false, maxLength: 50),
                        Modele = c.String(nullable: false, maxLength: 50),
                        VolumeUtile = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Intervenant_idIntervenant = c.Int(),
                    })
                .PrimaryKey(t => t.idVehicule)
                .ForeignKey("dbo.Intervenants", t => t.Intervenant_idIntervenant)
                .Index(t => t.Intervenant_idIntervenant);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicules", "Intervenant_idIntervenant", "dbo.Intervenants");
            DropForeignKey("dbo.Materiels", "Intervenant_idIntervenant", "dbo.Intervenants");
            DropForeignKey("dbo.Interventions", "Intervenant_idIntervenant", "dbo.Intervenants");
            DropIndex("dbo.Vehicules", new[] { "Intervenant_idIntervenant" });
            DropIndex("dbo.Materiels", new[] { "Intervenant_idIntervenant" });
            DropIndex("dbo.Interventions", new[] { "Intervenant_idIntervenant" });
            DropTable("dbo.Vehicules");
            DropTable("dbo.Materiels");
            DropTable("dbo.Interventions");
            DropTable("dbo.Intervenants");
        }
    }
}
