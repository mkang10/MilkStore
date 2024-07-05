using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MilkStoreWepAPI.DAO;

public partial class TutishopContext : DbContext
{
    public TutishopContext()
    {
    }

    public TutishopContext(DbContextOptions<TutishopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticleProduct> ArticleProducts { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<ChatHistory> ChatHistories { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Gift> Gifts { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Revenue> Revenues { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPoint> UserPoints { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-FEOOS2UC;Database=Tutishop;Uid=sa; Pwd=123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.ArticleId).HasName("PK__Articles__9C6270C89DF9E217");

            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.Content).HasColumnType("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Articles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Articles__UserID__534D60F1");
        });

        modelBuilder.Entity<ArticleProduct>(entity =>
        {
            entity.HasKey(e => e.ArticleProductId).HasName("PK__ArticleP__F514C99AD0763D6D");

            entity.Property(e => e.ArticleProductId).HasColumnName("ArticleProductID");
            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Article).WithMany(p => p.ArticleProducts)
                .HasForeignKey(d => d.ArticleId)
                .HasConstraintName("FK__ArticlePr__Artic__5629CD9C");

            entity.HasOne(d => d.Product).WithMany(p => p.ArticleProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ArticlePr__Produ__571DF1D5");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.ChatId).HasName("PK__Chats__A9FBE626859A89F9");

            entity.Property(e => e.ChatId).HasColumnName("ChatID");
            entity.Property(e => e.Message).HasColumnType("text");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Chats)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Chats__UserID__4CA06362");
        });

        modelBuilder.Entity<ChatHistory>(entity =>
        {
            entity.HasKey(e => e.ChatHistoryId).HasName("PK__ChatHist__302D911272BA8647");

            entity.ToTable("ChatHistory");

            entity.Property(e => e.ChatHistoryId).HasColumnName("ChatHistoryID");
            entity.Property(e => e.ChatId).HasColumnName("ChatID");
            entity.Property(e => e.Message).HasColumnType("text");
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Chat).WithMany(p => p.ChatHistories)
                .HasForeignKey(d => d.ChatId)
                .HasConstraintName("FK__ChatHisto__ChatI__4F7CD00D");

            entity.HasOne(d => d.User).WithMany(p => p.ChatHistories)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__ChatHisto__UserI__5070F446");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK__Comments__C3B4DFAAD5DCC55A");

            entity.Property(e => e.CommentId).HasColumnName("CommentID");
            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.CommentContent).HasColumnType("text");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Article).WithMany(p => p.Comments)
                .HasForeignKey(d => d.ArticleId)
                .HasConstraintName("FK__Comments__Articl__693CA210");

            entity.HasOne(d => d.User).WithMany(p => p.Comments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Comments__UserID__68487DD7");
        });

        modelBuilder.Entity<Gift>(entity =>
        {
            entity.HasKey(e => e.GiftId).HasName("PK__Gifts__4A40E62554D4F0A3");

            entity.Property(e => e.GiftId).HasColumnName("GiftID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.GiftName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PointId).HasColumnName("PointID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Point).WithMany(p => p.Gifts)
                .HasForeignKey(d => d.PointId)
                .HasConstraintName("FK__Gifts__PointID__71D1E811");

            entity.HasOne(d => d.User).WithMany(p => p.Gifts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Gifts__UserID__70DDC3D8");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.LikeId).HasName("PK__Likes__A2922CF4C9B80E23");

            entity.Property(e => e.LikeId).HasColumnName("LikeID");
            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Article).WithMany(p => p.Likes)
                .HasForeignKey(d => d.ArticleId)
                .HasConstraintName("FK__Likes__ArticleID__656C112C");

            entity.HasOne(d => d.User).WithMany(p => p.Likes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Likes__UserID__6477ECF3");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAF162E7170");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Orders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Orders__UserID__3E52440B");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__OrderDet__D3B9D30C805612E7");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DiscountedPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsReviewed).HasDefaultValue(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__4222D4EF");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__OrderDeta__Produ__4316F928");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDED9BFE48");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.FatContent).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.Ingredients).HasColumnType("text");
            entity.Property(e => e.PackagingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StorageInstructions)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Volume).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK__Reports__D5BD48E5F38F16FD");

            entity.Property(e => e.ReportId).HasColumnName("ReportID");
            entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReportContent).HasColumnType("text");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Article).WithMany(p => p.Reports)
                .HasForeignKey(d => d.ArticleId)
                .HasConstraintName("FK__Reports__Article__6D0D32F4");

            entity.HasOne(d => d.Product).WithMany(p => p.Reports)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Reports__Product__6E01572D");

            entity.HasOne(d => d.User).WithMany(p => p.Reports)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reports__UserID__6C190EBB");
        });

        modelBuilder.Entity<Revenue>(entity =>
        {
            entity.HasKey(e => e.RevenueId).HasName("PK__Revenue__275F173D02C0D312");

            entity.ToTable("Revenue");

            entity.Property(e => e.RevenueId).HasColumnName("RevenueID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Order).WithMany(p => p.Revenues)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Revenue__OrderID__59FA5E80");

            entity.HasOne(d => d.User).WithMany(p => p.Revenues)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Revenue__UserID__5AEE82B9");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__74BC79AEC8FAB669");

            entity.Property(e => e.ReviewId).HasColumnName("ReviewID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ReviewContent).HasColumnType("text");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Reviews__Product__49C3F6B7");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reviews__UserID__48CFD27E");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3AF2BB0A55");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__55433A4BFB71C9B4");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Order).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Transacti__Order__5DCAEF64");

            entity.HasOne(d => d.User).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Transacti__UserI__5EBF139D");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC0C3E3C91");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__RoleID__398D8EEE");
        });

        modelBuilder.Entity<UserPoint>(entity =>
        {
            entity.HasKey(e => e.PointId).HasName("PK__UserPoin__40A9778129309C47");

            entity.Property(e => e.PointId).HasColumnName("PointID");
            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.UserPoints)
                .HasForeignKey(d => d.OrderDetailId)
                .HasConstraintName("FK__UserPoint__Order__45F365D3");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.VoucherId).HasName("PK__Vouchers__3AEE79C10BF6AF46");

            entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            entity.Property(e => e.Condition)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MinimumSpend).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.VoucherCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VoucherType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Order).WithMany(p => p.Vouchers)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Vouchers__OrderI__619B8048");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
