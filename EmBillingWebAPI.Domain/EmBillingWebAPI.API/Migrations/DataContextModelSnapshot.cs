// <auto-generated />
using System;
using EmBillingWebAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmBillingWebAPI.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.ClaimType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClaimTypes");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Navigation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentNavigationId")
                        .HasColumnType("int");

                    b.Property<int>("PolicyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentNavigationId");

                    b.HasIndex("PolicyId");

                    b.ToTable("Navigation");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Policies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.PolicyRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PolicyId")
                        .HasColumnType("int");

                    b.Property<int>("RuleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PolicyId");

                    b.HasIndex("RuleId");

                    b.ToTable("PolicyRules");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Reference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("ReferenceTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReferenceTypeId");

                    b.ToTable("References");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.ReferenceCorrelations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChildReferenceId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentReferenceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChildReferenceId");

                    b.HasIndex("ParentReferenceId");

                    b.ToTable("ReferenceCorrelations");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.ReferenceTypeCorrelations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChildReferenceId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentReferenceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChildReferenceId");

                    b.HasIndex("ParentReferenceId");

                    b.ToTable("ReferenceTypeCorrelations");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.ReferenceTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReferenceTypes");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessAttributeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("AccesstypeLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClaimTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccessAttributeTypeId");

                    b.HasIndex("ClaimTypeId");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.UserRoleAccess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("AccessTypelevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessAttributeId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoleAccess");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Navigation", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.Navigation", "ParentNavigation")
                        .WithMany()
                        .HasForeignKey("ParentNavigationId");

                    b.HasOne("EmBillingWebAPI.Domain.Models.Policies", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentNavigation");

                    b.Navigation("Policy");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.PolicyRule", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.Policies", "Policy")
                        .WithMany()
                        .HasForeignKey("PolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmBillingWebAPI.Domain.Models.Rule", "Rule")
                        .WithMany()
                        .HasForeignKey("RuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policy");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Reference", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.ReferenceTypes", "ReferenceType")
                        .WithMany()
                        .HasForeignKey("ReferenceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReferenceType");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.ReferenceCorrelations", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.Reference", "ChildReference")
                        .WithMany()
                        .HasForeignKey("ChildReferenceId");

                    b.HasOne("EmBillingWebAPI.Domain.Models.Reference", "ParentReference")
                        .WithMany()
                        .HasForeignKey("ParentReferenceId");

                    b.Navigation("ChildReference");

                    b.Navigation("ParentReference");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.ReferenceTypeCorrelations", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.ReferenceTypes", "ChildReference")
                        .WithMany()
                        .HasForeignKey("ChildReferenceId");

                    b.HasOne("EmBillingWebAPI.Domain.Models.ReferenceTypes", "ReferenceTypes")
                        .WithMany()
                        .HasForeignKey("ParentReferenceId");

                    b.Navigation("ChildReference");

                    b.Navigation("ReferenceTypes");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.Rule", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.ReferenceTypes", "AccessAttributeType")
                        .WithMany()
                        .HasForeignKey("AccessAttributeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmBillingWebAPI.Domain.Models.ClaimType", "ClaimType")
                        .WithMany()
                        .HasForeignKey("ClaimTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessAttributeType");

                    b.Navigation("ClaimType");
                });

            modelBuilder.Entity("EmBillingWebAPI.Domain.Models.UserRoleAccess", b =>
                {
                    b.HasOne("EmBillingWebAPI.Domain.Models.Reference", "AccessAttribute")
                        .WithMany()
                        .HasForeignKey("AccessAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmBillingWebAPI.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmBillingWebAPI.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessAttribute");

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
