// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace CodeGenHero.ResourceScheduler.Repository.Entities.RS
{

    // User
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class UserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
    {
        public UserConfiguration()
            : this("dbo")
        {
        }

        public UserConfiguration(string schema)
        {
            ToTable("User", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.CreatedDate).HasColumnName(@"CreatedDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.InstallationId).HasColumnName(@"InstallationId").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.LastLoginDate).HasColumnName(@"LastLoginDate").HasColumnType("datetime2").IsOptional();
            Property(x => x.IsActive).HasColumnName(@"IsActive").HasColumnType("bit").IsRequired();
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();
            Property(x => x.UpdatedBy).HasColumnName(@"UpdatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.UpdatedDate).HasColumnName(@"UpdatedDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
