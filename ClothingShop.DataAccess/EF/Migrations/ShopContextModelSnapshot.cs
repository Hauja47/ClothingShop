﻿// <auto-generated />
using System;
using ClothingShop.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ClothingShop.DataAccess.EF.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ClothingShop.Model.Attribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_attributes");

                    b.ToTable("attributes", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.AttributeValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("AttributeId")
                        .HasColumnType("uuid")
                        .HasColumnName("attribute_id");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.Property<Guid>("VariantId")
                        .HasColumnType("uuid")
                        .HasColumnName("variant_id");

                    b.HasKey("Id")
                        .HasName("pk_attribute_values");

                    b.HasIndex("AttributeId")
                        .HasDatabaseName("ix_attribute_values_attribute_id");

                    b.HasIndex("VariantId")
                        .HasDatabaseName("ix_attribute_values_variant_id");

                    b.ToTable("attribute_values", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_brands");

                    b.ToTable("brands", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid")
                        .HasColumnName("person_id");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_carts");

                    b.HasIndex("PersonId")
                        .HasDatabaseName("ix_carts_person_id");

                    b.ToTable("carts", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid?>("CartId")
                        .HasColumnType("uuid")
                        .HasColumnName("cart_id");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.Property<Guid>("VariantId")
                        .HasColumnType("uuid")
                        .HasColumnName("variant_id");

                    b.HasKey("Id")
                        .HasName("pk_cart_items");

                    b.HasIndex("CartId")
                        .HasDatabaseName("ix_cart_items_cart_id");

                    b.HasIndex("VariantId")
                        .HasDatabaseName("ix_cart_items_variant_id");

                    b.ToTable("cart_items", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<int>("Dislike")
                        .HasColumnType("integer")
                        .HasColumnName("dislike");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("images");

                    b.Property<int>("Like")
                        .HasColumnType("integer")
                        .HasColumnName("like");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_id");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid")
                        .HasColumnName("person_id");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric")
                        .HasColumnName("rating");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_comments");

                    b.HasIndex("ParentId")
                        .HasDatabaseName("ix_comments_parent_id");

                    b.HasIndex("PersonId")
                        .HasDatabaseName("ix_comments_person_id");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_comments_product_id");

                    b.ToTable("comments", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric")
                        .HasColumnName("balance");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric")
                        .HasColumnName("discount");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer")
                        .HasColumnName("order_status");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uuid")
                        .HasColumnName("person_id");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer")
                        .HasColumnName("phone_number");

                    b.Property<Guid?>("PromotionId")
                        .HasColumnType("uuid")
                        .HasColumnName("promotion_id");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric")
                        .HasColumnName("total");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_orders");

                    b.HasIndex("PersonId")
                        .HasDatabaseName("ix_orders_person_id");

                    b.HasIndex("PromotionId")
                        .HasDatabaseName("ix_orders_promotion_id");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.OrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric")
                        .HasColumnName("balance");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric")
                        .HasColumnName("discount");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid")
                        .HasColumnName("order_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric")
                        .HasColumnName("total");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_order_items");

                    b.HasIndex("OrderId")
                        .HasDatabaseName("ix_order_items_order_id");

                    b.ToTable("order_items", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("IdentityId")
                        .HasColumnType("uuid")
                        .HasColumnName("identity_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_persons");

                    b.ToTable("persons", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uuid")
                        .HasColumnName("brand_id");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uuid")
                        .HasColumnName("person_id");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric")
                        .HasColumnName("rating");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.HasIndex("BrandId")
                        .HasDatabaseName("ix_products_brand_id");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_products_category_id");

                    b.HasIndex("PersonId")
                        .HasDatabaseName("ix_products_person_id");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Promotion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("condition");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<decimal?>("DiscountPercent")
                        .HasColumnType("numeric")
                        .HasColumnName("discount_percent");

                    b.Property<decimal?>("DiscountValue")
                        .HasColumnType("numeric")
                        .HasColumnName("discount_value");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expired_date");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean")
                        .HasColumnName("is_published");

                    b.Property<long>("Quantity")
                        .HasColumnType("bigint")
                        .HasColumnName("quantity");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_promotions");

                    b.ToTable("promotions", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.Variant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric")
                        .HasColumnName("discount");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("images");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("integer")
                        .HasColumnName("record_status");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("slug");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_date");

                    b.HasKey("Id")
                        .HasName("pk_variants");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_variants_product_id");

                    b.ToTable("variants", (string)null);
                });

            modelBuilder.Entity("PersonPromotion", b =>
                {
                    b.Property<Guid>("UsedPersonsId")
                        .HasColumnType("uuid")
                        .HasColumnName("used_persons_id");

                    b.Property<Guid>("UsedPromotionsId")
                        .HasColumnType("uuid")
                        .HasColumnName("used_promotions_id");

                    b.HasKey("UsedPersonsId", "UsedPromotionsId")
                        .HasName("pk_person_promotion");

                    b.HasIndex("UsedPromotionsId")
                        .HasDatabaseName("ix_person_promotion_used_promotions_id");

                    b.ToTable("person_promotion", (string)null);
                });

            modelBuilder.Entity("ClothingShop.Model.AttributeValue", b =>
                {
                    b.HasOne("ClothingShop.Model.Attribute", "Attribute")
                        .WithMany("Values")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_attribute_values_attributes_attribute_id");

                    b.HasOne("ClothingShop.Model.Variant", "Variant")
                        .WithMany("Attributes")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_attribute_values_variants_variant_id");

                    b.Navigation("Attribute");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("ClothingShop.Model.Cart", b =>
                {
                    b.HasOne("ClothingShop.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_carts_persons_person_id");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ClothingShop.Model.CartItem", b =>
                {
                    b.HasOne("ClothingShop.Model.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .HasConstraintName("fk_cart_items_carts_cart_id");

                    b.HasOne("ClothingShop.Model.Variant", "Variant")
                        .WithMany()
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_items_variants_variant_id");

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("ClothingShop.Model.Comment", b =>
                {
                    b.HasOne("ClothingShop.Model.Comment", "ParentComment")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_comments_comments_parent_id");

                    b.HasOne("ClothingShop.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_comments_persons_person_id");

                    b.HasOne("ClothingShop.Model.Product", null)
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_comments_products_product_id");

                    b.Navigation("ParentComment");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ClothingShop.Model.Order", b =>
                {
                    b.HasOne("ClothingShop.Model.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_orders_persons_person_id");

                    b.HasOne("ClothingShop.Model.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionId")
                        .HasConstraintName("fk_orders_promotions_promotion_id");

                    b.Navigation("Person");

                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("ClothingShop.Model.OrderItem", b =>
                {
                    b.HasOne("ClothingShop.Model.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_items_orders_order_id");
                });

            modelBuilder.Entity("ClothingShop.Model.Product", b =>
                {
                    b.HasOne("ClothingShop.Model.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_products_brands_brand_id");

                    b.HasOne("ClothingShop.Model.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_products_categories_category_id");

                    b.HasOne("ClothingShop.Model.Person", null)
                        .WithMany("FavoriteProducts")
                        .HasForeignKey("PersonId")
                        .HasConstraintName("fk_products_persons_person_id");

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClothingShop.Model.Variant", b =>
                {
                    b.HasOne("ClothingShop.Model.Product", null)
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_variants_products_product_id");
                });

            modelBuilder.Entity("PersonPromotion", b =>
                {
                    b.HasOne("ClothingShop.Model.Person", null)
                        .WithMany()
                        .HasForeignKey("UsedPersonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_person_promotion_persons_used_persons_id");

                    b.HasOne("ClothingShop.Model.Promotion", null)
                        .WithMany()
                        .HasForeignKey("UsedPromotionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_person_promotion_promotions_used_promotions_id");
                });

            modelBuilder.Entity("ClothingShop.Model.Attribute", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("ClothingShop.Model.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClothingShop.Model.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ClothingShop.Model.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ClothingShop.Model.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ClothingShop.Model.Person", b =>
                {
                    b.Navigation("FavoriteProducts");
                });

            modelBuilder.Entity("ClothingShop.Model.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("ClothingShop.Model.Variant", b =>
                {
                    b.Navigation("Attributes");
                });
#pragma warning restore 612, 618
        }
    }
}
