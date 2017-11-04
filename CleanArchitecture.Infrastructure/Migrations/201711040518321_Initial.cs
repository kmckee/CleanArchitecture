namespace CleanArchitecture.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contraptions",
                c => new
                    {
                        ContraptionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OneToOneWithWidget_WidgetId = c.Int(),
                    })
                .PrimaryKey(t => t.ContraptionId)
                .ForeignKey("dbo.Widgets", t => t.OneToOneWithWidget_WidgetId)
                .Index(t => t.OneToOneWithWidget_WidgetId);
            
            CreateTable(
                "dbo.Widgets",
                c => new
                    {
                        WidgetId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OneToOneWithWidget_WidgetId = c.Int(),
                    })
                .PrimaryKey(t => t.WidgetId)
                .ForeignKey("dbo.Widgets", t => t.OneToOneWithWidget_WidgetId)
                .Index(t => t.OneToOneWithWidget_WidgetId);
            
            CreateTable(
                "dbo.Things",
                c => new
                    {
                        ThingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Widget_WidgetId = c.Int(),
                    })
                .PrimaryKey(t => t.ThingId)
                .ForeignKey("dbo.Widgets", t => t.Widget_WidgetId)
                .Index(t => t.Widget_WidgetId);
            
            CreateTable(
                "dbo.Gizmoes",
                c => new
                    {
                        GizmoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GizmoId);
            
            CreateTable(
                "dbo.GizmoThings",
                c => new
                    {
                        Gizmo_GizmoId = c.Int(nullable: false),
                        Thing_ThingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Gizmo_GizmoId, t.Thing_ThingId })
                .ForeignKey("dbo.Gizmoes", t => t.Gizmo_GizmoId, cascadeDelete: true)
                .ForeignKey("dbo.Things", t => t.Thing_ThingId, cascadeDelete: true)
                .Index(t => t.Gizmo_GizmoId)
                .Index(t => t.Thing_ThingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contraptions", "OneToOneWithWidget_WidgetId", "dbo.Widgets");
            DropForeignKey("dbo.Widgets", "OneToOneWithWidget_WidgetId", "dbo.Widgets");
            DropForeignKey("dbo.Things", "Widget_WidgetId", "dbo.Widgets");
            DropForeignKey("dbo.GizmoThings", "Thing_ThingId", "dbo.Things");
            DropForeignKey("dbo.GizmoThings", "Gizmo_GizmoId", "dbo.Gizmoes");
            DropIndex("dbo.GizmoThings", new[] { "Thing_ThingId" });
            DropIndex("dbo.GizmoThings", new[] { "Gizmo_GizmoId" });
            DropIndex("dbo.Things", new[] { "Widget_WidgetId" });
            DropIndex("dbo.Widgets", new[] { "OneToOneWithWidget_WidgetId" });
            DropIndex("dbo.Contraptions", new[] { "OneToOneWithWidget_WidgetId" });
            DropTable("dbo.GizmoThings");
            DropTable("dbo.Gizmoes");
            DropTable("dbo.Things");
            DropTable("dbo.Widgets");
            DropTable("dbo.Contraptions");
        }
    }
}
