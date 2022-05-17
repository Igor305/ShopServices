using System;
using DataAccessLayer.Entities.Mobile;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccessLayer.AppContext
{
    public partial class MobileContext : DbContext
    {
        public MobileContext()
        {
        }

        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityCounter> ActivityCounters { get; set; }
        public virtual DbSet<Assortment> Assortments { get; set; }
        public virtual DbSet<AssortmentList> AssortmentLists { get; set; }
        public virtual DbSet<AssortmentOld> AssortmentOlds { get; set; }
        public virtual DbSet<AssortmentProduct> AssortmentProducts { get; set; }
        public virtual DbSet<AssortmentProductsOld> AssortmentProductsOlds { get; set; }
        public virtual DbSet<BarCode> BarCodes { get; set; }
        public virtual DbSet<BarCode1> BarCodes1 { get; set; }
        public virtual DbSet<BindingType> BindingTypes { get; set; }
        public virtual DbSet<BlockedActivity> BlockedActivities { get; set; }
        public virtual DbSet<BlockedActivityType> BlockedActivityTypes { get; set; }
        public virtual DbSet<BlockedToken> BlockedTokens { get; set; }
        public virtual DbSet<Bonu> Bonus { get; set; }
        public virtual DbSet<Bonu1> Bonus1 { get; set; }
        public virtual DbSet<BonusDetail> BonusDetails { get; set; }
        public virtual DbSet<BonusDetail1> BonusDetails1 { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Card1> Cards1 { get; set; }
        public virtual DbSet<CatalogIcon> CatalogIcons { get; set; }
        public virtual DbSet<DboTRem> DboTRems { get; set; }
        public virtual DbSet<DisabledCategory> DisabledCategories { get; set; }
        public virtual DbSet<DisabledProd> DisabledProds { get; set; }
        public virtual DbSet<DisabledProd1> DisabledProds1 { get; set; }
        public virtual DbSet<DisabledProds20200423t0257> DisabledProds20200423t0257s { get; set; }
        public virtual DbSet<DisabledProdsExternal> DisabledProdsExternals { get; set; }
        public virtual DbSet<DisabledProdsOld> DisabledProdsOlds { get; set; }
        public virtual DbSet<DisabledStock> DisabledStocks { get; set; }
        public virtual DbSet<DisabledStock1> DisabledStocks1 { get; set; }
        public virtual DbSet<DisabledStocks20200408t2006> DisabledStocks20200408t2006s { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Displacement> Displacements { get; set; }
        public virtual DbSet<Displacement1> Displacements1 { get; set; }
        public virtual DbSet<Distributor> Distributors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee1> Employees1 { get; set; }
        public virtual DbSet<EventHistory> EventHistories { get; set; }
        public virtual DbSet<ExternalImage> ExternalImages { get; set; }
        public virtual DbSet<FixedAssetInvoice> FixedAssetInvoices { get; set; }
        public virtual DbSet<FixedAssetInvoice1> FixedAssetInvoices1 { get; set; }
        public virtual DbSet<FixedAssetItem> FixedAssetItems { get; set; }
        public virtual DbSet<FixedAssetItem1> FixedAssetItems1 { get; set; }
        public virtual DbSet<FixedAssetProcessingLog> FixedAssetProcessingLogs { get; set; }
        public virtual DbSet<FixedAssetProcessingLog1> FixedAssetProcessingLogs1 { get; set; }
        public virtual DbSet<FixedAssetProcessingState> FixedAssetProcessingStates { get; set; }
        public virtual DbSet<FixedAssetProcessingState1> FixedAssetProcessingStates1 { get; set; }
        public virtual DbSet<FixedAssetSession> FixedAssetSessions { get; set; }
        public virtual DbSet<FixedAssetSession1> FixedAssetSessions1 { get; set; }
        public virtual DbSet<Gameplay> Gameplays { get; set; }
        public virtual DbSet<GameplayExternal> GameplayExternals { get; set; }
        public virtual DbSet<GameplayProduct> GameplayProducts { get; set; }
        public virtual DbSet<Idea> Ideas { get; set; }
        public virtual DbSet<IdeaType> IdeaTypes { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ImagesLink> ImagesLinks { get; set; }
        public virtual DbSet<ImagesLinksNew> ImagesLinksNews { get; set; }
        public virtual DbSet<ImagesNew> ImagesNews { get; set; }
        public virtual DbSet<IncomeGood> IncomeGoods { get; set; }
        public virtual DbSet<IncomeGood1> IncomeGoods1 { get; set; }
        public virtual DbSet<IncomeInvoice> IncomeInvoices { get; set; }
        public virtual DbSet<IncomeInvoice1> IncomeInvoices1 { get; set; }
        public virtual DbSet<IncomeSession> IncomeSessions { get; set; }
        public virtual DbSet<IncomeSession1> IncomeSessions1 { get; set; }
        public virtual DbSet<ItemsSeenCache> ItemsSeenCaches { get; set; }
        public virtual DbSet<ItemsTotalCache> ItemsTotalCaches { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Log1> Logs1 { get; set; }
        public virtual DbSet<LogCache> LogCaches { get; set; }
        public virtual DbSet<LogDiscExp> LogDiscExps { get; set; }
        public virtual DbSet<LogDiscExp1> LogDiscExps1 { get; set; }
        public virtual DbSet<LogDiscExp2> LogDiscExps2 { get; set; }
        public virtual DbSet<LogDiscExp3> LogDiscExps3 { get; set; }
        public virtual DbSet<LogDiscRec> LogDiscRecs { get; set; }
        public virtual DbSet<LogDiscRec1> LogDiscRecs1 { get; set; }
        public virtual DbSet<LogDiscRec2> LogDiscRecs2 { get; set; }
        public virtual DbSet<LogTransferred> LogTransferreds { get; set; }
        public virtual DbSet<LogType> LogTypes { get; set; }
        public virtual DbSet<LogType1> LogTypes1 { get; set; }
        public virtual DbSet<Merchandiser> Merchandisers { get; set; }
        public virtual DbSet<Merchandiser1> Merchandisers1 { get; set; }
        public virtual DbSet<MerchandiserImage> MerchandiserImages { get; set; }
        public virtual DbSet<MerchandiserImagesLink> MerchandiserImagesLinks { get; set; }
        public virtual DbSet<NoveltiesOldDownload> NoveltiesOldDownloads { get; set; }
        public virtual DbSet<Novelty> Novelties { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Person1> Persons1 { get; set; }
        public virtual DbSet<PersonCard> PersonCards { get; set; }
        public virtual DbSet<PersonCard1> PersonCards1 { get; set; }
        public virtual DbSet<Persons20210611t0137> Persons20210611t0137s { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Price1> Prices1 { get; set; }
        public virtual DbSet<ProcessingLog> ProcessingLogs { get; set; }
        public virtual DbSet<ProcessingLog1> ProcessingLogs1 { get; set; }
        public virtual DbSet<ProcessingState> ProcessingStates { get; set; }
        public virtual DbSet<ProcessingState1> ProcessingStates1 { get; set; }
        public virtual DbSet<ProcessingStateType> ProcessingStateTypes { get; set; }
        public virtual DbSet<Prod> Prods { get; set; }
        public virtual DbSet<Prod1> Prods1 { get; set; }
        public virtual DbSet<ProdImage> ProdImages { get; set; }
        public virtual DbSet<ProdImage1> ProdImages1 { get; set; }
        public virtual DbSet<ProdImagesLastSync> ProdImagesLastSyncs { get; set; }
        public virtual DbSet<ProdImagesLastSync1> ProdImagesLastSyncs1 { get; set; }
        public virtual DbSet<ProdImagesLastSyncOldDownload> ProdImagesLastSyncOldDownloads { get; set; }
        public virtual DbSet<ProdImagesOld> ProdImagesOlds { get; set; }
        public virtual DbSet<ProdKm> ProdKms { get; set; }
        public virtual DbSet<Prods20200429> Prods20200429s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductCategory1> ProductCategories1 { get; set; }
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
        public virtual DbSet<ProductGroup1> ProductGroups1 { get; set; }
        public virtual DbSet<ProductGroups1> ProductGroups1s { get; set; }
        public virtual DbSet<ProductGroups11> ProductGroups1s1 { get; set; }
        public virtual DbSet<ProductRelated> ProductRelateds { get; set; }
        public virtual DbSet<ProductRelatedOldDownload> ProductRelatedOldDownloads { get; set; }
        public virtual DbSet<ProductsKvi> ProductsKvis { get; set; }
        public virtual DbSet<ProductsKvinew> ProductsKvinews { get; set; }
        public virtual DbSet<ProductsOldDownload> ProductsOldDownloads { get; set; }
        public virtual DbSet<ProductsSubGroupKvi> ProductsSubGroupKvis { get; set; }
        public virtual DbSet<Promo> Promos { get; set; }
        public virtual DbSet<Promo1> Promos1 { get; set; }
        public virtual DbSet<PromoDescription> PromoDescriptions { get; set; }
        public virtual DbSet<PromoDescription1> PromoDescriptions1 { get; set; }
        public virtual DbSet<PromoDescriptionsNew> PromoDescriptionsNews { get; set; }
        public virtual DbSet<PromoDescriptionsNew1> PromoDescriptionsNews1 { get; set; }
        public virtual DbSet<PromoImage> PromoImages { get; set; }
        public virtual DbSet<PromoImagesLink> PromoImagesLinks { get; set; }
        public virtual DbSet<PromoImagesLinksNew> PromoImagesLinksNews { get; set; }
        public virtual DbSet<PromoImagesNew> PromoImagesNews { get; set; }
        public virtual DbSet<PromoNew> PromoNews { get; set; }
        public virtual DbSet<PromoNew1> PromoNews1 { get; set; }
        public virtual DbSet<PubArticle> PubArticles { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Rem> Rems { get; set; }
        public virtual DbSet<RequestInfo> RequestInfos { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Sale1> Sales1 { get; set; }
        public virtual DbSet<Sale2> Sales2 { get; set; }
        public virtual DbSet<SaleDetail> SaleDetails { get; set; }
        public virtual DbSet<SaleDetail1> SaleDetails1 { get; set; }
        public virtual DbSet<SaleDetail2> SaleDetails2 { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Shop1> Shops1 { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Stock1> Stocks1 { get; set; }
        public virtual DbSet<StockArea> StockAreas { get; set; }
        public virtual DbSet<StockArea1> StockAreas1 { get; set; }
        public virtual DbSet<StoreLocation> StoreLocations { get; set; }
        public virtual DbSet<StoreLocationsOldDownload> StoreLocationsOldDownloads { get; set; }
        public virtual DbSet<SubArticle> SubArticles { get; set; }
        public virtual DbSet<SubEventHistory> SubEventHistories { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<TRem> TRems { get; set; }
        public virtual DbSet<TagState> TagStates { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<Token1> Tokens1 { get; set; }
        public virtual DbSet<TokenBinding> TokenBindings { get; set; }
        public virtual DbSet<TokenBinding1> TokenBindings1 { get; set; }
        public virtual DbSet<TokenBindingsOld> TokenBindingsOlds { get; set; }
        public virtual DbSet<TokenPosBinding> TokenPosBindings { get; set; }
        public virtual DbSet<TokenQtyBinding> TokenQtyBindings { get; set; }
        public virtual DbSet<TokenQtyBindingsOld> TokenQtyBindingsOlds { get; set; }
        public virtual DbSet<TokenRight> TokenRights { get; set; }
        public virtual DbSet<TokenStoreBinding> TokenStoreBindings { get; set; }
        public virtual DbSet<TokenStoreRight> TokenStoreRights { get; set; }
        public virtual DbSet<Entities.Mobile.Version> Versions { get; set; }
        public virtual DbSet<WishList> WishLists { get; set; }
        public virtual DbSet<WriteOff> WriteOffs { get; set; }
        public virtual DbSet<WriteOff1> WriteOffs1 { get; set; }
        public virtual DbSet<WriteOffGood> WriteOffGoods { get; set; }
        public virtual DbSet<WriteOffGood1> WriteOffGoods1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=sql11;Initial Catalog=Mobile;Persist Security Info=True;User ID=j-sql11-Mobile_Test-reader;Password=7z7hY7KuETHE79x3p4eh");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<ActivityCounter>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.TokenId, e.Type });

                entity.ToTable("ActivityCounters", "mobile");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<Assortment>(entity =>
            {
                entity.ToTable("Assortment", "wgoods");

                entity.Property(e => e.AssortmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("assortment_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.MinAmout).HasColumnName("min_amout");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AssortmentList>(entity =>
            {
                entity.HasKey(e => new { e.AmPosCode, e.AmPosPriceList, e.AssortmentCode })
                    .HasName("PK_mobile_AssortmentList");

                entity.ToTable("AssortmentList", "mobile");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssortmentOld>(entity =>
            {
                entity.HasKey(e => e.AssortmentId)
                    .HasName("PK-wgoods-Assortment");

                entity.ToTable("Assortment_Old", "wgoods");

                entity.Property(e => e.AssortmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("assortment_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.MinAmout).HasColumnName("min_amout");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AssortmentProduct>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductCode })
                    .HasName("PK-wgoods-Assortment_Products2");

                entity.ToTable("Assortment_Products", "wgoods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.AssortmentId).HasColumnName("assortment_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AssortmentProductsOld>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductCode })
                    .HasName("PK-wgoods-Assortment_Products");

                entity.ToTable("Assortment_Products_Old", "wgoods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.AssortmentId).HasColumnName("assortment_id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BarCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BarCodes");

                entity.Property(e => e.BarCode1)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("BarCode");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<BarCode1>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.Um })
                    .HasName("_pk_r_ProdMQ")
                    .IsClustered(false);

                entity.ToTable("BarCodes", "replica");

                entity.HasIndex(e => e.BarCode, "CIDX-replica-BarCodes")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Um)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UM");

                entity.Property(e => e.BarCode)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BindingType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BindingType", "bind");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlockedActivity>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TokenId });

                entity.ToTable("BlockedActivities", "mobile");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlockedActivityType>(entity =>
            {
                entity.ToTable("BlockedActivityType", "mobile");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<BlockedToken>(entity =>
            {
                entity.HasKey(e => e.TokenId);

                entity.ToTable("BlockedTokens", "mobile");

                entity.Property(e => e.TokenId).ValueGeneratedNever();

                entity.Property(e => e.BlockingReason).HasMaxLength(256);

                entity.Property(e => e.DateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bonu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Bonus");

                entity.Property(e => e.Bdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BDate");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.Edate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDate");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ы)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ы");
            });

            modelBuilder.Entity<Bonu1>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("pk_it_Bonuses");

                entity.ToTable("Bonus", "replica");

                entity.HasIndex(e => new { e.InUse, e.ChId }, "IDX-replica-Bonus-01")
                    .IsUnique();

                entity.HasIndex(e => new { e.InUse, e.Bdate, e.Edate, e.ChId }, "UIDX-replica-Bonus-000")
                    .IsUnique();

                entity.Property(e => e.ChId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChID");

                entity.Property(e => e.Bdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BDate");

                entity.Property(e => e.DocDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.Edate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDate");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BonusDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BonusDetails");

                entity.Property(e => e.Brate)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("BRate");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.ChangeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SrcPosId).HasColumnName("SrcPosID");

                entity.Property(e => e.SumCc)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("SumCC");

                entity.Property(e => e.ValidStocks)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BonusDetail1>(entity =>
            {
                entity.HasKey(e => new { e.ChId, e.SrcPosId })
                    .HasName("pk_it_BonusD");

                entity.ToTable("BonusDetails", "replica");

                entity.HasIndex(e => new { e.Action, e.ProdId, e.ChId }, "IDX-replica-BonusDetails-01");

                entity.HasIndex(e => new { e.Action, e.ProdId, e.ChId, e.SrcPosId }, "UIDX-replica-BonusDetails")
                    .IsUnique();

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.SrcPosId).HasColumnName("SrcPosID");

                entity.Property(e => e.Brate)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("BRate");

                entity.Property(e => e.ChangeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PcatSubgroupid).HasColumnName("PCatSubgroupid");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SumCc)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("SumCC");

                entity.Property(e => e.ValidStocks)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Cards");

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<Card1>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("pk_r_DCards")
                    .IsClustered(false);

                entity.ToTable("Cards", "replica");

                entity.HasIndex(e => e.DcardId, "CIDX-replica-Cards")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ChId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChID");

                entity.Property(e => e.Bdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BDate");

                entity.Property(e => e.DcardId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DCardID");

                entity.Property(e => e.DctypeCode).HasColumnName("DCTypeCode");

                entity.Property(e => e.Discount).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Edate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDate");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.SumCc)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("SumCC");
            });

            modelBuilder.Entity<CatalogIcon>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.PcatId, e.PgrId, e.PgrId1 });

                entity.ToTable("CatalogIcons", "mobile");

                entity.Property(e => e.PcatId).HasColumnName("PCatID");

                entity.Property(e => e.PgrId).HasColumnName("PGrID");

                entity.Property(e => e.PgrId1).HasColumnName("PGrID1");
            });

            modelBuilder.Entity<DboTRem>(entity =>
            {
                entity.HasKey(e => new { e.PackNo, e.Action, e.OurId, e.StockId, e.SecId, e.ProdId, e.Ppid })
                    .HasName("pk-sub-dbo_t_Rem");

                entity.ToTable("dbo_t_Rem", "sub");

                entity.Property(e => e.PackNo).HasColumnName("$_PackNo_$");

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .HasColumnName("$_Action_$")
                    .IsFixedLength(true);

                entity.Property(e => e.OurId).HasColumnName("OurID");

                entity.Property(e => e.StockId).HasColumnName("StockID");

                entity.Property(e => e.SecId).HasColumnName("SecID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.AccQty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<DisabledCategory>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.PcatId, e.PgrId, e.PgrId1 });

                entity.ToTable("DisabledCategories", "mobile");

                entity.Property(e => e.PcatId).HasColumnName("PCatID");

                entity.Property(e => e.PgrId).HasColumnName("PGrID");

                entity.Property(e => e.PgrId1).HasColumnName("PGrID1");
            });

            modelBuilder.Entity<DisabledProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DisabledProds", "external");

                entity.Property(e => e.DateTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<DisabledProd1>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK_DisabledProds2");

                entity.ToTable("DisabledProds", "mobile");

                entity.Property(e => e.ProdId).ValueGeneratedNever();

                entity.Property(e => e.DateTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<DisabledProds20200423t0257>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("DisabledProds_20200423T0257", "mobile");

                entity.Property(e => e.ProdId).ValueGeneratedNever();

                entity.Property(e => e.DateTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<DisabledProdsExternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DisabledProds_external", "wgoods");

                entity.Property(e => e.AvailPeriod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("avail_period")
                    .IsFixedLength(true);

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("from_date");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("product_code");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("to_date");
            });

            modelBuilder.Entity<DisabledProdsOld>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK_DisabledProds");

                entity.ToTable("DisabledProds_Old", "mobile");

                entity.Property(e => e.ProdId).ValueGeneratedNever();

                entity.Property(e => e.DateTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<DisabledStock>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK_gms_DisabledStocks");

                entity.ToTable("DisabledStocks", "gms");

                entity.Property(e => e.StockId).ValueGeneratedNever();
            });

            modelBuilder.Entity<DisabledStock1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DisabledStocks", "mobile");
            });

            modelBuilder.Entity<DisabledStocks20200408t2006>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("PK_DisabledStocks");

                entity.ToTable("DisabledStocks_20200408T2006", "mobile");

                entity.Property(e => e.StockId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.HasKey(e => e.DiscCode)
                    .HasName("pk_r_Discs");

                entity.ToTable("Discounts", "replica");

                entity.Property(e => e.DiscCode).ValueGeneratedNever();

                entity.Property(e => e.AllowDiscs)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Bdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("BDate");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.ChargeDcard).HasColumnName("ChargeDCard");

                entity.Property(e => e.DiscFromDcard).HasColumnName("DiscFromDCard");

                entity.Property(e => e.DiscName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscOnlyWithDcard).HasColumnName("DiscOnlyWithDCard");

                entity.Property(e => e.Edate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDate");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaveBonusToDcard).HasColumnName("SaveBonusToDCard");

                entity.Property(e => e.SaveDiscToDcard).HasColumnName("SaveDiscToDCard");

                entity.Property(e => e.Shed1)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Shed2)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Shed3)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCut)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValidOurs)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValidStocks)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Displacement>(entity =>
            {
                entity.ToTable("Displacements", "gms");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Displacement1>(entity =>
            {
                entity.ToTable("Displacements", "gmstest");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Distributor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-Distributors")
                    .IsClustered(false);

                entity.ToTable("Distributors", "config");

                entity.HasComment("Справочник распространителей");

                entity.HasIndex(e => e.StateId, "IX-config-Distributors_00");

                entity.HasIndex(e => e.Description, "UK-config-Distributors-Description")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные распространителя");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("Описание распространителя");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные распространителя");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные распространителя");

                entity.Property(e => e.Self).HasComment("Текущий распространитель");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные распространителя");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Distributors)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Distributors_StateID-config_States");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employees");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee1>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("pk_r_Emps");

                entity.ToTable("Employees", "replica");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.EmpBarCode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpInitials)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpParName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.StockId).HasColumnName("StockID");

                entity.Property(e => e.UaempFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UAEmpFirstName");

                entity.Property(e => e.UaempInitials)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UAEmpInitials");

                entity.Property(e => e.UaempLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UAEmpLastName");

                entity.Property(e => e.UaempName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UAEmpName");

                entity.Property(e => e.UaempParName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UAEmpParName");

                entity.Property(e => e.VaccinationId).HasColumnName("VaccinationID");
            });

            modelBuilder.Entity<EventHistory>(entity =>
            {
                entity.HasKey(e => new { e.EventDate, e.EventId })
                    .HasName("PK-log-EventHistory");

                entity.ToTable("EventHistory", "log");

                entity.HasComment("Журнал действий");

                entity.Property(e => e.EventDate)
                    .HasColumnType("date")
                    .HasComment("Дата события");

                entity.Property(e => e.EventId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EventID")
                    .HasComment("Счетчик");

                entity.Property(e => e.EventTime).HasComment("Время события");

                entity.Property(e => e.Info)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasComment("Действие");

                entity.Property(e => e.Procedure)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("Имя процедуры");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ExternalImage>(entity =>
            {
                entity.ToTable("ExternalImages", "mobile");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(42)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixedAssetInvoice>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId })
                    .HasName("PK_gms_FixedAssetInvoices");

                entity.ToTable("FixedAssetInvoices", "gms");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Nacc).HasColumnName("NAcc");

                entity.Property(e => e.Sum).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<FixedAssetInvoice1>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId })
                    .HasName("PK_gmstest_FixedAssetInvoices");

                entity.ToTable("FixedAssetInvoices", "gmstest");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Nacc).HasColumnName("NAcc");

                entity.Property(e => e.Sum).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<FixedAssetItem>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId, e.Pos })
                    .HasName("PK_gms_FixedAssetItems");

                entity.ToTable("FixedAssetItems", "gms");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Fact).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Um)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<FixedAssetItem1>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId, e.Pos })
                    .HasName("PK_gmstest_FixedAssetItems");

                entity.ToTable("FixedAssetItems", "gmstest");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Fact).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Um)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<FixedAssetProcessingLog>(entity =>
            {
                entity.ToTable("FixedAssetProcessingLog", "gms");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixedAssetProcessingLog1>(entity =>
            {
                entity.ToTable("FixedAssetProcessingLog", "gmstest");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixedAssetProcessingState>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("PK_gms_FixedAssetProcessingStates");

                entity.ToTable("FixedAssetProcessingStates", "gms");

                entity.Property(e => e.ChId).ValueGeneratedNever();

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<FixedAssetProcessingState1>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("PK_gmstest_FixedAssetProcessingStates");

                entity.ToTable("FixedAssetProcessingStates", "gmstest");

                entity.Property(e => e.ChId).ValueGeneratedNever();

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<FixedAssetSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_gms_FixedAssetSessions");

                entity.ToTable("FixedAssetSessions", "gms");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFinished).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FixedAssetSession1>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_gmstest_FixedAssetSessions");

                entity.ToTable("FixedAssetSessions", "gmstest");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFinished).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gameplay>(entity =>
            {
                entity.ToTable("gameplay", "wgoods");

                entity.Property(e => e.GameplayId)
                    .ValueGeneratedNever()
                    .HasColumnName("gameplay_id");

                entity.Property(e => e.BonusCount).HasColumnName("bonus_count");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("from_date");

                entity.Property(e => e.LimitUah)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("limit_uah");

                entity.Property(e => e.NameRu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_ru");

                entity.Property(e => e.NameUa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_ua");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("to_date");
            });

            modelBuilder.Entity<GameplayExternal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gameplay_external", "wgoods");

                entity.Property(e => e.BonusCount).HasColumnName("bonus_count");

                entity.Property(e => e.FromDate).HasColumnName("from_date");

                entity.Property(e => e.GameplayId).HasColumnName("gameplay_id");

                entity.Property(e => e.LimitUah)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("limit_uah");

                entity.Property(e => e.NameRu)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_ru");

                entity.Property(e => e.NameUa)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name_ua");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.ToDate).HasColumnName("to_date");
            });

            modelBuilder.Entity<GameplayProduct>(entity =>
            {
                entity.HasKey(e => new { e.GameplayId, e.ProductCode })
                    .HasName("PK-gameplay_products");

                entity.ToTable("gameplay_products", "wgoods");

                entity.Property(e => e.GameplayId).HasColumnName("gameplay_id");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(32)
                    .HasColumnName("product_code");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Idea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ideas", "mobile");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.CallbackPhone)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Idea1)
                    .IsUnicode(false)
                    .HasColumnName("Idea");
            });

            modelBuilder.Entity<IdeaType>(entity =>
            {
                entity.ToTable("IdeaType", "mobile");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("images", "wgoods");

                entity.HasIndex(e => e.ImageId, "IDX-dbo-Images-001")
                    .IsUnique();

                entity.Property(e => e.ImageId)
                    .ValueGeneratedNever()
                    .HasColumnName("image_id");

                entity.Property(e => e.Image1).HasColumnName("image");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageX).HasColumnName("image_x");

                entity.Property(e => e.ImageY).HasColumnName("image_y");
            });

            modelBuilder.Entity<ImagesLink>(entity =>
            {
                entity.HasKey(e => e.PairId)
                    .HasName("PK-wgoods-images_links");

                entity.ToTable("images_links", "wgoods");

                entity.HasIndex(e => new { e.ObjectType, e.Status, e.DetailedId }, "IDX-dbo-Images_Links-001");

                entity.HasIndex(e => e.DetailedId, "IDX-dbo-Images_Links-002");

                entity.HasIndex(e => new { e.ObjectType, e.Status, e.ObjectId }, "IDX-dbo-Images_Links-003");

                entity.Property(e => e.PairId)
                    .ValueGeneratedNever()
                    .HasColumnName("pair_id");

                entity.Property(e => e.DetailedId).HasColumnName("detailed_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("object_type");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ImagesLinksNew>(entity =>
            {
                entity.HasKey(e => e.PairId)
                    .HasName("PK-wgoods-images_links_new");

                entity.ToTable("images_links_New", "wgoods");

                entity.Property(e => e.PairId)
                    .ValueGeneratedNever()
                    .HasColumnName("pair_id");

                entity.Property(e => e.DetailedId).HasColumnName("detailed_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("object_type");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ImagesNew>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PK-wgoods-images_new");

                entity.ToTable("images_New", "wgoods");

                entity.Property(e => e.ImageId)
                    .ValueGeneratedNever()
                    .HasColumnName("image_id");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageX).HasColumnName("image_x");

                entity.Property(e => e.ImageY).HasColumnName("image_y");
            });

            modelBuilder.Entity<IncomeGood>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId, e.Pos })
                    .HasName("PK_gms_IncomeGoods");

                entity.ToTable("IncomeGoods", "gms");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Fact).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Um)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<IncomeGood1>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId, e.Pos })
                    .HasName("PK_gmstest_IncomeGoods");

                entity.ToTable("IncomeGoods", "gmstest");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Fact).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Um)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<IncomeInvoice>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId })
                    .HasName("PK_gms_IncomeInvoices");

                entity.ToTable("IncomeInvoices", "gms");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Nacc).HasColumnName("NAcc");

                entity.Property(e => e.Sum).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<IncomeInvoice1>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.ChId })
                    .HasName("PK_gmstest_IncomeInvoices");

                entity.ToTable("IncomeInvoices", "gmstest");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.Nacc).HasColumnName("NAcc");

                entity.Property(e => e.Sum).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<IncomeSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_gms_IncomeSessions");

                entity.ToTable("IncomeSessions", "gms");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFinished).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncomeSession1>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_gmstest_IncomeSessions");

                entity.ToTable("IncomeSessions", "gmstest");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFinished).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemsSeenCache>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.Type, e.ItemId })
                    .HasName("PK_Mobile_ItemsSeenCache");

                entity.ToTable("ItemsSeenCache", "mobile");

                entity.Property(e => e.DateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemsTotalCache>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.Type })
                    .HasName("PK_Mobile_ItemsTotalCache");

                entity.ToTable("ItemsTotalCache", "mobile");

                entity.Property(e => e.DateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log", "chatbot");

                entity.Property(e => e.CardId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log", "mobile");

                entity.HasIndex(e => new { e.Type, e.DateTime }, "IX-mobile-Log-01");

                entity.HasIndex(e => new { e.DateTime, e.Type, e.StockId, e.ProdId }, "IX-mobile-Log-02");

                entity.HasIndex(e => new { e.TokenId, e.Type, e.DateTime }, "IX-mobile-Log-03");

                entity.HasIndex(e => new { e.Type, e.DateTime, e.ProdId }, "IX-mobile-Log-04");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.CallbackPhone)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackId)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.NetBiosName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogCache>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LogId });

                entity.ToTable("LogCache", "mobile");

                entity.HasIndex(e => new { e.LogType, e.ProdId }, "IX-mobile-LogCache-01");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LogDiscExp>(entity =>
            {
                entity.HasKey(e => new { e.DbiId, e.LogId })
                    .HasName("PK-replica-LogDiscExp")
                    .IsClustered(false);

                entity.ToTable("LogDiscExp", "archive");

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.DcardId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DCardID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogDiscExp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LogDiscExp");

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.DcardId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DCardID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(32, 9)");
            });

            modelBuilder.Entity<LogDiscExp2>(entity =>
            {
                entity.HasKey(e => new { e.DbiId, e.LogId, e.DiscCode })
                    .HasName("PK-replica-LogDiscExp")
                    .IsClustered(false);

                entity.ToTable("LogDiscExp", "replica");

                entity.HasIndex(e => new { e.DcardChId, e.LogDate, e.DbiId, e.LogId }, "CIDX-replica-LogDiscExp")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.DcardChId).HasColumnName("DCardChID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogDiscExp3>(entity =>
            {
                entity.HasKey(e => new { e.DbiId, e.LogId })
                    .HasName("PK-temp-LogDiscExp")
                    .IsClustered(false);

                entity.ToTable("LogDiscExp", "temp");

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.DcardChId).HasColumnName("DCardChID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogDiscRec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LogDiscRec");

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.DcardId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DCardID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogDiscRec1>(entity =>
            {
                entity.HasKey(e => new { e.DbiId, e.LogId })
                    .HasName("PK-replica-LogDiscRec")
                    .IsClustered(false);

                entity.ToTable("LogDiscRec", "replica");

                entity.HasIndex(e => new { e.DcardChId, e.LogDate, e.DbiId, e.LogId }, "CIDX-replica-LogDiscRec_OldVersion")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.DcardChId).HasColumnName("DCardChID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogDiscRec2>(entity =>
            {
                entity.HasKey(e => new { e.DbiId, e.LogId })
                    .HasName("PK-temp-LogDiscRec")
                    .IsClustered(false);

                entity.ToTable("LogDiscRec", "temp");

                entity.Property(e => e.DbiId).HasColumnName("DBiID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.DcardChId).HasColumnName("DCardChID");

                entity.Property(e => e.LogDate).HasColumnType("date");

                entity.Property(e => e.SumBonus).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<LogTransferred>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogTransferred", "mobile");

                entity.HasIndex(e => new { e.Id, e.TokenId, e.DateTime }, "CIDX-mobile-LogTransferred")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.DateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogType>(entity =>
            {
                entity.ToTable("LogType", "chatbot");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<LogType1>(entity =>
            {
                entity.ToTable("LogType", "mobile");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Merchandiser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Merchandiser");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("barcode");

                entity.Property(e => e.CodeGms).HasColumnName("code_gms");

                entity.Property(e => e.GroupProducts)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("group_products");

                entity.Property(e => e.MerchandiserId).HasColumnName("merchandiser_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name");

                entity.Property(e => e.NameGms)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name_gms");

                entity.Property(e => e.NameRegionManager)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name_region_manager");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneRegionManager)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("phone_region_manager");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("region");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("to_date");
            });

            modelBuilder.Entity<Merchandiser1>(entity =>
            {
                entity.HasKey(e => e.MerchandiserId)
                    .HasName("PK-wgoods-Merchandiser");

                entity.ToTable("Merchandiser", "wgoods");

                entity.Property(e => e.MerchandiserId)
                    .ValueGeneratedNever()
                    .HasColumnName("merchandiser_id");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("barcode");

                entity.Property(e => e.CodeGms).HasColumnName("code_gms");

                entity.Property(e => e.GroupProducts)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("group_products");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name");

                entity.Property(e => e.NameGms)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name_gms");

                entity.Property(e => e.NameRegionManager)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name_region_manager");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("phone");

                entity.Property(e => e.PhoneRegionManager)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("phone_region_manager");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("region");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("to_date");
            });

            modelBuilder.Entity<MerchandiserImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Merchandiser_Images");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.ImageFullpath)
                    .HasMaxLength(316)
                    .HasColumnName("image_fullpath");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageX).HasColumnName("image_x");

                entity.Property(e => e.ImageY).HasColumnName("image_y");
            });

            modelBuilder.Entity<MerchandiserImagesLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Merchandiser_ImagesLinks");

                entity.Property(e => e.DetailedId).HasColumnName("detailed_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("object_type");

                entity.Property(e => e.PairId).HasColumnName("pair_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NoveltiesOldDownload>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.SaleStart, e.SaleEnd })
                    .HasName("PK-dbo-Novelties_OldDownload");

                entity.ToTable("Novelties_OldDownload");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SaleStart)
                    .HasColumnType("date")
                    .HasColumnName("sale_start");

                entity.Property(e => e.SaleEnd)
                    .HasColumnType("date")
                    .HasColumnName("sale_end");

                entity.Property(e => e.IsExtraNewest).HasColumnName("is_extra_newest");

                entity.Property(e => e.IsNewest).HasColumnName("is_newest");

                entity.Property(e => e.IsSale).HasColumnName("is_sale");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("numeric(18, 5)")
                    .HasColumnName("sale_price");
            });

            modelBuilder.Entity<Novelty>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.SaleStart, e.SaleEnd })
                    .HasName("PK-dbo-Novelties");

                entity.HasIndex(e => new { e.ProdId, e.SaleStart, e.SaleEnd }, "IDX-dbo-Novelties-GetSalePrice")
                    .IsUnique();

                entity.HasIndex(e => e.ProdId, "IDX-dbo-Novelties-Properties")
                    .IsUnique();

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SaleStart)
                    .HasColumnType("date")
                    .HasColumnName("sale_start");

                entity.Property(e => e.SaleEnd)
                    .HasColumnType("date")
                    .HasColumnName("sale_end");

                entity.Property(e => e.IsExtraNewest).HasColumnName("is_extra_newest");

                entity.Property(e => e.IsNewest).HasColumnName("is_newest");

                entity.Property(e => e.IsSale).HasColumnName("is_sale");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("numeric(18, 5)")
                    .HasColumnName("sale_price");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Persons", "chatbot");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.FactCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FillingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person1>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("pk_r_Persons");

                entity.ToTable("Persons", "replica");

                entity.Property(e => e.PersonId)
                    .ValueGeneratedNever()
                    .HasColumnName("PersonID");

                entity.Property(e => e.AddVk).HasColumnName("AddVK");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.FactAptNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactBlock)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactDistrict)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactHouse)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactPostIndex)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactRegion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactStreet)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FillingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NotReceiveEmail).HasColumnName("NotReceiveEMail");

                entity.Property(e => e.NotReceiveSms).HasColumnName("NotReceiveSMS");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneWork)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Preferences)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ReferalPersonId).HasColumnName("ReferalPersonID");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonCard>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.DcardChId })
                    .HasName("pk_Chatbot_PersonDC");

                entity.ToTable("PersonCards", "chatbot");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.DcardChId).HasColumnName("DCardChID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonCard1>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.DcardChId })
                    .HasName("pk_r_PersonDC");

                entity.ToTable("PersonCards", "replica");

                entity.HasIndex(e => e.DcardChId, "IDX-replica-PersonCards-00");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.DcardChId).HasColumnName("DCardChID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persons20210611t0137>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("pk_r_Persons_20210611T0137");

                entity.ToTable("Persons_20210611T0137", "replica");

                entity.Property(e => e.PersonId)
                    .ValueGeneratedNever()
                    .HasColumnName("PersonID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("smalldatetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMail");

                entity.Property(e => e.FactCity)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FillingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Price");

                entity.Property(e => e.Plid).HasColumnName("PLID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdPrice).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<Price1>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.Plid })
                    .HasName("_pk_r_ProdMP");

                entity.ToTable("Prices", "replica");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Plid).HasColumnName("PLID");

                entity.Property(e => e.PriceMc)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("PriceMC");
            });

            modelBuilder.Entity<ProcessingLog>(entity =>
            {
                entity.ToTable("ProcessingLog", "gms");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessingLog1>(entity =>
            {
                entity.ToTable("ProcessingLog", "gmstest");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessingState>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("PK_gms_ProcessingStates");

                entity.ToTable("ProcessingStates", "gms");

                entity.Property(e => e.ChId).ValueGeneratedNever();

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ProcessingState1).HasColumnName("ProcessingState");
            });

            modelBuilder.Entity<ProcessingState1>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("PK_gmstest_ProcessingStates");

                entity.ToTable("ProcessingStates", "gmstest");

                entity.Property(e => e.ChId).ValueGeneratedNever();

                entity.Property(e => e.DateModified).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProcessingStateType>(entity =>
            {
                entity.ToTable("ProcessingStateType", "gms");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Prod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Prods");

                entity.Property(e => e.AssortmentPriceName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdNameRus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNameUkr)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prod1>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("pk_r_Prods");

                entity.ToTable("Prods", "replica");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");

                entity.Property(e => e.AssortmentPriceName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BrendId).HasColumnName("BrendID");

                entity.Property(e => e.CellNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocValidPeriod).HasColumnType("smalldatetime");

                entity.Property(e => e.EpId).HasColumnName("EpID");

                entity.Property(e => e.MainProdId).HasColumnName("MainProdID");

                entity.Property(e => e.MerchGrId).HasColumnName("MerchGrID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PcatId).HasColumnName("PCatID");

                entity.Property(e => e.PcatKmid).HasColumnName("PcatKMID");

                entity.Property(e => e.PgrId).HasColumnName("PGrID");

                entity.Property(e => e.PgrId1).HasColumnName("PGrID1");

                entity.Property(e => e.PgrId2).HasColumnName("PGrID2");

                entity.Property(e => e.PgrId3).HasColumnName("PGrID3");

                entity.Property(e => e.ProdIdroleId).HasColumnName("ProdIDRoleID");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderProdName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.TrackWms).HasColumnName("TrackWMS");

                entity.Property(e => e.Um)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<ProdImage>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.ImageId })
                    .HasName("PK_dbo-ProdImages");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");
            });

            modelBuilder.Entity<ProdImage1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProdImages", "log");

                entity.Property(e => e.Dl)
                    .HasColumnType("date")
                    .HasColumnName("dl");

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.Tl).HasColumnName("tl");
            });

            modelBuilder.Entity<ProdImagesLastSync>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProdImages_LastSync");

                entity.Property(e => e.Value).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdImagesLastSync1>(entity =>
            {
                entity.ToTable("ProdImages_LastSync", "params");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Value).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdImagesLastSyncOldDownload>(entity =>
            {
                entity.ToTable("ProdImages_LastSync_OldDownload", "params");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Value).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdImagesOld>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.ImageId })
                    .HasName("PK_dbo-ProdImages_Old");

                entity.ToTable("ProdImages_Old");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");
            });

            modelBuilder.Entity<ProdKm>(entity =>
            {
                entity.HasKey(e => e.PcatKmid)
                    .HasName("pk_ir_ProdKM")
                    .IsClustered(false);

                entity.ToTable("ProdKM", "replica");

                entity.Property(e => e.PcatKmid)
                    .ValueGeneratedNever()
                    .HasColumnName("PcatKMID");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PcatKmname)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("PCatKMName");
            });

            modelBuilder.Entity<Prods20200429>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Prods20200429");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdNameRus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdNameUkr)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products", "wgoods");

                entity.HasIndex(e => new { e.ProductId, e.ProductCode }, "IDX-wgoods-products-00")
                    .IsUnique();

                entity.HasIndex(e => new { e.ProductCode, e.Kvi }, "IDX-wgoods-products-01");

                entity.HasIndex(e => new { e.ProductCode, e.DaysWarranty30 }, "IDX-wgoods-products-02");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("product_id");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DaysWarranty30)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("days_warranty_30")
                    .IsFixedLength(true);

                entity.Property(e => e.Defender)
                    .HasMaxLength(1)
                    .HasColumnName("defender")
                    .IsFixedLength(true);

                entity.Property(e => e.Kvi)
                    .HasMaxLength(1)
                    .HasColumnName("kvi")
                    .IsFixedLength(true);

                entity.Property(e => e.KviSubgroup)
                    .HasMaxLength(1)
                    .HasColumnName("kvi_subgroup")
                    .IsFixedLength(true);

                entity.Property(e => e.MaxQty).HasColumnName("max_qty");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("product_type")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.UpdatedTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_timestamp");

                entity.Property(e => e.WarrantyMonths).HasColumnName("warranty_months");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductCategories");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCategory1>(entity =>
            {
                entity.HasKey(e => e.PcatId)
                    .HasName("pk_r_ProdC");

                entity.ToTable("ProductCategories", "replica");

                entity.Property(e => e.PcatId)
                    .ValueGeneratedNever()
                    .HasColumnName("PCatID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PcatName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PCatName");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductGroups");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductGroup1>(entity =>
            {
                entity.HasKey(e => e.PgrId)
                    .HasName("pk_r_ProdG");

                entity.ToTable("ProductGroups", "replica");

                entity.Property(e => e.PgrId)
                    .ValueGeneratedNever()
                    .HasColumnName("PGrID");

                entity.Property(e => e.CodeId4).HasColumnName("CodeID4");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PgrName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PGrName");
            });

            modelBuilder.Entity<ProductGroups1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductGroups1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductGroups11>(entity =>
            {
                entity.HasKey(e => e.PgrId1)
                    .HasName("pk_r_ProdG1");

                entity.ToTable("ProductGroups1", "replica");

                entity.Property(e => e.PgrId1)
                    .ValueGeneratedNever()
                    .HasColumnName("PGrID1");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PgrName1)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PGrName1");
            });

            modelBuilder.Entity<ProductRelated>(entity =>
            {
                entity.ToTable("product_related", "wgoods");

                entity.HasIndex(e => new { e.ProductCode, e.Status, e.RelatedProductCode }, "IDX-wgoods-Product_Related-01");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.RelatedProductCode).HasColumnName("related_product_code");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProductRelatedOldDownload>(entity =>
            {
                entity.ToTable("product_related_OldDownload", "wgoods");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.RelatedProductCode).HasColumnName("related_product_code");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProductsKvi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductsKVI", "wgoods");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<ProductsKvinew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductsKVINew", "wgoods");

                entity.Property(e => e.AssortmentId).HasColumnName("assortment_id");

                entity.Property(e => e.MinAmout).HasColumnName("min_amout");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<ProductsOldDownload>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK-wgoods-products_OldDownload");

                entity.ToTable("products_OldDownload", "wgoods");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("product_id");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("barcode");

                entity.Property(e => e.DaysWarranty30)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("days_warranty_30")
                    .IsFixedLength(true);

                entity.Property(e => e.Defender)
                    .HasMaxLength(1)
                    .HasColumnName("defender")
                    .IsFixedLength(true);

                entity.Property(e => e.Kvi)
                    .HasMaxLength(1)
                    .HasColumnName("kvi")
                    .IsFixedLength(true);

                entity.Property(e => e.KviSubgroup)
                    .HasMaxLength(1)
                    .HasColumnName("kvi_subgroup")
                    .IsFixedLength(true);

                entity.Property(e => e.MaxQty).HasColumnName("max_qty");

                entity.Property(e => e.ProductCode).HasColumnName("product_code");

                entity.Property(e => e.ProductType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("product_type")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.UpdatedTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_timestamp");

                entity.Property(e => e.WarrantyMonths).HasColumnName("warranty_months");
            });

            modelBuilder.Entity<ProductsSubGroupKvi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductsSubGroupKVI", "wgoods");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<Promo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo");

                entity.Property(e => e.AddPeriod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("add_period")
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lang_code");

                entity.Property(e => e.PeriodFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("period_from");

                entity.Property(e => e.PeriodTo)
                    .HasColumnType("datetime")
                    .HasColumnName("period_to");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.PromoId).HasColumnName("promo_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("target")
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<Promo1>(entity =>
            {
                entity.HasKey(e => e.PromoId)
                    .HasName("PK-wgoods-Promo");

                entity.ToTable("Promo", "wgoods");

                entity.Property(e => e.PromoId)
                    .ValueGeneratedNever()
                    .HasColumnName("promo_id");

                entity.Property(e => e.AddPeriod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("add_period")
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("language");

                entity.Property(e => e.PeriodFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("period_from");

                entity.Property(e => e.PeriodTo)
                    .HasColumnType("datetime")
                    .HasColumnName("period_to");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("target")
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<PromoDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_Descriptions");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lang_code")
                    .IsFixedLength(true);

                entity.Property(e => e.Promo)
                    .HasMaxLength(255)
                    .HasColumnName("promo");

                entity.Property(e => e.PromoId).HasColumnName("promo_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PromoDescription1>(entity =>
            {
                entity.HasKey(e => new { e.PromoId, e.LangCode })
                    .HasName("PK-wgoods-Promo_Descriptions");

                entity.ToTable("Promo_Descriptions", "wgoods");

                entity.Property(e => e.PromoId).HasColumnName("promo_id");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(2)
                    .HasColumnName("lang_code")
                    .IsFixedLength(true);

                entity.Property(e => e.Promo)
                    .HasMaxLength(255)
                    .HasColumnName("promo");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PromoDescriptionsNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_Descriptions_New");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lang_code")
                    .IsFixedLength(true);

                entity.Property(e => e.Promo)
                    .HasMaxLength(255)
                    .HasColumnName("promo");

                entity.Property(e => e.PromoId).HasColumnName("promo_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PromoDescriptionsNew1>(entity =>
            {
                entity.HasKey(e => new { e.PromoId, e.LangCode })
                    .HasName("PK-wgoods-Promo_Descriptions_New");

                entity.ToTable("Promo_Descriptions_New", "wgoods");

                entity.Property(e => e.PromoId).HasColumnName("promo_id");

                entity.Property(e => e.LangCode)
                    .HasMaxLength(2)
                    .HasColumnName("lang_code")
                    .IsFixedLength(true);

                entity.Property(e => e.Promo)
                    .HasMaxLength(255)
                    .HasColumnName("promo");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<PromoImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_Images");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.ImageFullpath)
                    .HasMaxLength(320)
                    .HasColumnName("image_fullpath");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageX).HasColumnName("image_x");

                entity.Property(e => e.ImageY).HasColumnName("image_y");
            });

            modelBuilder.Entity<PromoImagesLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_ImagesLinks");

                entity.Property(e => e.DetailedId).HasColumnName("detailed_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("object_type");

                entity.Property(e => e.PairId).HasColumnName("pair_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PromoImagesLinksNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_ImagesLinks_New");

                entity.Property(e => e.DetailedId).HasColumnName("detailed_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectType)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("object_type");

                entity.Property(e => e.PairId).HasColumnName("pair_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PromoImagesNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_Images_New");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.ImageFullpath)
                    .IsRequired()
                    .HasMaxLength(287)
                    .HasColumnName("image_fullpath");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.ImageX).HasColumnName("image_x");

                entity.Property(e => e.ImageY).HasColumnName("image_y");
            });

            modelBuilder.Entity<PromoNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Promo_New");

                entity.Property(e => e.AddPeriod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("add_period")
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lang_code");

                entity.Property(e => e.PeriodFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("period_from");

                entity.Property(e => e.PeriodTo)
                    .HasColumnType("datetime")
                    .HasColumnName("period_to");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.PromoId).HasColumnName("promo_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("target")
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<PromoNew1>(entity =>
            {
                entity.HasKey(e => e.PromoId)
                    .HasName("PK-wgoods-Promo_new");

                entity.ToTable("Promo_New", "wgoods");

                entity.Property(e => e.PromoId)
                    .ValueGeneratedNever()
                    .HasColumnName("promo_id");

                entity.Property(e => e.AddPeriod)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("add_period")
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("language");

                entity.Property(e => e.PeriodFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("period_from");

                entity.Property(e => e.PeriodTo)
                    .HasColumnType("datetime")
                    .HasColumnName("period_to");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Target)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("target")
                    .IsFixedLength(true);

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<PubArticle>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-PubArticles")
                    .IsClustered(false);

                entity.ToTable("PubArticles", "config");

                entity.HasComment("Справочник статей для публикаций");

                entity.HasIndex(e => e.StateId, "IX-config-PubArticles_01");

                entity.HasIndex(e => new { e.PublicationId, e.Id, e.PackNo }, "UIX-config-PubArticles_00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Schema, e.Table }, "UK-config-PubArticles-Schema_Table")
                    .IsUnique();

                entity.HasIndex(e => new { e.PublicationId, e.Rate, e.Id }, "СIX-config-PubArticles")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.LastSyncNo).HasComment("Значение последней полученной версии");

                entity.Property(e => e.PackNo).HasComment("Счетчик опубликованных пакетов данных");

                entity.Property(e => e.PublicationId)
                    .HasColumnName("PublicationID")
                    .HasComment("Ссылка на справочник \"Публикации\"");

                entity.Property(e => e.Rate).HasComment("Порядок обработки статей");

                entity.Property(e => e.Schema)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Схема таблицы");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Таблица");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.PubArticles)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-PubArticles_PublicationID_config-Publications");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PubArticles)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-PubArticles_StateID_config-States");
            });

            modelBuilder.Entity<Publication>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-Publications")
                    .IsClustered(false);

                entity.ToTable("Publications", "config");

                entity.HasComment("Справочник публикаций");

                entity.HasIndex(e => e.StateId, "IX-config-Publications_01");

                entity.HasIndex(e => new { e.PublisherId, e.Id, e.PackNo }, "UIX-config-Publications_00")
                    .IsUnique();

                entity.HasIndex(e => e.Description, "UK-config-Publications-Description")
                    .IsUnique();

                entity.HasIndex(e => e.Schema, "UK-config-Publications-Schema")
                    .IsUnique();

                entity.HasIndex(e => new { e.PublisherId, e.Id }, "СIX-config-Publications")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("Описание");

                entity.Property(e => e.Fg)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("FG")
                    .HasComment("Файловая группа для хранения данных статей публикаций");

                entity.Property(e => e.LastEvent)
                    .HasColumnType("datetime")
                    .HasComment("Время последнего обмена");

                entity.Property(e => e.PackNo).HasComment("Счетчик опубликованных пакетов данных");

                entity.Property(e => e.PublisherId)
                    .HasColumnName("PublisherID")
                    .HasComment("Ссылка на справочник \"Издатели\"");

                entity.Property(e => e.Schema)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Схема для хранения данных статей публикаций");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Publications)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Publications_PublisherID-config_Publishers");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Publications)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Publications_StateID-config_States");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-Publishers")
                    .IsClustered(false);

                entity.ToTable("Publishers", "config");

                entity.HasComment("Справочник издателей публикаций");

                entity.HasIndex(e => e.Description, "UK-config-Publishers-Description")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные издателя");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("Описание издателя");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные издателя");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные издателя");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные издателя");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Publishers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Publishers_StateID-config_States");
            });

            modelBuilder.Entity<Rem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Rems");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Qty).HasColumnType("numeric(38, 9)");

                entity.Property(e => e.StockId).HasColumnName("StockID");
            });

            modelBuilder.Entity<RequestInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestInfo");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ExternalPrice).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StockLatitude).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.StockLongitude).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.TokenId)
                    .HasMaxLength(10)
                    .HasColumnName("TokenID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Sales");

                entity.Property(e => e.CardId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.StockId).HasColumnName("StockID");

                entity.Property(e => e.SumWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Sum_WT");
            });

            modelBuilder.Entity<Sale1>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("PK-replica-Sales")
                    .IsClustered(false);

                entity.ToTable("Sales", "replica");

                entity.HasIndex(e => new { e.CardId, e.DocDate, e.DocId }, "CIDX-replica-Sales")
                    .IsClustered();

                entity.HasIndex(e => new { e.StockId, e.DocDate }, "IDX-replica-Sales-00");

                entity.Property(e => e.ChId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.StockId).HasColumnName("StockID");

                entity.Property(e => e.SumWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Sum_WT");
            });

            modelBuilder.Entity<Sale2>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("PK-temp-Sales")
                    .IsClustered(false);

                entity.ToTable("Sales", "temp");

                entity.HasIndex(e => new { e.CardId, e.DocDate, e.DocId }, "CIDX-temp-Sale")
                    .IsClustered();

                entity.Property(e => e.ChId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChID");

                entity.Property(e => e.CardId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CardID");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.StockId).HasColumnName("StockID");

                entity.Property(e => e.SumWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Sum_WT");
            });

            modelBuilder.Entity<SaleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SaleDetails");

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PriceWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Price_WT");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.SumWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Sum_WT");
            });

            modelBuilder.Entity<SaleDetail1>(entity =>
            {
                entity.HasKey(e => new { e.ChId, e.PosId })
                    .HasName("PK-replica-SaleDetails")
                    .IsClustered(false);

                entity.ToTable("SaleDetails", "replica");

                entity.HasIndex(e => new { e.ChId, e.PosId }, "CIDX-replica-SaleDetails")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PriceWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Price_WT");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.SumWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Sum_WT");
            });

            modelBuilder.Entity<SaleDetail2>(entity =>
            {
                entity.HasKey(e => new { e.ChId, e.PosId })
                    .HasName("PK-temp-SaleDetails")
                    .IsClustered(false);

                entity.ToTable("SaleDetails", "temp");

                entity.HasIndex(e => new { e.ChId, e.PosId }, "CIDX-tempSaleDetails")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.PosId).HasColumnName("PosID");

                entity.Property(e => e.PriceWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Price_WT");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.SumWt)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("Sum_WT");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Settings", "mobile");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Tag).HasMaxLength(255);

                entity.Property(e => e.Value).HasColumnType("sql_variant");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Shops");

                entity.Property(e => e.BarcodeExp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeRec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChId).HasColumnName("ChID");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GeoDistance).HasColumnName("geo_distance");

                entity.Property(e => e.GeoDistanceMsg)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("geo_distance_msg");

                entity.Property(e => e.GeoX)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("geo_x");

                entity.Property(e => e.GeoY)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("geo_y");

                entity.Property(e => e.StockId).HasColumnName("StockID");
            });

            modelBuilder.Entity<Shop1>(entity =>
            {
                entity.HasKey(e => e.ChId)
                    .HasName("pk_ir_Shops")
                    .IsClustered(false);

                entity.ToTable("Shops", "replica");

                entity.HasIndex(e => e.StockId, "UIDX-replica-Shops")
                    .IsUnique();

                entity.Property(e => e.ChId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChID");

                entity.Property(e => e.BarcodeExp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeRec)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GeoDistance).HasColumnName("geo_distance");

                entity.Property(e => e.GeoDistanceMsg)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("geo_distance_msg");

                entity.Property(e => e.GeoX)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("geo_x");

                entity.Property(e => e.GeoY)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("geo_y");

                entity.Property(e => e.StockId).HasColumnName("StockID");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-States")
                    .IsClustered(false);

                entity.ToTable("States", "config");

                entity.HasComment("Справочник состояний");

                entity.HasIndex(e => e.Description, "UK-config-States-Description")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasComment("Описание издателя");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(e => e.StockId)
                    .ValueGeneratedNever()
                    .HasColumnName("StockID");

                entity.Property(e => e.Plid).HasColumnName("PLID");

                entity.Property(e => e.StockAdress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StockLatitude).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.StockLongitude).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.StockName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stock1>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("pk_r_Stocks");

                entity.ToTable("Stocks", "replica");

                entity.Property(e => e.StockId)
                    .ValueGeneratedNever()
                    .HasColumnName("StockID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FormatTtid).HasColumnName("FormatTTID");

                entity.Property(e => e.LimitNeed).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.LimitPpe)
                    .HasColumnType("numeric(21, 9)")
                    .HasColumnName("LimitPPE");

                entity.Property(e => e.Plid).HasColumnName("PLID");

                entity.Property(e => e.Rmempid).HasColumnName("RMempid");

                entity.Property(e => e.StockName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tmempid).HasColumnName("TMempid");
            });

            modelBuilder.Entity<StockArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("StockAreas");

                entity.Property(e => e.Area).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.StockId).HasColumnName("StockID");
            });

            modelBuilder.Entity<StockArea1>(entity =>
            {
                entity.HasKey(e => e.StockId)
                    .HasName("pk_ir_StockArenda")
                    .IsClustered(false);

                entity.ToTable("StockAreas", "replica");

                entity.Property(e => e.StockId)
                    .ValueGeneratedNever()
                    .HasColumnName("StockID");

                entity.Property(e => e.QtyArendArea).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.ToTable("StoreLocations", "wgoods");

                entity.Property(e => e.StoreLocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("store_location_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(256)
                    .HasColumnName("address");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .HasColumnName("country")
                    .IsFixedLength(true);

                entity.Property(e => e.DangerLevel)
                    .HasMaxLength(1)
                    .HasColumnName("danger_level")
                    .IsFixedLength(true);

                entity.Property(e => e.ExternalId).HasColumnName("external_id");

                entity.Property(e => e.HideOnMob)
                    .HasMaxLength(1)
                    .HasColumnName("hide_on_mob")
                    .IsFixedLength(true);

                entity.Property(e => e.Latitude)
                    .HasColumnType("numeric(32, 29)")
                    .HasColumnName("latitude");

                entity.Property(e => e.Localization)
                    .HasMaxLength(255)
                    .HasColumnName("localization");

                entity.Property(e => e.Longitude)
                    .HasColumnType("numeric(32, 29)")
                    .HasColumnName("longitude");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDelivery)
                    .HasMaxLength(1)
                    .HasColumnName("status_delivery")
                    .IsFixedLength(true);

                entity.Property(e => e.StatusWork)
                    .HasMaxLength(1)
                    .HasColumnName("status_work")
                    .IsFixedLength(true);

                entity.Property(e => e.StockId).HasColumnName("stock_id");

                entity.Property(e => e.Timework)
                    .HasMaxLength(32)
                    .HasColumnName("timework");
            });

            modelBuilder.Entity<StoreLocationsOldDownload>(entity =>
            {
                entity.HasKey(e => e.StoreLocationId)
                    .HasName("PK-wgoods-StoreLocations_OldDownload");

                entity.ToTable("StoreLocations_OldDownload", "wgoods");

                entity.Property(e => e.StoreLocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("store_location_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(256)
                    .HasColumnName("address");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .HasColumnName("country")
                    .IsFixedLength(true);

                entity.Property(e => e.ExternalId).HasColumnName("external_id");

                entity.Property(e => e.HideOnMob)
                    .HasMaxLength(1)
                    .HasColumnName("hide_on_mob")
                    .IsFixedLength(true);

                entity.Property(e => e.Latitude)
                    .HasColumnType("numeric(32, 29)")
                    .HasColumnName("latitude");

                entity.Property(e => e.Localization)
                    .HasMaxLength(255)
                    .HasColumnName("localization");

                entity.Property(e => e.Longitude)
                    .HasColumnType("numeric(32, 29)")
                    .HasColumnName("longitude");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.StockId).HasColumnName("stock_id");

                entity.Property(e => e.Timework)
                    .HasMaxLength(32)
                    .HasColumnName("timework");
            });

            modelBuilder.Entity<SubArticle>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config_SubArticles")
                    .IsClustered(false);

                entity.ToTable("SubArticles", "config");

                entity.HasComment("Справочник статей для подписчиков");

                entity.HasIndex(e => e.PubArticleId, "IX-config-SubArticles_01");

                entity.HasIndex(e => e.StateId, "IX-config-SubArticles_02");

                entity.HasIndex(e => new { e.SubscriptionId, e.Id, e.PackNo }, "UIX-config-SubArticles_00")
                    .IsUnique();

                entity.HasIndex(e => new { e.Schema, e.Table }, "UK-config-SubArticles-Schema_Table")
                    .IsUnique();

                entity.HasIndex(e => new { e.SubscriptionId, e.Rate, e.Id }, "СIX-config-SubArticles")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.LastSyncNo).HasComment("Значение последней полученной версии");

                entity.Property(e => e.PackNo).HasComment("Номер пакета данных");

                entity.Property(e => e.PubArticleId)
                    .HasColumnName("PubArticleID")
                    .HasComment("Ссылка на справочник \"Статьи публикации\"");

                entity.Property(e => e.Rate).HasComment("Порядок обработки статей");

                entity.Property(e => e.Schema)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Схема таблицы назначения");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.Property(e => e.SubscriptionId)
                    .HasColumnName("SubscriptionID")
                    .HasComment("Ссылка на справочник \"Подписчики\"");

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Таблица назначения");

                entity.HasOne(d => d.PubArticle)
                    .WithMany(p => p.SubArticles)
                    .HasForeignKey(d => d.PubArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config_SubArticles_PubArticleID-config_PubArticles");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SubArticles)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config_SubArticles_StateID-config_States");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubArticles)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config_SubArticles_SubscriptionID-config_Subscriptions");
            });

            modelBuilder.Entity<SubEventHistory>(entity =>
            {
                entity.HasKey(e => new { e.SubArticleId, e.ToPackNo, e.EventDate, e.EventTime })
                    .HasName("PK-log-SubEventHistory");

                entity.ToTable("SubEventHistory", "log");

                entity.HasComment("Журнал подписок");

                entity.HasIndex(e => new { e.SubArticleId, e.ToPackNo }, "IX-log-SubEventHistory_00");

                entity.Property(e => e.SubArticleId)
                    .HasColumnName("SubArticleID")
                    .HasComment("Статья подписки");

                entity.Property(e => e.ToPackNo).HasComment("Последний в обработке порядковый номер пакета публикации");

                entity.Property(e => e.EventDate)
                    .HasColumnType("date")
                    .HasComment("Дата события");

                entity.Property(e => e.EventTime).HasComment("Время события");

                entity.Property(e => e.ElapsedTime).HasComment("Время затраченное на процесс переноса данных");

                entity.Property(e => e.FromPackNo).HasComment("Первый в обработке порядковый номер пакета публикации");

                entity.Property(e => e.FromVersion).HasComment("Первая версия в обработанных пакетах");

                entity.Property(e => e.Rows).HasComment("Выгруженно строк");

                entity.Property(e => e.ToVersion).HasComment("Конечная версия в обработанных пакетах");

                entity.HasOne(d => d.SubArticle)
                    .WithMany(p => p.SubEventHistories)
                    .HasForeignKey(d => d.SubArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-log-SubEventHistory_SubArticleID_config-SubArticles");
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-Subscribers")
                    .IsClustered(false);

                entity.ToTable("Subscribers", "config");

                entity.HasComment("Справочник подписчиков");

                entity.HasIndex(e => e.StateId, "IX-config-Subscribers_01");

                entity.HasIndex(e => e.DistributorId, "IX-config-Subscribers_02");

                entity.HasIndex(e => e.Description, "UK-config-Subscribers-Description")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.Database)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные подписчика");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("Описание подписчика");

                entity.Property(e => e.DistributorId)
                    .HasColumnName("DistributorID")
                    .HasComment("Ссылка на используемую для транзита базу распределителя");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные подписчика");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные подписчика");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Данные подписчика");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsFixedLength(true)
                    .HasComment("Тип обмена с подписчиком");

                entity.HasOne(d => d.Distributor)
                    .WithMany(p => p.Subscribers)
                    .HasForeignKey(d => d.DistributorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Subscribers-DistributorID_config-Distributors");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Subscribers)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Subscribers_StateID-config_States");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK-config-Subscriptions")
                    .IsClustered(false);

                entity.ToTable("Subscriptions", "config");

                entity.HasComment("Справочник подписок");

                entity.HasIndex(e => e.StateId, "IX-config-Subscriptions_01");

                entity.HasIndex(e => e.PublicationId, "IX-config-Subscriptions_02");

                entity.HasIndex(e => new { e.SubscriberId, e.Id, e.PackNo }, "UIX-config-Subscriptions_00")
                    .IsUnique();

                entity.HasIndex(e => e.Description, "UK-config-Subscriptions-Description")
                    .IsUnique();

                entity.HasIndex(e => e.Schema, "UK-config-Subscriptions-Schema")
                    .IsUnique();

                entity.HasIndex(e => new { e.SubscriberId, e.Id }, "СIX-config-Subscriptions")
                    .IsClustered();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("Идентификатор");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasComment("Описание");

                entity.Property(e => e.Fg)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("FG")
                    .HasComment("Файловая группа для хранения данных статей полученных по подписке");

                entity.Property(e => e.LastEvent)
                    .HasColumnType("datetime")
                    .HasComment("Время последнего обмена");

                entity.Property(e => e.PublicationId)
                    .HasColumnName("PublicationID")
                    .HasComment("Ссылка на справочник \"Публикации\"");

                entity.Property(e => e.Schema)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("Схема хранения полученных по подписке");

                entity.Property(e => e.StateId)
                    .HasColumnName("StateID")
                    .HasComment("Ссылка на справочник \"Состояния\"");

                entity.Property(e => e.SubscriberId)
                    .HasColumnName("SubscriberID")
                    .HasComment("Ссылка на справочник \"Подписчики\"");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.PublicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Subscriptions_PublicationID-config_Publications");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Subscriptions_StateID-config_States");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.SubscriberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK-config-Subscriptions_SubscriberID-config_Subscribers");
            });

            modelBuilder.Entity<TRem>(entity =>
            {
                entity.HasKey(e => new { e.OurId, e.StockId, e.SecId, e.ProdId, e.Ppid })
                    .HasName("PK-replica-t_Rem");

                entity.ToTable("t_Rem", "replica");

                entity.HasIndex(e => e.ProdId, "IDX-replica-t_Rems-ProdID-Include-01");

                entity.HasIndex(e => new { e.ProdId, e.StockId }, "IDX-replica-t_Rems-ProdID-Include-02");

                entity.HasIndex(e => new { e.StockId, e.ProdId }, "IDX-replica-t_Rems-StockProdQty");

                entity.Property(e => e.OurId).HasColumnName("OurID");

                entity.Property(e => e.StockId).HasColumnName("StockID");

                entity.Property(e => e.SecId).HasColumnName("SecID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Ppid).HasColumnName("PPID");

                entity.Property(e => e.AccQty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<TagState>(entity =>
            {
                entity.HasKey(e => new { e.ForInstrument, e.Id })
                    .HasName("PK_gms_TagStates");

                entity.ToTable("TagStates", "gms");

                entity.Property(e => e.ForInstrument)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.ToTable("Tokens", "gmstest");

                entity.Property(e => e.TokenId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Token1>(entity =>
            {
                entity.HasKey(e => e.TokenId);

                entity.ToTable("Tokens", "mobile");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.InstanceGuid).HasColumnName("InstanceGUID");
            });

            modelBuilder.Entity<TokenBinding>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK_bind_TokenStockBindings");

                entity.ToTable("TokenBindings", "bind");

                entity.Property(e => e.TokenId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TokenBinding1>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.StockId })
                    .HasName("PK_gms_TokenBindings");

                entity.ToTable("TokenBindings", "gms");
            });

            modelBuilder.Entity<TokenBindingsOld>(entity =>
            {
                entity.HasKey(e => e.TokenId)
                    .HasName("PK_TokenStockBindings");

                entity.ToTable("TokenBindingsOld", "mobile");

                entity.Property(e => e.TokenId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TokenPosBinding>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.StockId })
                    .HasName("PK_bind_TokenPosBindings");

                entity.ToTable("TokenPosBindings", "bind");
            });

            modelBuilder.Entity<TokenQtyBinding>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.StockId })
                    .HasName("PK_bind_TokenQtyBindings");

                entity.ToTable("TokenQtyBindings", "bind");
            });

            modelBuilder.Entity<TokenQtyBindingsOld>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.StockId })
                    .HasName("PK_TokenQtyBindings");

                entity.ToTable("TokenQtyBindingsOld", "mobile");
            });

            modelBuilder.Entity<TokenRight>(entity =>
            {
                entity.ToTable("TokenRights", "gms");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<TokenStoreBinding>(entity =>
            {
                entity.HasKey(e => new { e.TokenId, e.StockId })
                    .HasName("PK_bind_TokenStoreBindings");

                entity.ToTable("TokenStoreBindings", "bind");
            });

            modelBuilder.Entity<TokenStoreRight>(entity =>
            {
                entity.ToTable("TokenStoreRights", "bind");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(64);
            });

            modelBuilder.Entity<Entities.Mobile.Version>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Versions", "mobile");

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.TokenId });

                entity.ToTable("WishList", "mobile");

                entity.HasIndex(e => new { e.TokenId, e.ProdId }, "IX-mobile-Wishlist");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");
            });

            modelBuilder.Entity<WriteOff>(entity =>
            {
                entity.ToTable("WriteOffs", "gms");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFinished).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WriteOff1>(entity =>
            {
                entity.ToTable("WriteOffs", "gmstest");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFinished).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WriteOffGood>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProdId })
                    .HasName("PK_gms_WriteOffGoods");

                entity.ToTable("WriteOffGoods", "gms");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Um)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            modelBuilder.Entity<WriteOffGood1>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProdId })
                    .HasName("PK_gmstest_WriteOffGoods");

                entity.ToTable("WriteOffGoods", "gmstest");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("numeric(21, 9)");

                entity.Property(e => e.Um)
                    .HasMaxLength(42)
                    .IsUnicode(false)
                    .HasColumnName("UM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
