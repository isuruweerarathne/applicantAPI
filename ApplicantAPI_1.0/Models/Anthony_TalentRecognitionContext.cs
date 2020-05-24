using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApplicantAPI_1._0.Models
{
    public partial class Anthony_TalentRecognitionContext : DbContext
    {
        public Anthony_TalentRecognitionContext()
        {
        }

        public Anthony_TalentRecognitionContext(DbContextOptions<Anthony_TalentRecognitionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCommissionAgents> AccountCommissionAgents { get; set; }
        public virtual DbSet<AccountContractDuration> AccountContractDuration { get; set; }
        public virtual DbSet<AccountContractRenew> AccountContractRenew { get; set; }
        public virtual DbSet<AccountNumberCounter> AccountNumberCounter { get; set; }
        public virtual DbSet<AccountPaymentCc> AccountPaymentCc { get; set; }
        public virtual DbSet<AccountPaymentDd> AccountPaymentDd { get; set; }
        public virtual DbSet<AccountSectorType> AccountSectorType { get; set; }
        public virtual DbSet<AccountSetUp> AccountSetUp { get; set; }
        public virtual DbSet<AccountSuspendReact> AccountSuspendReact { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<BfmMbtimaster> BfmMbtimaster { get; set; }
        public virtual DbSet<BfmMbtiroles> BfmMbtiroles { get; set; }
        public virtual DbSet<BfmresponsAnalyse> BfmresponsAnalyse { get; set; }
        public virtual DbSet<Bfmresponse> Bfmresponse { get; set; }
        public virtual DbSet<BillingClass> BillingClass { get; set; }
        public virtual DbSet<BillingRatePlans> BillingRatePlans { get; set; }
        public virtual DbSet<BillingRateTable> BillingRateTable { get; set; }
        public virtual DbSet<BillingType> BillingType { get; set; }
        public virtual DbSet<CampaignApiResponse> CampaignApiResponse { get; set; }
        public virtual DbSet<CampaignApiresponseAnalyse> CampaignApiresponseAnalyse { get; set; }
        public virtual DbSet<CampaignApplicantPayg> CampaignApplicantPayg { get; set; }
        public virtual DbSet<CampaignCampaignMaster> CampaignCampaignMaster { get; set; }
        public virtual DbSet<CampaignRepPrint> CampaignRepPrint { get; set; }
        public virtual DbSet<CampaignReportPrint> CampaignReportPrint { get; set; }
        public virtual DbSet<CampaignRoleBySector> CampaignRoleBySector { get; set; }
        public virtual DbSet<CampaignSourceSelection> CampaignSourceSelection { get; set; }
        public virtual DbSet<CampaignSourceSelectionMbti> CampaignSourceSelectionMbti { get; set; }
        public virtual DbSet<ConResp> ConResp { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactNew> ContactNew { get; set; }
        public virtual DbSet<ContactRequest> ContactRequest { get; set; }
        public virtual DbSet<EmailMatch> EmailMatch { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<PasswordNumbers> PasswordNumbers { get; set; }
        public virtual DbSet<PositionType> PositionType { get; set; }
        public virtual DbSet<PsyScales> PsyScales { get; set; }
        public virtual DbSet<RepPrint> RepPrint { get; set; }
        public virtual DbSet<ReportMbti> ReportMbti { get; set; }
        public virtual DbSet<ReportMbtisolo> ReportMbtisolo { get; set; }
        public virtual DbSet<ReportPrint> ReportPrint { get; set; }
        public virtual DbSet<ReportScalesContent> ReportScalesContent { get; set; }
        public virtual DbSet<ReportScalesContentOrig> ReportScalesContentOrig { get; set; }
        public virtual DbSet<SalesCommissionAgent> SalesCommissionAgent { get; set; }
        public virtual DbSet<SecurityLevels> SecurityLevels { get; set; }
        public virtual DbSet<SlAllocations> SlAllocations { get; set; }
        public virtual DbSet<SlCreditNote> SlCreditNote { get; set; }
        public virtual DbSet<SlDebit> SlDebit { get; set; }
        public virtual DbSet<SlInvoiceDetail> SlInvoiceDetail { get; set; }
        public virtual DbSet<SlInvoiceSummary> SlInvoiceSummary { get; set; }
        public virtual DbSet<SlPaymentReturned> SlPaymentReturned { get; set; }
        public virtual DbSet<SlPayments> SlPayments { get; set; }
        public virtual DbSet<SlSalesCommissionRate> SlSalesCommissionRate { get; set; }
        public virtual DbSet<SlSalesLedger> SlSalesLedger { get; set; }
        public virtual DbSet<SlVatrates> SlVatrates { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TrTestInvite> TrTestInvite { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<UserLogType> UserLogType { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<UserValidation> UserValidation { get; set; }
        public virtual DbSet<UserValidationDepartments> UserValidationDepartments { get; set; }
        public virtual DbSet<VAccountGen> VAccountGen { get; set; }
        public virtual DbSet<VAccountSetUpEmailCredentials> VAccountSetUpEmailCredentials { get; set; }
        public virtual DbSet<VAnalyseFullyRanked> VAnalyseFullyRanked { get; set; }
        public virtual DbSet<VAnalyseMaxBfmresponse> VAnalyseMaxBfmresponse { get; set; }
        public virtual DbSet<VAnalyseMaxResponse> VAnalyseMaxResponse { get; set; }
        public virtual DbSet<VAnalyseUnPivotPlong> VAnalyseUnPivotPlong { get; set; }
        public virtual DbSet<VAnalyseUnPivotPshort> VAnalyseUnPivotPshort { get; set; }
        public virtual DbSet<VAnalyseUnPivotScaleForRank> VAnalyseUnPivotScaleForRank { get; set; }
        public virtual DbSet<VApplicantDashQtyApp> VApplicantDashQtyApp { get; set; }
        public virtual DbSet<VApplicantFormFieldPop> VApplicantFormFieldPop { get; set; }
        public virtual DbSet<VBillingAmendRatePlan> VBillingAmendRatePlan { get; set; }
        public virtual DbSet<VBillingClassByType> VBillingClassByType { get; set; }
        public virtual DbSet<VBillingNewRates> VBillingNewRates { get; set; }
        public virtual DbSet<VCampaignActive> VCampaignActive { get; set; }
        public virtual DbSet<VCampaignAnalyseFullyRanked> VCampaignAnalyseFullyRanked { get; set; }
        public virtual DbSet<VCampaignAnalyseMaxApiresponse> VCampaignAnalyseMaxApiresponse { get; set; }
        public virtual DbSet<VCampaignAnalyseMaxResponse> VCampaignAnalyseMaxResponse { get; set; }
        public virtual DbSet<VCampaignAnalyseUnPivotPlong> VCampaignAnalyseUnPivotPlong { get; set; }
        public virtual DbSet<VCampaignAnalyseUnPivotPshort> VCampaignAnalyseUnPivotPshort { get; set; }
        public virtual DbSet<VCampaignAnalyseUnPivotScaleForRank> VCampaignAnalyseUnPivotScaleForRank { get; set; }
        public virtual DbSet<VCampaignApplicantDash> VCampaignApplicantDash { get; set; }
        public virtual DbSet<VCampaignCampaignDash> VCampaignCampaignDash { get; set; }
        public virtual DbSet<VCampaignMasterRoles> VCampaignMasterRoles { get; set; }
        public virtual DbSet<VCampaignMasterSectorType> VCampaignMasterSectorType { get; set; }
        public virtual DbSet<VCampaignMbtiMaxScale> VCampaignMbtiMaxScale { get; set; }
        public virtual DbSet<VCampaignMbtiScalesByValue> VCampaignMbtiScalesByValue { get; set; }
        public virtual DbSet<VCampaignQtyApplicant> VCampaignQtyApplicant { get; set; }
        public virtual DbSet<VCampaignReportPrintLastSerial> VCampaignReportPrintLastSerial { get; set; }
        public virtual DbSet<VCampaignRoleBySectorType> VCampaignRoleBySectorType { get; set; }
        public virtual DbSet<VCampaignRoleName> VCampaignRoleName { get; set; }
        public virtual DbSet<VCampaignRoleSelected> VCampaignRoleSelected { get; set; }
        public virtual DbSet<VCampaignRolesMinId> VCampaignRolesMinId { get; set; }
        public virtual DbSet<VCampaignRolesOverlap> VCampaignRolesOverlap { get; set; }
        public virtual DbSet<VCampaignSelectNameInd> VCampaignSelectNameInd { get; set; }
        public virtual DbSet<VCampaignStringAggSuggMbti> VCampaignStringAggSuggMbti { get; set; }
        public virtual DbSet<VCampaignUnPivotMbtiresponse> VCampaignUnPivotMbtiresponse { get; set; }
        public virtual DbSet<VCampaignUserAuth> VCampaignUserAuth { get; set; }
        public virtual DbSet<VCampaignUserAuthDisp> VCampaignUserAuthDisp { get; set; }
        public virtual DbSet<VCurrentTestId> VCurrentTestId { get; set; }
        public virtual DbSet<VDept1> VDept1 { get; set; }
        public virtual DbSet<VDept10> VDept10 { get; set; }
        public virtual DbSet<VDept2> VDept2 { get; set; }
        public virtual DbSet<VDept3> VDept3 { get; set; }
        public virtual DbSet<VDept4> VDept4 { get; set; }
        public virtual DbSet<VDept5> VDept5 { get; set; }
        public virtual DbSet<VDept6> VDept6 { get; set; }
        public virtual DbSet<VDept7> VDept7 { get; set; }
        public virtual DbSet<VDept8> VDept8 { get; set; }
        public virtual DbSet<VDept9> VDept9 { get; set; }
        public virtual DbSet<VMatchEmailsCurrentLogin> VMatchEmailsCurrentLogin { get; set; }
        public virtual DbSet<VMbtiMaxScale> VMbtiMaxScale { get; set; }
        public virtual DbSet<VMbtiScalesByValue> VMbtiScalesByValue { get; set; }
        public virtual DbSet<VMonitorTestInvite> VMonitorTestInvite { get; set; }
        public virtual DbSet<VRanCharNoSym> VRanCharNoSym { get; set; }
        public virtual DbSet<VRandHelper> VRandHelper { get; set; }
        public virtual DbSet<VRandNumGen> VRandNumGen { get; set; }
        public virtual DbSet<VRandomCharGenerator> VRandomCharGenerator { get; set; }
        public virtual DbSet<VSlAllocNextAlloc> VSlAllocNextAlloc { get; set; }
        public virtual DbSet<VSlAllocQtyAlloc> VSlAllocQtyAlloc { get; set; }
        public virtual DbSet<VSlAllocationTrans> VSlAllocationTrans { get; set; }
        public virtual DbSet<VSlBalance> VSlBalance { get; set; }
        public virtual DbSet<VSlCredits> VSlCredits { get; set; }
        public virtual DbSet<VSlDebits> VSlDebits { get; set; }
        public virtual DbSet<VSlRunningBalance> VSlRunningBalance { get; set; }
        public virtual DbSet<VSlToBeInvoiced> VSlToBeInvoiced { get; set; }
        public virtual DbSet<VSv> VSv { get; set; }
        public virtual DbSet<VSystemProcsAndFunctions> VSystemProcsAndFunctions { get; set; }
        public virtual DbSet<VSystemTablesAndViews> VSystemTablesAndViews { get; set; }
        public virtual DbSet<VUnPivotMbtiresponse> VUnPivotMbtiresponse { get; set; }
        public virtual DbSet<VUserVal> VUserVal { get; set; }
        public virtual DbSet<VUserValidationLog> VUserValidationLog { get; set; }
        public virtual DbSet<VValVarNoDups> VValVarNoDups { get; set; }
        public virtual DbSet<ValVarDupMin> ValVarDupMin { get; set; }
        public virtual DbSet<ValidationVariable> ValidationVariable { get; set; }
        public virtual DbSet<Years> Years { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=mssql7.websitelive.net;
Database=Anthony_TalentRecognition;
Persist Security Info=False;
User ID=Anthony_Isuru;Password=Tal5nt_1suru;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "Anthony_Isuru");

            modelBuilder.Entity<AccountCommissionAgents>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountCommissionAgents", "Anthony_TRMaster");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CommissionRate).HasColumnType("money");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeReference).HasMaxLength(50);

                entity.Property(e => e.MasterAgentId)
                    .HasColumnName("MasterAgentID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OverideRateToMasterAgent)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.SalesAgentId)
                    .HasColumnName("SalesAgent_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesAgentName).HasMaxLength(150);

                entity.Property(e => e.UserName).HasMaxLength(150);

                entity.Property(e => e.VatregNo)
                    .HasColumnName("VATRegNo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountContractDuration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountContractDuration", "Anthony_TRMaster");

                entity.Property(e => e.ContractDurationId)
                    .HasColumnName("ContractDurationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descr).HasMaxLength(50);
            });

            modelBuilder.Entity<AccountContractRenew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountContractRenew", "Anthony_TRMaster");

                entity.Property(e => e.AccountNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractDuration).HasDefaultValueSql("((1))");

                entity.Property(e => e.ContractRenewId)
                    .HasColumnName("ContractRenew_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateExistingContractEnds).HasColumnType("date");

                entity.Property(e => e.DateNewContractStarts).HasColumnType("date");

                entity.Property(e => e.DateNewContractStartsTxt).HasMaxLength(50);

                entity.Property(e => e.ExistingRatePlan).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountNumberCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountNumberCounter", "Anthony_TRMaster");

                entity.Property(e => e.AccEnqInd).HasColumnName("AccEnq_Ind");

                entity.Property(e => e.AccountNumberCounter1)
                    .HasColumnName("AccountNumberCounter")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountPaymentCc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountPaymentCC", "Anthony_TRMaster");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.AmendSesVar).HasMaxLength(50);

                entity.Property(e => e.CardAdd2).HasMaxLength(50);

                entity.Property(e => e.CardAddr1).HasMaxLength(50);

                entity.Property(e => e.CardCty).HasMaxLength(50);

                entity.Property(e => e.CardPcode)
                    .HasColumnName("CardPCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CardValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.CcId)
                    .HasColumnName("CC_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CcardName)
                    .HasColumnName("CCardName")
                    .HasMaxLength(50);

                entity.Property(e => e.Ccnumber)
                    .HasColumnName("CCNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckSum).HasDefaultValueSql("((0))");

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cvc)
                    .HasColumnName("CVC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cvctxt)
                    .HasColumnName("CVCTxt")
                    .HasMaxLength(50);

                entity.Property(e => e.DateValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debit).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnqInd)
                    .HasColumnName("Enq_Ind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.ExpiryMm)
                    .HasColumnName("Expiry_MM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpiryTxt).HasMaxLength(50);

                entity.Property(e => e.ExpiryYy)
                    .HasColumnName("Expiry_YY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewSesVar).HasMaxLength(50);

                entity.Property(e => e.PayMethodValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.SameAddress).HasDefaultValueSql("((0))");

                entity.Property(e => e.System).HasMaxLength(50);
            });

            modelBuilder.Entity<AccountPaymentDd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountPaymentDD", "Anthony_TRMaster");

                entity.Property(e => e.AccountId).HasColumnName("Account_ID");

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AmendSesVar).HasMaxLength(50);

                entity.Property(e => e.BankAccountName).HasMaxLength(150);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.BankAddr1).HasMaxLength(50);

                entity.Property(e => e.BankCity).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BankPcode)
                    .HasColumnName("BankPCode")
                    .HasMaxLength(50);

                entity.Property(e => e.DdId)
                    .HasColumnName("DD_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DdmandateRef)
                    .HasColumnName("DDMandateREf")
                    .HasMaxLength(50);

                entity.Property(e => e.EnqInd)
                    .HasColumnName("Enq_Ind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewSesVar).HasMaxLength(50);

                entity.Property(e => e.PayMethodValid).HasDefaultValueSql("((0))");

                entity.Property(e => e.SigDate).HasColumnType("date");

                entity.Property(e => e.SignatureName).HasMaxLength(150);

                entity.Property(e => e.SortCode).HasMaxLength(50);

                entity.Property(e => e.ValidAccount).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AccountSectorType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountSectorType", "Anthony_TRMaster");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.SectorId)
                    .HasColumnName("Sector_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountSetUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountSetUp", "Anthony_TRMaster");

                entity.Property(e => e.AccountContactEmail).HasMaxLength(150);

                entity.Property(e => e.AccountContactName).HasMaxLength(150);

                entity.Property(e => e.AccountContactTelNo).HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountTelNo).HasMaxLength(50);

                entity.Property(e => e.Addr1).HasMaxLength(50);

                entity.Property(e => e.Addr2).HasMaxLength(50);

                entity.Property(e => e.AmendSesVar).HasMaxLength(50);

                entity.Property(e => e.BillingClass).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChangePayMethod).HasDefaultValueSql("((0))");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CoReg).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.ContactDuration).HasDefaultValueSql("((1))");

                entity.Property(e => e.ContractRenewalDate).HasColumnType("date");

                entity.Property(e => e.CreditCard).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditLimit).HasDefaultValueSql("((350))");

                entity.Property(e => e.DateClosed).HasColumnType("datetime");

                entity.Property(e => e.DateSigned)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DirectDebit).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnqInd)
                    .HasColumnName("Enq_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NewSesVar).HasMaxLength(50);

                entity.Property(e => e.NoOfEmployees).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(50);

                entity.Property(e => e.RatePlanDateEnd).HasColumnType("date");

                entity.Property(e => e.RatePlanDateStart)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesContactEmail).HasMaxLength(150);

                entity.Property(e => e.SalesContactName).HasMaxLength(150);

                entity.Property(e => e.SalesContactTelNo).HasMaxLength(50);

                entity.Property(e => e.SectorType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserValidInd).HasColumnName("UserValid_Ind");

                entity.Property(e => e.VatReg).HasMaxLength(50);

                entity.Property(e => e.Vatrate)
                    .HasColumnName("VATRate")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccountSuspendReact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account_SuspendReact", "Anthony_TRMaster");

                entity.Property(e => e.AccountEmail).HasMaxLength(150);

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountTelNo).HasMaxLength(50);

                entity.Property(e => e.AmendSv)
                    .HasColumnName("AmendSV")
                    .HasMaxLength(50);

                entity.Property(e => e.Company).HasMaxLength(150);

                entity.Property(e => e.CurrentStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuspendReactId)
                    .HasColumnName("SuspendReact_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AccountType", "Anthony_TRMaster");

                entity.Property(e => e.AccountTypeInd)
                    .HasColumnName("AccountType_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(150);
            });

            modelBuilder.Entity<BfmMbtimaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BFM_MBTIMaster", "Anthony_TRMaster");

                entity.Property(e => e.Accounting).HasDefaultValueSql("((0))");

                entity.Property(e => e.Banking).HasDefaultValueSql("((0))");

                entity.Property(e => e.Commerce).HasDefaultValueSql("((0))");

                entity.Property(e => e.Construction).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreativeMedia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Legal).HasDefaultValueSql("((0))");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleInd).HasColumnName("Role_Ind");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<BfmMbtiroles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BFM_MBTIRoles", "Anthony_TRMaster");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<BfmresponsAnalyse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BFMResponsAnalyse", "Anthony_TRMaster");

                entity.Property(e => e.AnalyseId)
                    .HasColumnName("Analyse_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BfmTrueId).HasColumnName("BFM_TrueID");

                entity.Property(e => e.DateTimeConsent).HasColumnType("datetime");

                entity.Property(e => e.DecisionMakingScale15).HasColumnName("DecisionMaking_Scale15");

                entity.Property(e => e.DecisionMakingScale16).HasColumnName("DecisionMaking_Scale16");

                entity.Property(e => e.DecisionMakingScale17).HasColumnName("DecisionMaking_Scale17");

                entity.Property(e => e.DecisionMakingScale18).HasColumnName("DecisionMaking_Scale18");

                entity.Property(e => e.DecisionMakingScale19).HasColumnName("DecisionMaking_Scale19");

                entity.Property(e => e.MbtiAnalogue)
                    .HasColumnName("MBTI_Analogue")
                    .HasMaxLength(50);

                entity.Property(e => e.MbtiDescr).HasColumnName("MBTI_Descr");

                entity.Property(e => e.MbtiScale).HasColumnName("MBTI_Scale");

                entity.Property(e => e.PlongScale15).HasColumnName("PLong_Scale15");

                entity.Property(e => e.PlongScale16).HasColumnName("PLong_Scale16");

                entity.Property(e => e.PlongScale17).HasColumnName("PLong_Scale17");

                entity.Property(e => e.PlongScale18).HasColumnName("PLong_Scale18");

                entity.Property(e => e.PlongScale19).HasColumnName("PLong_Scale19");

                entity.Property(e => e.PshortScale15).HasColumnName("PShort_Scale15");

                entity.Property(e => e.PshortScale16).HasColumnName("PShort_Scale16");

                entity.Property(e => e.PshortScale17).HasColumnName("PShort_Scale17");

                entity.Property(e => e.PshortScale18).HasColumnName("PShort_Scale18");

                entity.Property(e => e.PshortScale19).HasColumnName("PShort_Scale19");

                entity.Property(e => e.Scale15).HasColumnName("scale_15");

                entity.Property(e => e.Scale15Long).HasColumnName("Scale15_Long");

                entity.Property(e => e.Scale16).HasColumnName("scale_16");

                entity.Property(e => e.Scale16Long).HasColumnName("Scale16_Long");

                entity.Property(e => e.Scale17).HasColumnName("scale_17");

                entity.Property(e => e.Scale17Long).HasColumnName("Scale17_Long");

                entity.Property(e => e.Scale18).HasColumnName("scale_18");

                entity.Property(e => e.Scale18Long).HasColumnName("Scale18_Long");

                entity.Property(e => e.Scale19).HasColumnName("scale_19");

                entity.Property(e => e.Scale19Long).HasColumnName("Scale19_Long");

                entity.Property(e => e.StressScale15).HasColumnName("Stress_Scale15");

                entity.Property(e => e.StressScale16).HasColumnName("Stress_Scale16");

                entity.Property(e => e.StressScale17).HasColumnName("Stress_Scale17");

                entity.Property(e => e.StressScale18).HasColumnName("Stress_Scale18");

                entity.Property(e => e.StressScale19).HasColumnName("Stress_Scale19");

                entity.Property(e => e.TestId).HasColumnName("TestID");
            });

            modelBuilder.Entity<Bfmresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BFMResponse", "Anthony_TRMaster");

                entity.Property(e => e.BfmTrueId).HasColumnName("BFM_TrueID");

                entity.Property(e => e.MediaId).HasColumnName("media_id");

                entity.Property(e => e.RequestId).HasColumnName("request_Id");

                entity.Property(e => e.ResponseId)
                    .HasColumnName("Response_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Scale1).HasColumnName("scale_1");

                entity.Property(e => e.Scale10).HasColumnName("scale_10");

                entity.Property(e => e.Scale100).HasColumnName("scale_100");

                entity.Property(e => e.Scale101).HasColumnName("scale_101");

                entity.Property(e => e.Scale102).HasColumnName("scale_102");

                entity.Property(e => e.Scale103).HasColumnName("scale_103");

                entity.Property(e => e.Scale104).HasColumnName("scale_104");

                entity.Property(e => e.Scale105).HasColumnName("scale_105");

                entity.Property(e => e.Scale106).HasColumnName("scale_106");

                entity.Property(e => e.Scale107).HasColumnName("scale_107");

                entity.Property(e => e.Scale108).HasColumnName("scale_108");

                entity.Property(e => e.Scale109).HasColumnName("scale_109");

                entity.Property(e => e.Scale11).HasColumnName("scale_11");

                entity.Property(e => e.Scale110).HasColumnName("scale_110");

                entity.Property(e => e.Scale111).HasColumnName("scale_111");

                entity.Property(e => e.Scale112).HasColumnName("scale_112");

                entity.Property(e => e.Scale113).HasColumnName("scale_113");

                entity.Property(e => e.Scale114).HasColumnName("scale_114");

                entity.Property(e => e.Scale115).HasColumnName("scale_115");

                entity.Property(e => e.Scale116).HasColumnName("scale_116");

                entity.Property(e => e.Scale117).HasColumnName("scale_117");

                entity.Property(e => e.Scale118).HasColumnName("scale_118");

                entity.Property(e => e.Scale119).HasColumnName("scale_119");

                entity.Property(e => e.Scale12).HasColumnName("scale_12");

                entity.Property(e => e.Scale120).HasColumnName("scale_120");

                entity.Property(e => e.Scale121).HasColumnName("scale_121");

                entity.Property(e => e.Scale122).HasColumnName("scale_122");

                entity.Property(e => e.Scale123).HasColumnName("scale_123");

                entity.Property(e => e.Scale124).HasColumnName("scale_124");

                entity.Property(e => e.Scale125).HasColumnName("scale_125");

                entity.Property(e => e.Scale126).HasColumnName("scale_126");

                entity.Property(e => e.Scale127).HasColumnName("scale_127");

                entity.Property(e => e.Scale128).HasColumnName("scale_128");

                entity.Property(e => e.Scale129).HasColumnName("scale_129");

                entity.Property(e => e.Scale13).HasColumnName("scale_13");

                entity.Property(e => e.Scale130).HasColumnName("scale_130");

                entity.Property(e => e.Scale131).HasColumnName("scale_131");

                entity.Property(e => e.Scale132).HasColumnName("scale_132");

                entity.Property(e => e.Scale133).HasColumnName("scale_133");

                entity.Property(e => e.Scale134).HasColumnName("scale_134");

                entity.Property(e => e.Scale135).HasColumnName("scale_135");

                entity.Property(e => e.Scale136).HasColumnName("scale_136");

                entity.Property(e => e.Scale137).HasColumnName("scale_137");

                entity.Property(e => e.Scale138).HasColumnName("scale_138");

                entity.Property(e => e.Scale139).HasColumnName("scale_139");

                entity.Property(e => e.Scale14).HasColumnName("scale_14");

                entity.Property(e => e.Scale140).HasColumnName("scale_140");

                entity.Property(e => e.Scale141).HasColumnName("scale_141");

                entity.Property(e => e.Scale142).HasColumnName("scale_142");

                entity.Property(e => e.Scale143).HasColumnName("scale_143");

                entity.Property(e => e.Scale144).HasColumnName("scale_144");

                entity.Property(e => e.Scale145).HasColumnName("scale_145");

                entity.Property(e => e.Scale146).HasColumnName("scale_146");

                entity.Property(e => e.Scale147).HasColumnName("scale_147");

                entity.Property(e => e.Scale148).HasColumnName("scale_148");

                entity.Property(e => e.Scale149).HasColumnName("scale_149");

                entity.Property(e => e.Scale15).HasColumnName("scale_15");

                entity.Property(e => e.Scale150).HasColumnName("scale_150");

                entity.Property(e => e.Scale151).HasColumnName("scale_151");

                entity.Property(e => e.Scale152).HasColumnName("scale_152");

                entity.Property(e => e.Scale153).HasColumnName("scale_153");

                entity.Property(e => e.Scale154).HasColumnName("scale_154");

                entity.Property(e => e.Scale155).HasColumnName("scale_155");

                entity.Property(e => e.Scale156).HasColumnName("scale_156");

                entity.Property(e => e.Scale157).HasColumnName("scale_157");

                entity.Property(e => e.Scale158).HasColumnName("scale_158");

                entity.Property(e => e.Scale159).HasColumnName("scale_159");

                entity.Property(e => e.Scale16).HasColumnName("scale_16");

                entity.Property(e => e.Scale160).HasColumnName("scale_160");

                entity.Property(e => e.Scale161).HasColumnName("scale_161");

                entity.Property(e => e.Scale162).HasColumnName("scale_162");

                entity.Property(e => e.Scale163).HasColumnName("scale_163");

                entity.Property(e => e.Scale164).HasColumnName("scale_164");

                entity.Property(e => e.Scale165).HasColumnName("scale_165");

                entity.Property(e => e.Scale166).HasColumnName("scale_166");

                entity.Property(e => e.Scale167).HasColumnName("scale_167");

                entity.Property(e => e.Scale168).HasColumnName("scale_168");

                entity.Property(e => e.Scale169).HasColumnName("scale_169");

                entity.Property(e => e.Scale17).HasColumnName("scale_17");

                entity.Property(e => e.Scale170).HasColumnName("scale_170");

                entity.Property(e => e.Scale171).HasColumnName("scale_171");

                entity.Property(e => e.Scale172).HasColumnName("scale_172");

                entity.Property(e => e.Scale173).HasColumnName("scale_173");

                entity.Property(e => e.Scale174).HasColumnName("scale_174");

                entity.Property(e => e.Scale175).HasColumnName("scale_175");

                entity.Property(e => e.Scale176).HasColumnName("scale_176");

                entity.Property(e => e.Scale177).HasColumnName("scale_177");

                entity.Property(e => e.Scale178).HasColumnName("scale_178");

                entity.Property(e => e.Scale179).HasColumnName("scale_179");

                entity.Property(e => e.Scale18).HasColumnName("scale_18");

                entity.Property(e => e.Scale180).HasColumnName("scale_180");

                entity.Property(e => e.Scale181).HasColumnName("scale_181");

                entity.Property(e => e.Scale182).HasColumnName("scale_182");

                entity.Property(e => e.Scale183).HasColumnName("scale_183");

                entity.Property(e => e.Scale184).HasColumnName("scale_184");

                entity.Property(e => e.Scale185).HasColumnName("scale_185");

                entity.Property(e => e.Scale186).HasColumnName("scale_186");

                entity.Property(e => e.Scale187).HasColumnName("scale_187");

                entity.Property(e => e.Scale188).HasColumnName("scale_188");

                entity.Property(e => e.Scale189).HasColumnName("scale_189");

                entity.Property(e => e.Scale19).HasColumnName("scale_19");

                entity.Property(e => e.Scale190).HasColumnName("scale_190");

                entity.Property(e => e.Scale191).HasColumnName("scale_191");

                entity.Property(e => e.Scale192).HasColumnName("scale_192");

                entity.Property(e => e.Scale193).HasColumnName("scale_193");

                entity.Property(e => e.Scale194).HasColumnName("scale_194");

                entity.Property(e => e.Scale195).HasColumnName("scale_195");

                entity.Property(e => e.Scale2).HasColumnName("scale_2");

                entity.Property(e => e.Scale20).HasColumnName("scale_20");

                entity.Property(e => e.Scale21).HasColumnName("scale_21");

                entity.Property(e => e.Scale22).HasColumnName("scale_22");

                entity.Property(e => e.Scale23).HasColumnName("scale_23");

                entity.Property(e => e.Scale24).HasColumnName("scale_24");

                entity.Property(e => e.Scale25).HasColumnName("scale_25");

                entity.Property(e => e.Scale26).HasColumnName("scale_26");

                entity.Property(e => e.Scale27).HasColumnName("scale_27");

                entity.Property(e => e.Scale28).HasColumnName("scale_28");

                entity.Property(e => e.Scale29).HasColumnName("scale_29");

                entity.Property(e => e.Scale3).HasColumnName("scale_3");

                entity.Property(e => e.Scale30).HasColumnName("scale_30");

                entity.Property(e => e.Scale31).HasColumnName("scale_31");

                entity.Property(e => e.Scale32).HasColumnName("scale_32");

                entity.Property(e => e.Scale33).HasColumnName("scale_33");

                entity.Property(e => e.Scale34).HasColumnName("scale_34");

                entity.Property(e => e.Scale35).HasColumnName("scale_35");

                entity.Property(e => e.Scale36).HasColumnName("scale_36");

                entity.Property(e => e.Scale37).HasColumnName("scale_37");

                entity.Property(e => e.Scale38).HasColumnName("scale_38");

                entity.Property(e => e.Scale39).HasColumnName("scale_39");

                entity.Property(e => e.Scale4).HasColumnName("scale_4");

                entity.Property(e => e.Scale40).HasColumnName("scale_40");

                entity.Property(e => e.Scale41).HasColumnName("scale_41");

                entity.Property(e => e.Scale42).HasColumnName("scale_42");

                entity.Property(e => e.Scale43).HasColumnName("scale_43");

                entity.Property(e => e.Scale44).HasColumnName("scale_44");

                entity.Property(e => e.Scale45).HasColumnName("scale_45");

                entity.Property(e => e.Scale46).HasColumnName("scale_46");

                entity.Property(e => e.Scale47).HasColumnName("scale_47");

                entity.Property(e => e.Scale48).HasColumnName("scale_48");

                entity.Property(e => e.Scale49).HasColumnName("scale_49");

                entity.Property(e => e.Scale5).HasColumnName("scale_5");

                entity.Property(e => e.Scale50).HasColumnName("scale_50");

                entity.Property(e => e.Scale51).HasColumnName("scale_51");

                entity.Property(e => e.Scale52).HasColumnName("scale_52");

                entity.Property(e => e.Scale53).HasColumnName("scale_53");

                entity.Property(e => e.Scale54).HasColumnName("scale_54");

                entity.Property(e => e.Scale55).HasColumnName("scale_55");

                entity.Property(e => e.Scale56).HasColumnName("scale_56");

                entity.Property(e => e.Scale57).HasColumnName("scale_57");

                entity.Property(e => e.Scale58).HasColumnName("scale_58");

                entity.Property(e => e.Scale59).HasColumnName("scale_59");

                entity.Property(e => e.Scale6).HasColumnName("scale_6");

                entity.Property(e => e.Scale60).HasColumnName("scale_60");

                entity.Property(e => e.Scale61).HasColumnName("scale_61");

                entity.Property(e => e.Scale62).HasColumnName("scale_62");

                entity.Property(e => e.Scale63).HasColumnName("scale_63");

                entity.Property(e => e.Scale64).HasColumnName("scale_64");

                entity.Property(e => e.Scale65).HasColumnName("scale_65");

                entity.Property(e => e.Scale66).HasColumnName("scale_66");

                entity.Property(e => e.Scale67).HasColumnName("scale_67");

                entity.Property(e => e.Scale68).HasColumnName("scale_68");

                entity.Property(e => e.Scale69).HasColumnName("scale_69");

                entity.Property(e => e.Scale7).HasColumnName("scale_7");

                entity.Property(e => e.Scale70).HasColumnName("scale_70");

                entity.Property(e => e.Scale71).HasColumnName("scale_71");

                entity.Property(e => e.Scale72).HasColumnName("scale_72");

                entity.Property(e => e.Scale73).HasColumnName("scale_73");

                entity.Property(e => e.Scale74).HasColumnName("scale_74");

                entity.Property(e => e.Scale75).HasColumnName("scale_75");

                entity.Property(e => e.Scale76).HasColumnName("scale_76");

                entity.Property(e => e.Scale77).HasColumnName("scale_77");

                entity.Property(e => e.Scale78).HasColumnName("scale_78");

                entity.Property(e => e.Scale79).HasColumnName("scale_79");

                entity.Property(e => e.Scale8).HasColumnName("scale_8");

                entity.Property(e => e.Scale80).HasColumnName("scale_80");

                entity.Property(e => e.Scale81).HasColumnName("scale_81");

                entity.Property(e => e.Scale82).HasColumnName("scale_82");

                entity.Property(e => e.Scale83).HasColumnName("scale_83");

                entity.Property(e => e.Scale84).HasColumnName("scale_84");

                entity.Property(e => e.Scale85).HasColumnName("scale_85");

                entity.Property(e => e.Scale86).HasColumnName("scale_86");

                entity.Property(e => e.Scale87).HasColumnName("scale_87");

                entity.Property(e => e.Scale88).HasColumnName("scale_88");

                entity.Property(e => e.Scale89).HasColumnName("scale_89");

                entity.Property(e => e.Scale9).HasColumnName("scale_9");

                entity.Property(e => e.Scale90).HasColumnName("scale_90");

                entity.Property(e => e.Scale91).HasColumnName("scale_91");

                entity.Property(e => e.Scale92).HasColumnName("scale_92");

                entity.Property(e => e.Scale93).HasColumnName("scale_93");

                entity.Property(e => e.Scale94).HasColumnName("scale_94");

                entity.Property(e => e.Scale95).HasColumnName("scale_95");

                entity.Property(e => e.Scale96).HasColumnName("scale_96");

                entity.Property(e => e.Scale97).HasColumnName("scale_97");

                entity.Property(e => e.Scale98).HasColumnName("scale_98");

                entity.Property(e => e.Scale99).HasColumnName("scale_99");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.Property(e => e.StatusMessage).HasColumnName("status_message");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<BillingClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillingClass", "Anthony_TRMaster");

                entity.Property(e => e.BillingClass1)
                    .HasColumnName("BillingClass")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingClassEffectiveDate).HasColumnType("date");

                entity.Property(e => e.BillingClassEffectiveDateTx).HasMaxLength(50);

                entity.Property(e => e.BillingClassRetireDate).HasColumnType("date");

                entity.Property(e => e.BillingClassRetireDateTx).HasMaxLength(50);

                entity.Property(e => e.MaxNoOfEmployees).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxTransactions).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinTransactions).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BillingRatePlans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillingRatePlans", "Anthony_TRMaster");

                entity.Property(e => e.DateActivated).HasColumnType("date");

                entity.Property(e => e.DateActivatedText)
                    .HasColumnName("DateActivated_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.DateRetired).HasColumnType("datetime");

                entity.Property(e => e.DateRetiredText)
                    .HasColumnName("DateRetired_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultForType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.RatePlanId)
                    .HasColumnName("RatePlan_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Svadd)
                    .HasColumnName("SVAdd")
                    .HasMaxLength(50);

                entity.Property(e => e.Svamend)
                    .HasColumnName("SVAmend")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BillingRateTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillingRateTable", "Anthony_TRMaster");

                entity.Property(e => e.RatePlanId).HasColumnName("RatePlanID");

                entity.Property(e => e.RateTableId)
                    .HasColumnName("RateTable_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<BillingType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillingType", "Anthony_TRMaster");

                entity.Property(e => e.CampaignBillingTypeId)
                    .HasColumnName("CampaignBillingType_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<CampaignApiResponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_API_Response", "Anthony_TRMaster");

                entity.Property(e => e.BfmTrueId).HasColumnName("BFM_TrueID");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.IpaddrClientScreen)
                    .HasColumnName("IPAddr_ClientScreen")
                    .HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.MediaId).HasColumnName("media_id");

                entity.Property(e => e.ReportPrintId).HasColumnName("ReportPrint_ID");

                entity.Property(e => e.RequestId).HasColumnName("request_Id");

                entity.Property(e => e.ResponseId)
                    .HasColumnName("Response_Id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Scale1).HasColumnName("scale_1");

                entity.Property(e => e.Scale10).HasColumnName("scale_10");

                entity.Property(e => e.Scale100).HasColumnName("scale_100");

                entity.Property(e => e.Scale101).HasColumnName("scale_101");

                entity.Property(e => e.Scale102).HasColumnName("scale_102");

                entity.Property(e => e.Scale103).HasColumnName("scale_103");

                entity.Property(e => e.Scale104).HasColumnName("scale_104");

                entity.Property(e => e.Scale105).HasColumnName("scale_105");

                entity.Property(e => e.Scale106).HasColumnName("scale_106");

                entity.Property(e => e.Scale107).HasColumnName("scale_107");

                entity.Property(e => e.Scale108).HasColumnName("scale_108");

                entity.Property(e => e.Scale109).HasColumnName("scale_109");

                entity.Property(e => e.Scale11).HasColumnName("scale_11");

                entity.Property(e => e.Scale110).HasColumnName("scale_110");

                entity.Property(e => e.Scale111).HasColumnName("scale_111");

                entity.Property(e => e.Scale112).HasColumnName("scale_112");

                entity.Property(e => e.Scale113).HasColumnName("scale_113");

                entity.Property(e => e.Scale114).HasColumnName("scale_114");

                entity.Property(e => e.Scale115).HasColumnName("scale_115");

                entity.Property(e => e.Scale116).HasColumnName("scale_116");

                entity.Property(e => e.Scale117).HasColumnName("scale_117");

                entity.Property(e => e.Scale118).HasColumnName("scale_118");

                entity.Property(e => e.Scale119).HasColumnName("scale_119");

                entity.Property(e => e.Scale12).HasColumnName("scale_12");

                entity.Property(e => e.Scale120).HasColumnName("scale_120");

                entity.Property(e => e.Scale121).HasColumnName("scale_121");

                entity.Property(e => e.Scale122).HasColumnName("scale_122");

                entity.Property(e => e.Scale123).HasColumnName("scale_123");

                entity.Property(e => e.Scale124).HasColumnName("scale_124");

                entity.Property(e => e.Scale125).HasColumnName("scale_125");

                entity.Property(e => e.Scale126).HasColumnName("scale_126");

                entity.Property(e => e.Scale127).HasColumnName("scale_127");

                entity.Property(e => e.Scale128).HasColumnName("scale_128");

                entity.Property(e => e.Scale129).HasColumnName("scale_129");

                entity.Property(e => e.Scale13).HasColumnName("scale_13");

                entity.Property(e => e.Scale130).HasColumnName("scale_130");

                entity.Property(e => e.Scale131).HasColumnName("scale_131");

                entity.Property(e => e.Scale132).HasColumnName("scale_132");

                entity.Property(e => e.Scale133).HasColumnName("scale_133");

                entity.Property(e => e.Scale134).HasColumnName("scale_134");

                entity.Property(e => e.Scale135).HasColumnName("scale_135");

                entity.Property(e => e.Scale136).HasColumnName("scale_136");

                entity.Property(e => e.Scale137).HasColumnName("scale_137");

                entity.Property(e => e.Scale138).HasColumnName("scale_138");

                entity.Property(e => e.Scale139).HasColumnName("scale_139");

                entity.Property(e => e.Scale14).HasColumnName("scale_14");

                entity.Property(e => e.Scale140).HasColumnName("scale_140");

                entity.Property(e => e.Scale141).HasColumnName("scale_141");

                entity.Property(e => e.Scale142).HasColumnName("scale_142");

                entity.Property(e => e.Scale143).HasColumnName("scale_143");

                entity.Property(e => e.Scale144).HasColumnName("scale_144");

                entity.Property(e => e.Scale145).HasColumnName("scale_145");

                entity.Property(e => e.Scale146).HasColumnName("scale_146");

                entity.Property(e => e.Scale147).HasColumnName("scale_147");

                entity.Property(e => e.Scale148).HasColumnName("scale_148");

                entity.Property(e => e.Scale149).HasColumnName("scale_149");

                entity.Property(e => e.Scale15).HasColumnName("scale_15");

                entity.Property(e => e.Scale150).HasColumnName("scale_150");

                entity.Property(e => e.Scale151).HasColumnName("scale_151");

                entity.Property(e => e.Scale152).HasColumnName("scale_152");

                entity.Property(e => e.Scale153).HasColumnName("scale_153");

                entity.Property(e => e.Scale154).HasColumnName("scale_154");

                entity.Property(e => e.Scale155).HasColumnName("scale_155");

                entity.Property(e => e.Scale156).HasColumnName("scale_156");

                entity.Property(e => e.Scale157).HasColumnName("scale_157");

                entity.Property(e => e.Scale158).HasColumnName("scale_158");

                entity.Property(e => e.Scale159).HasColumnName("scale_159");

                entity.Property(e => e.Scale16).HasColumnName("scale_16");

                entity.Property(e => e.Scale160).HasColumnName("scale_160");

                entity.Property(e => e.Scale161).HasColumnName("scale_161");

                entity.Property(e => e.Scale162).HasColumnName("scale_162");

                entity.Property(e => e.Scale163).HasColumnName("scale_163");

                entity.Property(e => e.Scale164).HasColumnName("scale_164");

                entity.Property(e => e.Scale165).HasColumnName("scale_165");

                entity.Property(e => e.Scale166).HasColumnName("scale_166");

                entity.Property(e => e.Scale167).HasColumnName("scale_167");

                entity.Property(e => e.Scale168).HasColumnName("scale_168");

                entity.Property(e => e.Scale169).HasColumnName("scale_169");

                entity.Property(e => e.Scale17).HasColumnName("scale_17");

                entity.Property(e => e.Scale170).HasColumnName("scale_170");

                entity.Property(e => e.Scale171).HasColumnName("scale_171");

                entity.Property(e => e.Scale172).HasColumnName("scale_172");

                entity.Property(e => e.Scale173).HasColumnName("scale_173");

                entity.Property(e => e.Scale174).HasColumnName("scale_174");

                entity.Property(e => e.Scale175).HasColumnName("scale_175");

                entity.Property(e => e.Scale176).HasColumnName("scale_176");

                entity.Property(e => e.Scale177).HasColumnName("scale_177");

                entity.Property(e => e.Scale178).HasColumnName("scale_178");

                entity.Property(e => e.Scale179).HasColumnName("scale_179");

                entity.Property(e => e.Scale18).HasColumnName("scale_18");

                entity.Property(e => e.Scale180).HasColumnName("scale_180");

                entity.Property(e => e.Scale181).HasColumnName("scale_181");

                entity.Property(e => e.Scale182).HasColumnName("scale_182");

                entity.Property(e => e.Scale183).HasColumnName("scale_183");

                entity.Property(e => e.Scale184).HasColumnName("scale_184");

                entity.Property(e => e.Scale185).HasColumnName("scale_185");

                entity.Property(e => e.Scale186).HasColumnName("scale_186");

                entity.Property(e => e.Scale187).HasColumnName("scale_187");

                entity.Property(e => e.Scale188).HasColumnName("scale_188");

                entity.Property(e => e.Scale189).HasColumnName("scale_189");

                entity.Property(e => e.Scale19).HasColumnName("scale_19");

                entity.Property(e => e.Scale190).HasColumnName("scale_190");

                entity.Property(e => e.Scale191).HasColumnName("scale_191");

                entity.Property(e => e.Scale192).HasColumnName("scale_192");

                entity.Property(e => e.Scale193).HasColumnName("scale_193");

                entity.Property(e => e.Scale194).HasColumnName("scale_194");

                entity.Property(e => e.Scale195).HasColumnName("scale_195");

                entity.Property(e => e.Scale2).HasColumnName("scale_2");

                entity.Property(e => e.Scale20).HasColumnName("scale_20");

                entity.Property(e => e.Scale21).HasColumnName("scale_21");

                entity.Property(e => e.Scale22).HasColumnName("scale_22");

                entity.Property(e => e.Scale23).HasColumnName("scale_23");

                entity.Property(e => e.Scale24).HasColumnName("scale_24");

                entity.Property(e => e.Scale25).HasColumnName("scale_25");

                entity.Property(e => e.Scale26).HasColumnName("scale_26");

                entity.Property(e => e.Scale27).HasColumnName("scale_27");

                entity.Property(e => e.Scale28).HasColumnName("scale_28");

                entity.Property(e => e.Scale29).HasColumnName("scale_29");

                entity.Property(e => e.Scale3).HasColumnName("scale_3");

                entity.Property(e => e.Scale30).HasColumnName("scale_30");

                entity.Property(e => e.Scale31).HasColumnName("scale_31");

                entity.Property(e => e.Scale32).HasColumnName("scale_32");

                entity.Property(e => e.Scale33).HasColumnName("scale_33");

                entity.Property(e => e.Scale34).HasColumnName("scale_34");

                entity.Property(e => e.Scale35).HasColumnName("scale_35");

                entity.Property(e => e.Scale36).HasColumnName("scale_36");

                entity.Property(e => e.Scale37).HasColumnName("scale_37");

                entity.Property(e => e.Scale38).HasColumnName("scale_38");

                entity.Property(e => e.Scale39).HasColumnName("scale_39");

                entity.Property(e => e.Scale4).HasColumnName("scale_4");

                entity.Property(e => e.Scale40).HasColumnName("scale_40");

                entity.Property(e => e.Scale41).HasColumnName("scale_41");

                entity.Property(e => e.Scale42).HasColumnName("scale_42");

                entity.Property(e => e.Scale43).HasColumnName("scale_43");

                entity.Property(e => e.Scale44).HasColumnName("scale_44");

                entity.Property(e => e.Scale45).HasColumnName("scale_45");

                entity.Property(e => e.Scale46).HasColumnName("scale_46");

                entity.Property(e => e.Scale47).HasColumnName("scale_47");

                entity.Property(e => e.Scale48).HasColumnName("scale_48");

                entity.Property(e => e.Scale49).HasColumnName("scale_49");

                entity.Property(e => e.Scale5).HasColumnName("scale_5");

                entity.Property(e => e.Scale50).HasColumnName("scale_50");

                entity.Property(e => e.Scale51).HasColumnName("scale_51");

                entity.Property(e => e.Scale52).HasColumnName("scale_52");

                entity.Property(e => e.Scale53).HasColumnName("scale_53");

                entity.Property(e => e.Scale54).HasColumnName("scale_54");

                entity.Property(e => e.Scale55).HasColumnName("scale_55");

                entity.Property(e => e.Scale56).HasColumnName("scale_56");

                entity.Property(e => e.Scale57).HasColumnName("scale_57");

                entity.Property(e => e.Scale58).HasColumnName("scale_58");

                entity.Property(e => e.Scale59).HasColumnName("scale_59");

                entity.Property(e => e.Scale6).HasColumnName("scale_6");

                entity.Property(e => e.Scale60).HasColumnName("scale_60");

                entity.Property(e => e.Scale61).HasColumnName("scale_61");

                entity.Property(e => e.Scale62).HasColumnName("scale_62");

                entity.Property(e => e.Scale63).HasColumnName("scale_63");

                entity.Property(e => e.Scale64).HasColumnName("scale_64");

                entity.Property(e => e.Scale65).HasColumnName("scale_65");

                entity.Property(e => e.Scale66).HasColumnName("scale_66");

                entity.Property(e => e.Scale67).HasColumnName("scale_67");

                entity.Property(e => e.Scale68).HasColumnName("scale_68");

                entity.Property(e => e.Scale69).HasColumnName("scale_69");

                entity.Property(e => e.Scale7).HasColumnName("scale_7");

                entity.Property(e => e.Scale70).HasColumnName("scale_70");

                entity.Property(e => e.Scale71).HasColumnName("scale_71");

                entity.Property(e => e.Scale72).HasColumnName("scale_72");

                entity.Property(e => e.Scale73).HasColumnName("scale_73");

                entity.Property(e => e.Scale74).HasColumnName("scale_74");

                entity.Property(e => e.Scale75).HasColumnName("scale_75");

                entity.Property(e => e.Scale76).HasColumnName("scale_76");

                entity.Property(e => e.Scale77).HasColumnName("scale_77");

                entity.Property(e => e.Scale78).HasColumnName("scale_78");

                entity.Property(e => e.Scale79).HasColumnName("scale_79");

                entity.Property(e => e.Scale8).HasColumnName("scale_8");

                entity.Property(e => e.Scale80).HasColumnName("scale_80");

                entity.Property(e => e.Scale81).HasColumnName("scale_81");

                entity.Property(e => e.Scale82).HasColumnName("scale_82");

                entity.Property(e => e.Scale83).HasColumnName("scale_83");

                entity.Property(e => e.Scale84).HasColumnName("scale_84");

                entity.Property(e => e.Scale85).HasColumnName("scale_85");

                entity.Property(e => e.Scale86).HasColumnName("scale_86");

                entity.Property(e => e.Scale87).HasColumnName("scale_87");

                entity.Property(e => e.Scale88).HasColumnName("scale_88");

                entity.Property(e => e.Scale89).HasColumnName("scale_89");

                entity.Property(e => e.Scale9).HasColumnName("scale_9");

                entity.Property(e => e.Scale90).HasColumnName("scale_90");

                entity.Property(e => e.Scale91).HasColumnName("scale_91");

                entity.Property(e => e.Scale92).HasColumnName("scale_92");

                entity.Property(e => e.Scale93).HasColumnName("scale_93");

                entity.Property(e => e.Scale94).HasColumnName("scale_94");

                entity.Property(e => e.Scale95).HasColumnName("scale_95");

                entity.Property(e => e.Scale96).HasColumnName("scale_96");

                entity.Property(e => e.Scale97).HasColumnName("scale_97");

                entity.Property(e => e.Scale98).HasColumnName("scale_98");

                entity.Property(e => e.Scale99).HasColumnName("scale_99");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.Property(e => e.StatusMessage).HasColumnName("status_message");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CampaignApiresponseAnalyse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_APIResponseAnalyse", "Anthony_TRMaster");

                entity.Property(e => e.AnalyseId)
                    .HasColumnName("Analyse_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BfmTrueId).HasColumnName("BFM_TrueID");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.DateTimeConsent).HasColumnType("datetime");

                entity.Property(e => e.DecisionMakingScale15).HasColumnName("DecisionMaking_Scale15");

                entity.Property(e => e.DecisionMakingScale16).HasColumnName("DecisionMaking_Scale16");

                entity.Property(e => e.DecisionMakingScale17).HasColumnName("DecisionMaking_Scale17");

                entity.Property(e => e.DecisionMakingScale18).HasColumnName("DecisionMaking_Scale18");

                entity.Property(e => e.DecisionMakingScale19).HasColumnName("DecisionMaking_Scale19");

                entity.Property(e => e.InvoiceNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.MbtiAnalogue)
                    .HasColumnName("MBTI_Analogue")
                    .HasMaxLength(50);

                entity.Property(e => e.MbtiDescr).HasColumnName("MBTI_Descr");

                entity.Property(e => e.MbtiScale).HasColumnName("MBTI_Scale");

                entity.Property(e => e.PlongScale15).HasColumnName("PLong_Scale15");

                entity.Property(e => e.PlongScale16).HasColumnName("PLong_Scale16");

                entity.Property(e => e.PlongScale17).HasColumnName("PLong_Scale17");

                entity.Property(e => e.PlongScale18).HasColumnName("PLong_Scale18");

                entity.Property(e => e.PlongScale19).HasColumnName("PLong_Scale19");

                entity.Property(e => e.PshortScale15).HasColumnName("PShort_Scale15");

                entity.Property(e => e.PshortScale16).HasColumnName("PShort_Scale16");

                entity.Property(e => e.PshortScale17).HasColumnName("PShort_Scale17");

                entity.Property(e => e.PshortScale18).HasColumnName("PShort_Scale18");

                entity.Property(e => e.PshortScale19).HasColumnName("PShort_Scale19");

                entity.Property(e => e.Rateplan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Scale15).HasColumnName("scale_15");

                entity.Property(e => e.Scale15Long).HasColumnName("Scale15_Long");

                entity.Property(e => e.Scale16).HasColumnName("scale_16");

                entity.Property(e => e.Scale16Long).HasColumnName("Scale16_Long");

                entity.Property(e => e.Scale17).HasColumnName("scale_17");

                entity.Property(e => e.Scale17Long).HasColumnName("Scale17_Long");

                entity.Property(e => e.Scale18).HasColumnName("scale_18");

                entity.Property(e => e.Scale18Long).HasColumnName("Scale18_Long");

                entity.Property(e => e.Scale19).HasColumnName("scale_19");

                entity.Property(e => e.Scale19Long).HasColumnName("Scale19_Long");

                entity.Property(e => e.StressScale15).HasColumnName("Stress_Scale15");

                entity.Property(e => e.StressScale16).HasColumnName("Stress_Scale16");

                entity.Property(e => e.StressScale17).HasColumnName("Stress_Scale17");

                entity.Property(e => e.StressScale18).HasColumnName("Stress_Scale18");

                entity.Property(e => e.StressScale19).HasColumnName("Stress_Scale19");

                entity.Property(e => e.TestId).HasColumnName("TestID");
            });

            modelBuilder.Entity<CampaignApplicantPayg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_ApplicantPAYG", "Anthony_TRMaster");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("Application_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignQ1answer)
                    .HasColumnName("CampaignQ1Answer")
                    .HasMaxLength(250);

                entity.Property(e => e.CampaignQ2answer)
                    .HasColumnName("CampaignQ2Answer")
                    .HasMaxLength(250);

                entity.Property(e => e.CampaignQ3answer)
                    .HasColumnName("CampaignQ3Answer")
                    .HasMaxLength(250);

                entity.Property(e => e.CampaignQ4answer)
                    .HasColumnName("CampaignQ4Answer")
                    .HasMaxLength(250);

                entity.Property(e => e.CovLettFileName).HasMaxLength(150);

                entity.Property(e => e.CvfileName)
                    .HasColumnName("CVFileName")
                    .HasMaxLength(150);

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Delta).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150);

                entity.Property(e => e.Ffma)
                    .HasColumnName("FFMA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ffmc)
                    .HasColumnName("FFMC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ffme)
                    .HasColumnName("FFME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ffmn)
                    .HasColumnName("FFMN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ffmo)
                    .HasColumnName("FFMO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gdprpermission)
                    .HasColumnName("GDPRPermission")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IpaddrClientScreen)
                    .HasColumnName("IPAddr_ClientScreen")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.Mbti)
                    .HasColumnName("MBTI")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.PercentageFit)
                    .HasColumnType("numeric(14, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PsyReportFileName).HasMaxLength(150);

                entity.Property(e => e.RatePlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportPrintId).HasColumnName("ReportPrint_ID");

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.TrueId)
                    .HasColumnName("TRueID")
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CampaignCampaignMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_CampaignMaster", "Anthony_TRMaster");

                entity.Property(e => e.AdvertTitle).HasMaxLength(250);

                entity.Property(e => e.AmendSv)
                    .HasColumnName("AmendSV")
                    .HasMaxLength(50);

                entity.Property(e => e.CampaignActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("Campaign_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignName).HasMaxLength(150);

                entity.Property(e => e.CampaignQuest).HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignQuestion1).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion2).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion3).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion4).HasMaxLength(250);

                entity.Property(e => e.CompanyInternalReference).HasMaxLength(250);

                entity.Property(e => e.CreateSv)
                    .HasColumnName("CreateSV")
                    .HasMaxLength(50);

                entity.Property(e => e.DateClosed).HasColumnType("date");

                entity.Property(e => e.DateClosedText).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Link)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("([Anthony_TRMaster].[udf_PassGenNoSym]((11)))");

                entity.Property(e => e.MaximumNoOfEntries).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmaHigh)
                    .HasColumnName("Model_FFMA_High")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmaLow)
                    .HasColumnName("Model_FFMA_Low")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmcHigh)
                    .HasColumnName("Model_FFMC_High")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmcLow)
                    .HasColumnName("Model_FFMC_Low")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmeHigh)
                    .HasColumnName("Model_FFME_High")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmeLow)
                    .HasColumnName("Model_FFME_Low")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmnHigh)
                    .HasColumnName("Model_FFMN_High")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmnLow)
                    .HasColumnName("Model_FFMN_Low")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmoHigh)
                    .HasColumnName("Model_FFMO_High")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelFfmoLow)
                    .HasColumnName("Model_FFMO_Low")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelMbtifromAdvanced)
                    .HasColumnName("Model_MBTIFromAdvanced")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelMbtifromTemplate)
                    .HasColumnName("Model_MBTIFromTemplate")
                    .HasMaxLength(50);

                entity.Property(e => e.PositionTitle).HasMaxLength(50);

                entity.Property(e => e.SpendToDate)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SpendingCap).HasColumnType("money");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CampaignRepPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_RepPrint", "Anthony_TRMaster");

                entity.Property(e => e.Done).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plong).HasColumnName("PLong");

                entity.Property(e => e.ReportPrId)
                    .HasColumnName("ReportPr_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rnk).HasColumnName("rnk");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CampaignReportPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_ReportPrint", "Anthony_TRMaster");

                entity.Property(e => e.BillingClass).HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.CampaignMasterSerial)
                    .HasColumnName("CampaignMaster_Serial")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreditNoteNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.DteTime).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(200);

                entity.Property(e => e.MbtiAnalys).HasColumnName("MBTI_Analys");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.NextBillingDate).HasColumnType("date");

                entity.Property(e => e.PdffileName)
                    .HasColumnName("PDFFileName")
                    .HasMaxLength(150);

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RatePlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Retain).HasDefaultValueSql("((0))");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<CampaignRoleBySector>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CampaignRoleBySector", "Anthony_TRMaster");

                entity.Property(e => e.Display).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<CampaignSourceSelection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_SourceSelection", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.MbtiDescr).HasColumnName("MBTI_Descr");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Retain).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoleInd).HasColumnName("Role_Ind");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.Selected).HasDefaultValueSql("((0))");

                entity.Property(e => e.Source).HasMaxLength(50);
            });

            modelBuilder.Entity<CampaignSourceSelectionMbti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Campaign_SourceSelectionMBTI", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.MbtiDescr).HasColumnName("MBTI_Descr");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Selected).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ConResp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConResp", "Anthony_TRMaster");

                entity.Property(e => e.ConRespInd).HasColumnName("ConREsp_Ind");

                entity.Property(e => e.Descr).HasMaxLength(250);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contact", "Anthony_TRMaster");

                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DteTime)
                    .HasColumnName("dteTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150);

                entity.Property(e => e.Ipaddr)
                    .HasColumnName("IPAddr")
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<ContactNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactNew", "Anthony_TRMaster");

                entity.Property(e => e.Account).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactId)
                    .HasColumnName("Contact_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ddi)
                    .HasColumnName("DDI")
                    .HasMaxLength(50);

                entity.Property(e => e.Display).HasDefaultValueSql("((0))");

                entity.Property(e => e.Firm).HasMaxLength(50);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(1500);

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.Property(e => e.PositionType)
                    .HasColumnName("Position_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Source).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ContactRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ContactRequest", "Anthony_TRMaster");

                entity.Property(e => e.ContactInd)
                    .HasColumnName("Contact_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateTim)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealtWith).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("emailAddress")
                    .HasMaxLength(150);

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .HasColumnName("MEssage")
                    .HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Suggrespons).HasColumnName("suggrespons");

                entity.Property(e => e.TelNo).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMailMatch", "Anthony_TRMaster");

                entity.Property(e => e.Del).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAdd)
                    .HasColumnName("emailAdd")
                    .HasMaxLength(80);

                entity.Property(e => e.EmailMatchInd)
                    .HasColumnName("EmailMatch_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MaxEnqInd).HasColumnName("MaxEnq_Ind");

                entity.Property(e => e.SessVarInd).HasColumnName("SessVar_Ind");

                entity.Property(e => e.UserName).HasMaxLength(150);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ErrorLog", "dbo");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasMaxLength(2000);

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LongMessage).HasMaxLength(4000);
            });

            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Months", "Anthony_TRMaster");

                entity.Property(e => e.MonthId)
                    .HasColumnName("Month_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MonthName).HasMaxLength(50);

                entity.Property(e => e.MonthShortName).HasMaxLength(50);
            });

            modelBuilder.Entity<PasswordNumbers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Password_Numbers", "Anthony_TRMaster");

                entity.Property(e => e.N).HasColumnName("n");
            });

            modelBuilder.Entity<PositionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PositionType", "Anthony_TRMaster");

                entity.Property(e => e.Descr).HasMaxLength(50);

                entity.Property(e => e.PositionType1)
                    .HasColumnName("PositionType")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PsyScales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PsyScales", "Anthony_TRMaster");

                entity.Property(e => e.DomainName)
                    .HasColumnName("domain_name")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupType)
                    .HasColumnName("Group_type")
                    .HasMaxLength(50);

                entity.Property(e => e.PsyName)
                    .HasColumnName("psy_name")
                    .HasMaxLength(50);

                entity.Property(e => e.PsyScaleInd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RepPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RepPrint", "Anthony_TRMaster");

                entity.Property(e => e.Done).HasDefaultValueSql("((0))");

                entity.Property(e => e.Plong).HasColumnName("PLong");

                entity.Property(e => e.ReportPrId)
                    .HasColumnName("ReportPr_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rnk).HasColumnName("rnk");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ReportMbti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportMBTI", "Anthony_TRMaster");

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.MbtiAnalogue)
                    .HasColumnName("MBTI_analogue")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleInd)
                    .HasColumnName("Role_Ind")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReportMbtisolo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_MBTISolo", "Anthony_TRMaster");

                entity.Property(e => e.MbtiAnalogue)
                    .HasColumnName("MBTI_analogue")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportPrint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportPrint", "Anthony_TRMaster");

                entity.Property(e => e.DteTime).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(200);

                entity.Property(e => e.MbtiAnalys).HasColumnName("MBTI_Analys");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportId)
                    .HasColumnName("Report_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<ReportScalesContent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_ScalesContent", "Anthony_TRMaster");

                entity.Property(e => e.DecisionMaking).HasColumnName("Decision making");

                entity.Property(e => e.PersonalityLong).HasColumnName("Personality_long");

                entity.Property(e => e.PersonalityShort)
                    .HasColumnName("Personality_short")
                    .HasMaxLength(255);

                entity.Property(e => e.ReactionToStressAndUncertainty).HasColumnName("Reaction to stress and uncertainty");

                entity.Property(e => e.Scale).HasMaxLength(255);

                entity.Property(e => e.ScaleContentId)
                    .HasColumnName("ScaleContent_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReportScalesContentOrig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_ScalesContent_Orig", "Anthony_TRMaster");

                entity.Property(e => e.DecisionMaking).HasColumnName("Decision making");

                entity.Property(e => e.PersonalityLong).HasColumnName("Personality_long");

                entity.Property(e => e.PersonalityShort)
                    .HasColumnName("Personality_short")
                    .HasMaxLength(255);

                entity.Property(e => e.ReactionToStressAndUncertainty).HasColumnName("Reaction to stress and uncertainty");

                entity.Property(e => e.Scale).HasMaxLength(255);

                entity.Property(e => e.ScaleContentId)
                    .HasColumnName("ScaleContent_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalesCommissionAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sales_CommissionAgent", "Anthony_TRMaster");

                entity.Property(e => e.AccountContactEmail).HasMaxLength(150);

                entity.Property(e => e.AccountContactName).HasMaxLength(150);

                entity.Property(e => e.AccountContactTelNo).HasMaxLength(50);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.AccountTelNo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Addr1).HasMaxLength(50);

                entity.Property(e => e.Addr2).HasMaxLength(50);

                entity.Property(e => e.AgentEndDate).HasColumnType("date");

                entity.Property(e => e.AgentEndDateTxt).HasMaxLength(50);

                entity.Property(e => e.BankAccountName).HasMaxLength(150);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CoNumber).HasMaxLength(50);

                entity.Property(e => e.CommissionPlan).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.DateSigned)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesAgentId)
                    .HasColumnName("SalesAgent_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesContactEmail).HasMaxLength(150);

                entity.Property(e => e.SalesContactName).HasMaxLength(150);

                entity.Property(e => e.SalesContactTelNo).HasMaxLength(50);

                entity.Property(e => e.SortCode).HasMaxLength(50);

                entity.Property(e => e.Sv)
                    .HasColumnName("SV")
                    .HasMaxLength(50);

                entity.Property(e => e.TrEmployee).HasColumnName("TR_Employee");

                entity.Property(e => e.VatregNo)
                    .HasColumnName("VATRegNo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SecurityLevels>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SecurityLevels", "Anthony_TRMaster");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Gradiant).HasMaxLength(50);

                entity.Property(e => e.SecLevelIndex).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SlAllocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_Allocations", "Anthony_TRMaster");

                entity.Property(e => e.Done).HasDefaultValueSql("((0))");

                entity.Property(e => e.SlTransCrAmount)
                    .HasColumnName("SlTrans_CrAmount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SlallocationInd)
                    .HasColumnName("SLAllocation_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SltransCr).HasColumnName("SLTrans_Cr");

                entity.Property(e => e.SltransDr).HasColumnName("SLTrans_Dr");

                entity.Property(e => e.SltransDrAmount)
                    .HasColumnName("SLTRans_DrAmount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SltransNewCrAmount)
                    .HasColumnName("SLTrans_NewCrAmount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SltransNewDrAmount)
                    .HasColumnName("SLTrans_NewDrAmount")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<SlCreditNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_CreditNote", "Anthony_TRMaster");

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsEmail).HasMaxLength(150);

                entity.Property(e => e.AccountsName).HasMaxLength(150);

                entity.Property(e => e.Addr1).HasMaxLength(150);

                entity.Property(e => e.Addr2).HasMaxLength(150);

                entity.Property(e => e.AllocAgainstSltransNo)
                    .HasColumnName("AllocAgainst_SLTransNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreditNoteInd)
                    .HasColumnName("CreditNote_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DateCrNote)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sv)
                    .HasColumnName("SV")
                    .HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<SlDebit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_Debit", "Anthony_TRMaster");

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsEmail).HasMaxLength(150);

                entity.Property(e => e.AccountsName).HasMaxLength(150);

                entity.Property(e => e.AllocAgainstSltransNo)
                    .HasColumnName("AllocAgainst_SLTransNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateJr)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SldrInd)
                    .HasColumnName("SLDr__Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sv)
                    .HasColumnName("SV")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SlInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_InvoiceDetail", "Anthony_TRMaster");

                entity.Property(e => e.AccountNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("Campaign_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CampaignName).HasMaxLength(150);

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvTransId)
                    .HasColumnName("InvTrans_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rateplan).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportPrintCode)
                    .HasColumnName("REportPrintCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportPrintId)
                    .HasColumnName("ReportPrint_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransPrice).HasColumnType("money");
            });

            modelBuilder.Entity<SlInvoiceSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_InvoiceSummary", "Anthony_TRMaster");

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsEmail).HasMaxLength(150);

                entity.Property(e => e.Addr1).HasMaxLength(150);

                entity.Property(e => e.Addr2).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Done).HasDefaultValueSql("((0))");

                entity.Property(e => e.InvDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pcode)
                    .HasColumnName("PCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SlInvNo)
                    .HasColumnName("SL_InvNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTransNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SlPaymentReturned>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_PaymentReturned", "Anthony_TRMaster");

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsEmail).HasMaxLength(150);

                entity.Property(e => e.AccountsName).HasMaxLength(150);

                entity.Property(e => e.AllocAgainstSltransNo)
                    .HasColumnName("AllocAgainst_SLTransNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateJr)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentBounceInd)
                    .HasColumnName("PaymentBounce_Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sv)
                    .HasColumnName("SV")
                    .HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<SlPayments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_Payments", "Anthony_TRMaster");

                entity.Property(e => e.AccountName).HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.AccountsEmail).HasMaxLength(150);

                entity.Property(e => e.AccountsName).HasMaxLength(150);

                entity.Property(e => e.AllocAgainstSltransNo)
                    .HasColumnName("AllocAgainst_SLTransNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateJr)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.PaymentInd)
                    .HasColumnName("Payment__Ind")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sv)
                    .HasColumnName("SV")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SlSalesCommissionRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_SalesCommissionRate", "Anthony_TRMaster");

                entity.Property(e => e.Descrip).HasMaxLength(50);

                entity.Property(e => e.Internal).HasDefaultValueSql("((1))");

                entity.Property(e => e.Rate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SlcommissionInd)
                    .HasColumnName("SLCommission_Ind")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SlSalesLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_SalesLedger", "Anthony_TRMaster");

                entity.Property(e => e.AccountNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cr)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrTotal)
                    .HasColumnName("Cr_Total")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrVat)
                    .HasColumnName("Cr_Vat")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.DocumentTypeNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dr)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DrTotal)
                    .HasColumnName("Dr_Total")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DrVat)
                    .HasColumnName("Dr_VAT")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.File).HasMaxLength(150);

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unallocated)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SlVatrates>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL_VATRates", "Anthony_TRMaster");

                entity.Property(e => e.Descr).HasMaxLength(50);

                entity.Property(e => e.InvoiceDescr).HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.VatRateId)
                    .HasColumnName("VatRate_ID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Status", "Anthony_TRMaster");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.StatusInd)
                    .HasColumnName("Status_Ind")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TrTestInvite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TR_TestInvite", "Anthony_TRMaster");

                entity.Property(e => e.BfmTrueId)
                    .HasColumnName("BFM_True_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmConsent)
                    .HasColumnName("Confirm_Consent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateTimeConsent).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.IpaddrClientScreen)
                    .HasColumnName("IPAddr_ClientScreen")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportPrintId).HasColumnName("ReportPrint_ID");

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.TestId)
                    .HasColumnName("TestID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User", "Anthony_TRMaster");

                entity.Property(e => e.Accounts).HasDefaultValueSql("((0))");

                entity.Property(e => e.AmendSv)
                    .HasColumnName("AmendSV")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateSv)
                    .HasColumnName("CreateSV")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateVacancy).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TelNo).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserValidationInd).HasColumnName("UserValidation_Ind");

                entity.Property(e => e.ViewProfiles).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserLog", "Anthony_TRMaster");

                entity.Property(e => e.Dte)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Event).HasMaxLength(250);

                entity.Property(e => e.LogInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessVar).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserLogType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserLogType", "Anthony_TRMaster");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.LogTypeInd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserType", "Anthony_TRMaster");

                entity.Property(e => e.UserTypeDesc).HasMaxLength(50);

                entity.Property(e => e.UserTypeInd).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<UserValidation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserValidation", "Anthony_TRMaster");

                entity.Property(e => e.AmendDte).HasColumnType("datetime");

                entity.Property(e => e.AmendSv)
                    .HasColumnName("AmendSV")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_No")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateSv)
                    .HasColumnName("CreateSV")
                    .HasMaxLength(50);

                entity.Property(e => e.Department1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department9).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("emailAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.OpeningMenu)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'addval.html')");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.TelecanvaserInd).HasColumnName("Telecanvaser_Ind");

                entity.Property(e => e.UserIndex).ValueGeneratedOnAdd();

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserValidationDepartments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserValidationDepartments", "Anthony_TRMaster");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.NotQualify).HasMaxLength(50);

                entity.Property(e => e.Qualify).HasMaxLength(50);
            });

            modelBuilder.Entity<VAccountGen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AccountGen", "Anthony_TRMaster");

                entity.Property(e => e.AccountContactEmail).HasMaxLength(150);

                entity.Property(e => e.AccountContactName).HasMaxLength(150);

                entity.Property(e => e.AccountContactTelNo).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Duration).HasMaxLength(50);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SalesAgentName).HasMaxLength(150);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<VAccountSetUpEmailCredentials>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AccountSetUp_EmailCredentials", "Anthony_TRMaster");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("emailAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.EnqInd).HasColumnName("Enq_Ind");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<VAnalyseFullyRanked>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Analyse_FullyRanked", "Anthony_TRMaster");

                entity.Property(e => e.Rnk).HasColumnName("rnk");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VAnalyseMaxBfmresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_AnalyseMaxBFMResponse", "Anthony_TRMaster");

                entity.Property(e => e.BfmTrueId).HasColumnName("BFM_TrueID");

                entity.Property(e => e.MediaId).HasColumnName("media_id");

                entity.Property(e => e.RequestId).HasColumnName("request_Id");

                entity.Property(e => e.ResponseId).HasColumnName("Response_Id");

                entity.Property(e => e.Scale1).HasColumnName("scale_1");

                entity.Property(e => e.Scale10).HasColumnName("scale_10");

                entity.Property(e => e.Scale100).HasColumnName("scale_100");

                entity.Property(e => e.Scale101).HasColumnName("scale_101");

                entity.Property(e => e.Scale102).HasColumnName("scale_102");

                entity.Property(e => e.Scale103).HasColumnName("scale_103");

                entity.Property(e => e.Scale104).HasColumnName("scale_104");

                entity.Property(e => e.Scale105).HasColumnName("scale_105");

                entity.Property(e => e.Scale106).HasColumnName("scale_106");

                entity.Property(e => e.Scale107).HasColumnName("scale_107");

                entity.Property(e => e.Scale108).HasColumnName("scale_108");

                entity.Property(e => e.Scale109).HasColumnName("scale_109");

                entity.Property(e => e.Scale11).HasColumnName("scale_11");

                entity.Property(e => e.Scale110).HasColumnName("scale_110");

                entity.Property(e => e.Scale111).HasColumnName("scale_111");

                entity.Property(e => e.Scale112).HasColumnName("scale_112");

                entity.Property(e => e.Scale113).HasColumnName("scale_113");

                entity.Property(e => e.Scale114).HasColumnName("scale_114");

                entity.Property(e => e.Scale115).HasColumnName("scale_115");

                entity.Property(e => e.Scale116).HasColumnName("scale_116");

                entity.Property(e => e.Scale117).HasColumnName("scale_117");

                entity.Property(e => e.Scale118).HasColumnName("scale_118");

                entity.Property(e => e.Scale119).HasColumnName("scale_119");

                entity.Property(e => e.Scale12).HasColumnName("scale_12");

                entity.Property(e => e.Scale120).HasColumnName("scale_120");

                entity.Property(e => e.Scale121).HasColumnName("scale_121");

                entity.Property(e => e.Scale122).HasColumnName("scale_122");

                entity.Property(e => e.Scale123).HasColumnName("scale_123");

                entity.Property(e => e.Scale124).HasColumnName("scale_124");

                entity.Property(e => e.Scale125).HasColumnName("scale_125");

                entity.Property(e => e.Scale126).HasColumnName("scale_126");

                entity.Property(e => e.Scale127).HasColumnName("scale_127");

                entity.Property(e => e.Scale128).HasColumnName("scale_128");

                entity.Property(e => e.Scale129).HasColumnName("scale_129");

                entity.Property(e => e.Scale13).HasColumnName("scale_13");

                entity.Property(e => e.Scale130).HasColumnName("scale_130");

                entity.Property(e => e.Scale131).HasColumnName("scale_131");

                entity.Property(e => e.Scale132).HasColumnName("scale_132");

                entity.Property(e => e.Scale133).HasColumnName("scale_133");

                entity.Property(e => e.Scale134).HasColumnName("scale_134");

                entity.Property(e => e.Scale135).HasColumnName("scale_135");

                entity.Property(e => e.Scale136).HasColumnName("scale_136");

                entity.Property(e => e.Scale137).HasColumnName("scale_137");

                entity.Property(e => e.Scale138).HasColumnName("scale_138");

                entity.Property(e => e.Scale139).HasColumnName("scale_139");

                entity.Property(e => e.Scale14).HasColumnName("scale_14");

                entity.Property(e => e.Scale140).HasColumnName("scale_140");

                entity.Property(e => e.Scale141).HasColumnName("scale_141");

                entity.Property(e => e.Scale142).HasColumnName("scale_142");

                entity.Property(e => e.Scale143).HasColumnName("scale_143");

                entity.Property(e => e.Scale144).HasColumnName("scale_144");

                entity.Property(e => e.Scale145).HasColumnName("scale_145");

                entity.Property(e => e.Scale146).HasColumnName("scale_146");

                entity.Property(e => e.Scale147).HasColumnName("scale_147");

                entity.Property(e => e.Scale148).HasColumnName("scale_148");

                entity.Property(e => e.Scale149).HasColumnName("scale_149");

                entity.Property(e => e.Scale15).HasColumnName("scale_15");

                entity.Property(e => e.Scale150).HasColumnName("scale_150");

                entity.Property(e => e.Scale151).HasColumnName("scale_151");

                entity.Property(e => e.Scale152).HasColumnName("scale_152");

                entity.Property(e => e.Scale153).HasColumnName("scale_153");

                entity.Property(e => e.Scale154).HasColumnName("scale_154");

                entity.Property(e => e.Scale155).HasColumnName("scale_155");

                entity.Property(e => e.Scale156).HasColumnName("scale_156");

                entity.Property(e => e.Scale157).HasColumnName("scale_157");

                entity.Property(e => e.Scale158).HasColumnName("scale_158");

                entity.Property(e => e.Scale159).HasColumnName("scale_159");

                entity.Property(e => e.Scale16).HasColumnName("scale_16");

                entity.Property(e => e.Scale160).HasColumnName("scale_160");

                entity.Property(e => e.Scale161).HasColumnName("scale_161");

                entity.Property(e => e.Scale162).HasColumnName("scale_162");

                entity.Property(e => e.Scale163).HasColumnName("scale_163");

                entity.Property(e => e.Scale164).HasColumnName("scale_164");

                entity.Property(e => e.Scale165).HasColumnName("scale_165");

                entity.Property(e => e.Scale166).HasColumnName("scale_166");

                entity.Property(e => e.Scale167).HasColumnName("scale_167");

                entity.Property(e => e.Scale168).HasColumnName("scale_168");

                entity.Property(e => e.Scale169).HasColumnName("scale_169");

                entity.Property(e => e.Scale17).HasColumnName("scale_17");

                entity.Property(e => e.Scale170).HasColumnName("scale_170");

                entity.Property(e => e.Scale171).HasColumnName("scale_171");

                entity.Property(e => e.Scale172).HasColumnName("scale_172");

                entity.Property(e => e.Scale173).HasColumnName("scale_173");

                entity.Property(e => e.Scale174).HasColumnName("scale_174");

                entity.Property(e => e.Scale175).HasColumnName("scale_175");

                entity.Property(e => e.Scale176).HasColumnName("scale_176");

                entity.Property(e => e.Scale177).HasColumnName("scale_177");

                entity.Property(e => e.Scale178).HasColumnName("scale_178");

                entity.Property(e => e.Scale179).HasColumnName("scale_179");

                entity.Property(e => e.Scale18).HasColumnName("scale_18");

                entity.Property(e => e.Scale180).HasColumnName("scale_180");

                entity.Property(e => e.Scale181).HasColumnName("scale_181");

                entity.Property(e => e.Scale182).HasColumnName("scale_182");

                entity.Property(e => e.Scale183).HasColumnName("scale_183");

                entity.Property(e => e.Scale184).HasColumnName("scale_184");

                entity.Property(e => e.Scale185).HasColumnName("scale_185");

                entity.Property(e => e.Scale186).HasColumnName("scale_186");

                entity.Property(e => e.Scale187).HasColumnName("scale_187");

                entity.Property(e => e.Scale188).HasColumnName("scale_188");

                entity.Property(e => e.Scale189).HasColumnName("scale_189");

                entity.Property(e => e.Scale19).HasColumnName("scale_19");

                entity.Property(e => e.Scale190).HasColumnName("scale_190");

                entity.Property(e => e.Scale191).HasColumnName("scale_191");

                entity.Property(e => e.Scale192).HasColumnName("scale_192");

                entity.Property(e => e.Scale193).HasColumnName("scale_193");

                entity.Property(e => e.Scale194).HasColumnName("scale_194");

                entity.Property(e => e.Scale195).HasColumnName("scale_195");

                entity.Property(e => e.Scale2).HasColumnName("scale_2");

                entity.Property(e => e.Scale20).HasColumnName("scale_20");

                entity.Property(e => e.Scale21).HasColumnName("scale_21");

                entity.Property(e => e.Scale22).HasColumnName("scale_22");

                entity.Property(e => e.Scale23).HasColumnName("scale_23");

                entity.Property(e => e.Scale24).HasColumnName("scale_24");

                entity.Property(e => e.Scale25).HasColumnName("scale_25");

                entity.Property(e => e.Scale26).HasColumnName("scale_26");

                entity.Property(e => e.Scale27).HasColumnName("scale_27");

                entity.Property(e => e.Scale28).HasColumnName("scale_28");

                entity.Property(e => e.Scale29).HasColumnName("scale_29");

                entity.Property(e => e.Scale3).HasColumnName("scale_3");

                entity.Property(e => e.Scale30).HasColumnName("scale_30");

                entity.Property(e => e.Scale31).HasColumnName("scale_31");

                entity.Property(e => e.Scale32).HasColumnName("scale_32");

                entity.Property(e => e.Scale33).HasColumnName("scale_33");

                entity.Property(e => e.Scale34).HasColumnName("scale_34");

                entity.Property(e => e.Scale35).HasColumnName("scale_35");

                entity.Property(e => e.Scale36).HasColumnName("scale_36");

                entity.Property(e => e.Scale37).HasColumnName("scale_37");

                entity.Property(e => e.Scale38).HasColumnName("scale_38");

                entity.Property(e => e.Scale39).HasColumnName("scale_39");

                entity.Property(e => e.Scale4).HasColumnName("scale_4");

                entity.Property(e => e.Scale40).HasColumnName("scale_40");

                entity.Property(e => e.Scale41).HasColumnName("scale_41");

                entity.Property(e => e.Scale42).HasColumnName("scale_42");

                entity.Property(e => e.Scale43).HasColumnName("scale_43");

                entity.Property(e => e.Scale44).HasColumnName("scale_44");

                entity.Property(e => e.Scale45).HasColumnName("scale_45");

                entity.Property(e => e.Scale46).HasColumnName("scale_46");

                entity.Property(e => e.Scale47).HasColumnName("scale_47");

                entity.Property(e => e.Scale48).HasColumnName("scale_48");

                entity.Property(e => e.Scale49).HasColumnName("scale_49");

                entity.Property(e => e.Scale5).HasColumnName("scale_5");

                entity.Property(e => e.Scale50).HasColumnName("scale_50");

                entity.Property(e => e.Scale51).HasColumnName("scale_51");

                entity.Property(e => e.Scale52).HasColumnName("scale_52");

                entity.Property(e => e.Scale53).HasColumnName("scale_53");

                entity.Property(e => e.Scale54).HasColumnName("scale_54");

                entity.Property(e => e.Scale55).HasColumnName("scale_55");

                entity.Property(e => e.Scale56).HasColumnName("scale_56");

                entity.Property(e => e.Scale57).HasColumnName("scale_57");

                entity.Property(e => e.Scale58).HasColumnName("scale_58");

                entity.Property(e => e.Scale59).HasColumnName("scale_59");

                entity.Property(e => e.Scale6).HasColumnName("scale_6");

                entity.Property(e => e.Scale60).HasColumnName("scale_60");

                entity.Property(e => e.Scale61).HasColumnName("scale_61");

                entity.Property(e => e.Scale62).HasColumnName("scale_62");

                entity.Property(e => e.Scale63).HasColumnName("scale_63");

                entity.Property(e => e.Scale64).HasColumnName("scale_64");

                entity.Property(e => e.Scale65).HasColumnName("scale_65");

                entity.Property(e => e.Scale66).HasColumnName("scale_66");

                entity.Property(e => e.Scale67).HasColumnName("scale_67");

                entity.Property(e => e.Scale68).HasColumnName("scale_68");

                entity.Property(e => e.Scale69).HasColumnName("scale_69");

                entity.Property(e => e.Scale7).HasColumnName("scale_7");

                entity.Property(e => e.Scale70).HasColumnName("scale_70");

                entity.Property(e => e.Scale71).HasColumnName("scale_71");

                entity.Property(e => e.Scale72).HasColumnName("scale_72");

                entity.Property(e => e.Scale73).HasColumnName("scale_73");

                entity.Property(e => e.Scale74).HasColumnName("scale_74");

                entity.Property(e => e.Scale75).HasColumnName("scale_75");

                entity.Property(e => e.Scale76).HasColumnName("scale_76");

                entity.Property(e => e.Scale77).HasColumnName("scale_77");

                entity.Property(e => e.Scale78).HasColumnName("scale_78");

                entity.Property(e => e.Scale79).HasColumnName("scale_79");

                entity.Property(e => e.Scale8).HasColumnName("scale_8");

                entity.Property(e => e.Scale80).HasColumnName("scale_80");

                entity.Property(e => e.Scale81).HasColumnName("scale_81");

                entity.Property(e => e.Scale82).HasColumnName("scale_82");

                entity.Property(e => e.Scale83).HasColumnName("scale_83");

                entity.Property(e => e.Scale84).HasColumnName("scale_84");

                entity.Property(e => e.Scale85).HasColumnName("scale_85");

                entity.Property(e => e.Scale86).HasColumnName("scale_86");

                entity.Property(e => e.Scale87).HasColumnName("scale_87");

                entity.Property(e => e.Scale88).HasColumnName("scale_88");

                entity.Property(e => e.Scale89).HasColumnName("scale_89");

                entity.Property(e => e.Scale9).HasColumnName("scale_9");

                entity.Property(e => e.Scale90).HasColumnName("scale_90");

                entity.Property(e => e.Scale91).HasColumnName("scale_91");

                entity.Property(e => e.Scale92).HasColumnName("scale_92");

                entity.Property(e => e.Scale93).HasColumnName("scale_93");

                entity.Property(e => e.Scale94).HasColumnName("scale_94");

                entity.Property(e => e.Scale95).HasColumnName("scale_95");

                entity.Property(e => e.Scale96).HasColumnName("scale_96");

                entity.Property(e => e.Scale97).HasColumnName("scale_97");

                entity.Property(e => e.Scale98).HasColumnName("scale_98");

                entity.Property(e => e.Scale99).HasColumnName("scale_99");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.Property(e => e.StatusMessage).HasColumnName("status_message");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<VAnalyseMaxResponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ANALYSE_MaxResponse", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<VAnalyseUnPivotPlong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Analyse_UnPivot_PLong", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<VAnalyseUnPivotPshort>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Analyse_UnPivot_Pshort", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(8);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<VAnalyseUnPivotScaleForRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Analyse_UnPivot_ScaleForRank", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VApplicantDashQtyApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ApplicantDash_QtyApp", "Anthony_TRMaster");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VApplicantFormFieldPop>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ApplicantForm_FieldPop", "Anthony_TRMaster");

                entity.Property(e => e.AdvertTitle).HasMaxLength(250);

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.CampaignQuestion1).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion2).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion3).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion4).HasMaxLength(250);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.Para2).HasMaxLength(338);
            });

            modelBuilder.Entity<VBillingAmendRatePlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Billing_AmendRatePlan", "Anthony_TRMaster");

                entity.Property(e => e.DateRetired).HasColumnType("datetime");

                entity.Property(e => e.DateRetiredText)
                    .HasColumnName("DateRetired_Text")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.PlanName).HasMaxLength(150);

                entity.Property(e => e.RatePlanId).HasColumnName("RatePlan_ID");

                entity.Property(e => e.Svamend)
                    .HasColumnName("SVAmend")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VBillingClassByType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_BillingClassByType", "Anthony_TRMaster");
            });

            modelBuilder.Entity<VBillingNewRates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_BillingNewRates", "Anthony_TRMaster");

                entity.Property(e => e.ClassDescr).HasMaxLength(86);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.RatePlanId).HasColumnName("RatePlanID");
            });

            modelBuilder.Entity<VCampaignActive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignActive", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("Campaign_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignQuestion1).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion2).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion3).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion4).HasMaxLength(250);

                entity.Property(e => e.Link).HasMaxLength(250);
            });

            modelBuilder.Entity<VCampaignAnalyseFullyRanked>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_Analyse_FullyRanked", "Anthony_TRMaster");

                entity.Property(e => e.Rnk).HasColumnName("rnk");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VCampaignAnalyseMaxApiresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_AnalyseMaxAPIResponse", "Anthony_TRMaster");

                entity.Property(e => e.BfmTrueId).HasColumnName("BFM_TrueID");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.Link).HasMaxLength(50);

                entity.Property(e => e.MediaId).HasColumnName("media_id");

                entity.Property(e => e.RequestId).HasColumnName("request_Id");

                entity.Property(e => e.ResponseId).HasColumnName("Response_Id");

                entity.Property(e => e.Scale1).HasColumnName("scale_1");

                entity.Property(e => e.Scale10).HasColumnName("scale_10");

                entity.Property(e => e.Scale100).HasColumnName("scale_100");

                entity.Property(e => e.Scale101).HasColumnName("scale_101");

                entity.Property(e => e.Scale102).HasColumnName("scale_102");

                entity.Property(e => e.Scale103).HasColumnName("scale_103");

                entity.Property(e => e.Scale104).HasColumnName("scale_104");

                entity.Property(e => e.Scale105).HasColumnName("scale_105");

                entity.Property(e => e.Scale106).HasColumnName("scale_106");

                entity.Property(e => e.Scale107).HasColumnName("scale_107");

                entity.Property(e => e.Scale108).HasColumnName("scale_108");

                entity.Property(e => e.Scale109).HasColumnName("scale_109");

                entity.Property(e => e.Scale11).HasColumnName("scale_11");

                entity.Property(e => e.Scale110).HasColumnName("scale_110");

                entity.Property(e => e.Scale111).HasColumnName("scale_111");

                entity.Property(e => e.Scale112).HasColumnName("scale_112");

                entity.Property(e => e.Scale113).HasColumnName("scale_113");

                entity.Property(e => e.Scale114).HasColumnName("scale_114");

                entity.Property(e => e.Scale115).HasColumnName("scale_115");

                entity.Property(e => e.Scale116).HasColumnName("scale_116");

                entity.Property(e => e.Scale117).HasColumnName("scale_117");

                entity.Property(e => e.Scale118).HasColumnName("scale_118");

                entity.Property(e => e.Scale119).HasColumnName("scale_119");

                entity.Property(e => e.Scale12).HasColumnName("scale_12");

                entity.Property(e => e.Scale120).HasColumnName("scale_120");

                entity.Property(e => e.Scale121).HasColumnName("scale_121");

                entity.Property(e => e.Scale122).HasColumnName("scale_122");

                entity.Property(e => e.Scale123).HasColumnName("scale_123");

                entity.Property(e => e.Scale124).HasColumnName("scale_124");

                entity.Property(e => e.Scale125).HasColumnName("scale_125");

                entity.Property(e => e.Scale126).HasColumnName("scale_126");

                entity.Property(e => e.Scale127).HasColumnName("scale_127");

                entity.Property(e => e.Scale128).HasColumnName("scale_128");

                entity.Property(e => e.Scale129).HasColumnName("scale_129");

                entity.Property(e => e.Scale13).HasColumnName("scale_13");

                entity.Property(e => e.Scale130).HasColumnName("scale_130");

                entity.Property(e => e.Scale131).HasColumnName("scale_131");

                entity.Property(e => e.Scale132).HasColumnName("scale_132");

                entity.Property(e => e.Scale133).HasColumnName("scale_133");

                entity.Property(e => e.Scale134).HasColumnName("scale_134");

                entity.Property(e => e.Scale135).HasColumnName("scale_135");

                entity.Property(e => e.Scale136).HasColumnName("scale_136");

                entity.Property(e => e.Scale137).HasColumnName("scale_137");

                entity.Property(e => e.Scale138).HasColumnName("scale_138");

                entity.Property(e => e.Scale139).HasColumnName("scale_139");

                entity.Property(e => e.Scale14).HasColumnName("scale_14");

                entity.Property(e => e.Scale140).HasColumnName("scale_140");

                entity.Property(e => e.Scale141).HasColumnName("scale_141");

                entity.Property(e => e.Scale142).HasColumnName("scale_142");

                entity.Property(e => e.Scale143).HasColumnName("scale_143");

                entity.Property(e => e.Scale144).HasColumnName("scale_144");

                entity.Property(e => e.Scale145).HasColumnName("scale_145");

                entity.Property(e => e.Scale146).HasColumnName("scale_146");

                entity.Property(e => e.Scale147).HasColumnName("scale_147");

                entity.Property(e => e.Scale148).HasColumnName("scale_148");

                entity.Property(e => e.Scale149).HasColumnName("scale_149");

                entity.Property(e => e.Scale15).HasColumnName("scale_15");

                entity.Property(e => e.Scale150).HasColumnName("scale_150");

                entity.Property(e => e.Scale151).HasColumnName("scale_151");

                entity.Property(e => e.Scale152).HasColumnName("scale_152");

                entity.Property(e => e.Scale153).HasColumnName("scale_153");

                entity.Property(e => e.Scale154).HasColumnName("scale_154");

                entity.Property(e => e.Scale155).HasColumnName("scale_155");

                entity.Property(e => e.Scale156).HasColumnName("scale_156");

                entity.Property(e => e.Scale157).HasColumnName("scale_157");

                entity.Property(e => e.Scale158).HasColumnName("scale_158");

                entity.Property(e => e.Scale159).HasColumnName("scale_159");

                entity.Property(e => e.Scale16).HasColumnName("scale_16");

                entity.Property(e => e.Scale160).HasColumnName("scale_160");

                entity.Property(e => e.Scale161).HasColumnName("scale_161");

                entity.Property(e => e.Scale162).HasColumnName("scale_162");

                entity.Property(e => e.Scale163).HasColumnName("scale_163");

                entity.Property(e => e.Scale164).HasColumnName("scale_164");

                entity.Property(e => e.Scale165).HasColumnName("scale_165");

                entity.Property(e => e.Scale166).HasColumnName("scale_166");

                entity.Property(e => e.Scale167).HasColumnName("scale_167");

                entity.Property(e => e.Scale168).HasColumnName("scale_168");

                entity.Property(e => e.Scale169).HasColumnName("scale_169");

                entity.Property(e => e.Scale17).HasColumnName("scale_17");

                entity.Property(e => e.Scale170).HasColumnName("scale_170");

                entity.Property(e => e.Scale171).HasColumnName("scale_171");

                entity.Property(e => e.Scale172).HasColumnName("scale_172");

                entity.Property(e => e.Scale173).HasColumnName("scale_173");

                entity.Property(e => e.Scale174).HasColumnName("scale_174");

                entity.Property(e => e.Scale175).HasColumnName("scale_175");

                entity.Property(e => e.Scale176).HasColumnName("scale_176");

                entity.Property(e => e.Scale177).HasColumnName("scale_177");

                entity.Property(e => e.Scale178).HasColumnName("scale_178");

                entity.Property(e => e.Scale179).HasColumnName("scale_179");

                entity.Property(e => e.Scale18).HasColumnName("scale_18");

                entity.Property(e => e.Scale180).HasColumnName("scale_180");

                entity.Property(e => e.Scale181).HasColumnName("scale_181");

                entity.Property(e => e.Scale182).HasColumnName("scale_182");

                entity.Property(e => e.Scale183).HasColumnName("scale_183");

                entity.Property(e => e.Scale184).HasColumnName("scale_184");

                entity.Property(e => e.Scale185).HasColumnName("scale_185");

                entity.Property(e => e.Scale186).HasColumnName("scale_186");

                entity.Property(e => e.Scale187).HasColumnName("scale_187");

                entity.Property(e => e.Scale188).HasColumnName("scale_188");

                entity.Property(e => e.Scale189).HasColumnName("scale_189");

                entity.Property(e => e.Scale19).HasColumnName("scale_19");

                entity.Property(e => e.Scale190).HasColumnName("scale_190");

                entity.Property(e => e.Scale191).HasColumnName("scale_191");

                entity.Property(e => e.Scale192).HasColumnName("scale_192");

                entity.Property(e => e.Scale193).HasColumnName("scale_193");

                entity.Property(e => e.Scale194).HasColumnName("scale_194");

                entity.Property(e => e.Scale195).HasColumnName("scale_195");

                entity.Property(e => e.Scale2).HasColumnName("scale_2");

                entity.Property(e => e.Scale20).HasColumnName("scale_20");

                entity.Property(e => e.Scale21).HasColumnName("scale_21");

                entity.Property(e => e.Scale22).HasColumnName("scale_22");

                entity.Property(e => e.Scale23).HasColumnName("scale_23");

                entity.Property(e => e.Scale24).HasColumnName("scale_24");

                entity.Property(e => e.Scale25).HasColumnName("scale_25");

                entity.Property(e => e.Scale26).HasColumnName("scale_26");

                entity.Property(e => e.Scale27).HasColumnName("scale_27");

                entity.Property(e => e.Scale28).HasColumnName("scale_28");

                entity.Property(e => e.Scale29).HasColumnName("scale_29");

                entity.Property(e => e.Scale3).HasColumnName("scale_3");

                entity.Property(e => e.Scale30).HasColumnName("scale_30");

                entity.Property(e => e.Scale31).HasColumnName("scale_31");

                entity.Property(e => e.Scale32).HasColumnName("scale_32");

                entity.Property(e => e.Scale33).HasColumnName("scale_33");

                entity.Property(e => e.Scale34).HasColumnName("scale_34");

                entity.Property(e => e.Scale35).HasColumnName("scale_35");

                entity.Property(e => e.Scale36).HasColumnName("scale_36");

                entity.Property(e => e.Scale37).HasColumnName("scale_37");

                entity.Property(e => e.Scale38).HasColumnName("scale_38");

                entity.Property(e => e.Scale39).HasColumnName("scale_39");

                entity.Property(e => e.Scale4).HasColumnName("scale_4");

                entity.Property(e => e.Scale40).HasColumnName("scale_40");

                entity.Property(e => e.Scale41).HasColumnName("scale_41");

                entity.Property(e => e.Scale42).HasColumnName("scale_42");

                entity.Property(e => e.Scale43).HasColumnName("scale_43");

                entity.Property(e => e.Scale44).HasColumnName("scale_44");

                entity.Property(e => e.Scale45).HasColumnName("scale_45");

                entity.Property(e => e.Scale46).HasColumnName("scale_46");

                entity.Property(e => e.Scale47).HasColumnName("scale_47");

                entity.Property(e => e.Scale48).HasColumnName("scale_48");

                entity.Property(e => e.Scale49).HasColumnName("scale_49");

                entity.Property(e => e.Scale5).HasColumnName("scale_5");

                entity.Property(e => e.Scale50).HasColumnName("scale_50");

                entity.Property(e => e.Scale51).HasColumnName("scale_51");

                entity.Property(e => e.Scale52).HasColumnName("scale_52");

                entity.Property(e => e.Scale53).HasColumnName("scale_53");

                entity.Property(e => e.Scale54).HasColumnName("scale_54");

                entity.Property(e => e.Scale55).HasColumnName("scale_55");

                entity.Property(e => e.Scale56).HasColumnName("scale_56");

                entity.Property(e => e.Scale57).HasColumnName("scale_57");

                entity.Property(e => e.Scale58).HasColumnName("scale_58");

                entity.Property(e => e.Scale59).HasColumnName("scale_59");

                entity.Property(e => e.Scale6).HasColumnName("scale_6");

                entity.Property(e => e.Scale60).HasColumnName("scale_60");

                entity.Property(e => e.Scale61).HasColumnName("scale_61");

                entity.Property(e => e.Scale62).HasColumnName("scale_62");

                entity.Property(e => e.Scale63).HasColumnName("scale_63");

                entity.Property(e => e.Scale64).HasColumnName("scale_64");

                entity.Property(e => e.Scale65).HasColumnName("scale_65");

                entity.Property(e => e.Scale66).HasColumnName("scale_66");

                entity.Property(e => e.Scale67).HasColumnName("scale_67");

                entity.Property(e => e.Scale68).HasColumnName("scale_68");

                entity.Property(e => e.Scale69).HasColumnName("scale_69");

                entity.Property(e => e.Scale7).HasColumnName("scale_7");

                entity.Property(e => e.Scale70).HasColumnName("scale_70");

                entity.Property(e => e.Scale71).HasColumnName("scale_71");

                entity.Property(e => e.Scale72).HasColumnName("scale_72");

                entity.Property(e => e.Scale73).HasColumnName("scale_73");

                entity.Property(e => e.Scale74).HasColumnName("scale_74");

                entity.Property(e => e.Scale75).HasColumnName("scale_75");

                entity.Property(e => e.Scale76).HasColumnName("scale_76");

                entity.Property(e => e.Scale77).HasColumnName("scale_77");

                entity.Property(e => e.Scale78).HasColumnName("scale_78");

                entity.Property(e => e.Scale79).HasColumnName("scale_79");

                entity.Property(e => e.Scale8).HasColumnName("scale_8");

                entity.Property(e => e.Scale80).HasColumnName("scale_80");

                entity.Property(e => e.Scale81).HasColumnName("scale_81");

                entity.Property(e => e.Scale82).HasColumnName("scale_82");

                entity.Property(e => e.Scale83).HasColumnName("scale_83");

                entity.Property(e => e.Scale84).HasColumnName("scale_84");

                entity.Property(e => e.Scale85).HasColumnName("scale_85");

                entity.Property(e => e.Scale86).HasColumnName("scale_86");

                entity.Property(e => e.Scale87).HasColumnName("scale_87");

                entity.Property(e => e.Scale88).HasColumnName("scale_88");

                entity.Property(e => e.Scale89).HasColumnName("scale_89");

                entity.Property(e => e.Scale9).HasColumnName("scale_9");

                entity.Property(e => e.Scale90).HasColumnName("scale_90");

                entity.Property(e => e.Scale91).HasColumnName("scale_91");

                entity.Property(e => e.Scale92).HasColumnName("scale_92");

                entity.Property(e => e.Scale93).HasColumnName("scale_93");

                entity.Property(e => e.Scale94).HasColumnName("scale_94");

                entity.Property(e => e.Scale95).HasColumnName("scale_95");

                entity.Property(e => e.Scale96).HasColumnName("scale_96");

                entity.Property(e => e.Scale97).HasColumnName("scale_97");

                entity.Property(e => e.Scale98).HasColumnName("scale_98");

                entity.Property(e => e.Scale99).HasColumnName("scale_99");

                entity.Property(e => e.StatusCode).HasColumnName("status_code");

                entity.Property(e => e.StatusMessage).HasColumnName("status_message");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<VCampaignAnalyseMaxResponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_ANALYSE_MaxResponse", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("Test_ID");
            });

            modelBuilder.Entity<VCampaignAnalyseUnPivotPlong>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_Analyse_UnPivot_PLong", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<VCampaignAnalyseUnPivotPshort>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_Analyse_UnPivot_Pshort", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(8);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Val).HasColumnName("val");
            });

            modelBuilder.Entity<VCampaignAnalyseUnPivotScaleForRank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_Analyse_UnPivot_ScaleForRank", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VCampaignApplicantDash>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_ApplicantDash", "Anthony_TRMaster");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_ID");

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.CovL).HasMaxLength(150);

                entity.Property(e => e.Cv)
                    .HasColumnName("cv")
                    .HasMaxLength(150);

                entity.Property(e => e.Nme)
                    .HasColumnName("nme")
                    .HasMaxLength(101);

                entity.Property(e => e.PCent)
                    .HasColumnName("pCent")
                    .HasMaxLength(4000);

                entity.Property(e => e.PercentageFit).HasColumnType("numeric(14, 4)");

                entity.Property(e => e.PsyR).HasMaxLength(150);
            });

            modelBuilder.Entity<VCampaignCampaignDash>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_CampaignDash", "Anthony_TRMaster");

                entity.Property(e => e.AdvertTitle).HasMaxLength(250);

                entity.Property(e => e.AmendSv)
                    .HasColumnName("AmendSV")
                    .HasMaxLength(50);

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.CampaignName).HasMaxLength(150);

                entity.Property(e => e.CampaignQuestion1).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion2).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion3).HasMaxLength(250);

                entity.Property(e => e.CampaignQuestion4).HasMaxLength(250);

                entity.Property(e => e.CompanyInternalReference).HasMaxLength(250);

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.DateClosedText).HasMaxLength(50);

                entity.Property(e => e.Dateclose)
                    .HasColumnName("dateclose")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.SessionVariable).HasMaxLength(50);

                entity.Property(e => e.SpendToDate).HasColumnType("money");

                entity.Property(e => e.SpendingCap).HasColumnType("money");
            });

            modelBuilder.Entity<VCampaignMasterRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignMaster_Roles", "Anthony_TRMaster");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignMasterSectorType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignMaster_SectorType", "Anthony_TRMaster");

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignMbtiMaxScale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_MBTI_MaxScale", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("test_ID");
            });

            modelBuilder.Entity<VCampaignMbtiScalesByValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_MBTI_ScalesByValue", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("test_ID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VCampaignQtyApplicant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_QtyApplicant", "Anthony_TRMaster");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignReportPrintLastSerial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignReportPrintLastSerial", "Anthony_TRMaster");

                entity.Property(e => e.CampaignMasterId).HasColumnName("CampaignMaster_ID");

                entity.Property(e => e.Link).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignRoleBySectorType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignRoleBySectorType", "Anthony_TRMaster");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignRoleName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_RoleName", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignRoleSelected>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_RoleSelected", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignRolesMinId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignRolesMinID", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignRolesOverlap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignRolesOverlap", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.MbtiType)
                    .HasColumnName("MBTI_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignSelectNameInd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_CampaignSelectNameInd", "Anthony_TRMaster");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VCampaignStringAggSuggMbti>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_StringAGG_SuggMBTI", "Anthony_TRMaster");

                entity.Property(e => e.CampaignId).HasColumnName("Campaign_ID");

                entity.Property(e => e.Mbti)
                    .HasColumnName("MBTI")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<VCampaignUnPivotMbtiresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_UnPivot_MBTIResponse", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("test_ID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VCampaignUserAuth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_UserAuth", "Anthony_TRMaster");

                entity.Property(e => e.Nmes)
                    .HasColumnName("nmes")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<VCampaignUserAuthDisp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Campaign_UserAuthDisp", "Anthony_TRMaster");

                entity.Property(e => e.Nmes)
                    .HasColumnName("nmes")
                    .HasMaxLength(4000);

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VCurrentTestId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Current_TestID", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("TestID");
            });

            modelBuilder.Entity<VDept1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept1", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept10>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept10", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept2", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept3", "Anthony_TRMaster");

                entity.Property(e => e.Expr1).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept4", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept5", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept6", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept7", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept8>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept8", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VDept9>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Dept9", "Anthony_TRMaster");

                entity.Property(e => e.Checksum).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VMatchEmailsCurrentLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MatchEmailsCurrentLogin", "Anthony_TRMaster");

                entity.Property(e => e.EmailAdd)
                    .HasColumnName("emailAdd")
                    .HasMaxLength(80);

                entity.Property(e => e.MaxEnqInd).HasColumnName("MaxEnq_Ind");

                entity.Property(e => e.SessVarInd).HasColumnName("SessVar_Ind");
            });

            modelBuilder.Entity<VMbtiMaxScale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MBTI_MaxScale", "Anthony_TRMaster");

                entity.Property(e => e.TestId).HasColumnName("test_ID");
            });

            modelBuilder.Entity<VMbtiScalesByValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MBTI_ScalesByValue", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("test_ID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VMonitorTestInvite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_MonitorTestInvite", "Anthony_TRMaster");

                entity.Property(e => e.BfmTrueId)
                    .HasColumnName("BFM_True_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250);

                entity.Property(e => e.Fname)
                    .HasColumnName("FName")
                    .HasMaxLength(50);

                entity.Property(e => e.Lname)
                    .HasColumnName("LName")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportPrintId).HasColumnName("ReportPrint_ID");

                entity.Property(e => e.TestId)
                    .HasColumnName("TestID")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VRanCharNoSym>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RanChar_NoSym", "Anthony_TRMaster");

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VRandHelper>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RandHelper", "Anthony_TRMaster");

                entity.Property(e => e.R).HasColumnName("r");
            });

            modelBuilder.Entity<VRandNumGen>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RandNumGen", "Anthony_TRMaster");
            });

            modelBuilder.Entity<VRandomCharGenerator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_RandomCharGenerator", "Anthony_TRMaster");

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VSlAllocNextAlloc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_Sl_Alloc_NextAlloc", "Anthony_TRMaster");

                entity.Property(e => e.SlallocTrans).HasColumnName("SLAllocTrans");
            });

            modelBuilder.Entity<VSlAllocQtyAlloc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_AllocQtyAlloc", "Anthony_TRMaster");
            });

            modelBuilder.Entity<VSlAllocationTrans>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_AllocationTrans", "Anthony_TRMaster");

                entity.Property(e => e.SltransNo).HasColumnName("SLTRansNo");

                entity.Property(e => e.UnallCrSltrans).HasColumnName("UnallCr_SLTrans");

                entity.Property(e => e.Unallocated).HasColumnType("money");

                entity.Property(e => e.UnallocatedCredit).HasColumnType("money");
            });

            modelBuilder.Entity<VSlBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_Balance", "Anthony_TRMaster");

                entity.Property(e => e.CrTotal)
                    .HasColumnName("Cr_Total")
                    .HasMaxLength(4000);

                entity.Property(e => e.Date)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DrTotal)
                    .HasColumnName("Dr_Total")
                    .HasMaxLength(4000);

                entity.Property(e => e.File).HasMaxLength(150);

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Trans)
                    .HasColumnName("TRans")
                    .HasMaxLength(81);

                entity.Property(e => e.Unallocated).HasColumnType("money");
            });

            modelBuilder.Entity<VSlCredits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_Credits", "Anthony_TRMaster");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unallocated).HasColumnType("money");
            });

            modelBuilder.Entity<VSlDebits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_Debits", "Anthony_TRMaster");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Unallocated).HasColumnType("money");
            });

            modelBuilder.Entity<VSlRunningBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_RunningBalance", "Anthony_TRMaster");

                entity.Property(e => e.Balance).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CrTotal)
                    .HasColumnName("cr_total")
                    .HasMaxLength(4000);

                entity.Property(e => e.Date)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DrTotal)
                    .HasColumnName("Dr_Total")
                    .HasMaxLength(4000);

                entity.Property(e => e.File)
                    .HasColumnName("file")
                    .HasMaxLength(150);

                entity.Property(e => e.SltransNo)
                    .HasColumnName("SLTRansNo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Trans)
                    .HasColumnName("trans")
                    .HasMaxLength(81);
            });

            modelBuilder.Entity<VSlToBeInvoiced>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SL_ToBeInvoiced", "Anthony_TRMaster");

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.NextBillingDate).HasColumnType("date");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<VSv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SV", "Anthony_TRMaster");

                entity.Property(e => e.Expr1).HasMaxLength(1);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<VSystemProcsAndFunctions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_System_ProcsAndFunctions", "Anthony_TRMaster");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dte)
                    .HasColumnName("dte")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VSystemTablesAndViews>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_SystemTablesAndViews", "Anthony_TRMaster");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dte)
                    .HasColumnName("dte")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VUnPivotMbtiresponse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UnPivot_MBTIResponse", "Anthony_TRMaster");

                entity.Property(e => e.Scale).HasMaxLength(128);

                entity.Property(e => e.TestId).HasColumnName("test_ID");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<VUserVal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UserVal", "Anthony_TRMaster");

                entity.Property(e => e.CompanyName).HasMaxLength(150);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.OpeningMenu).HasMaxLength(50);

                entity.Property(e => e.SessionVariable).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.UserInd).HasMaxLength(50);
            });

            modelBuilder.Entity<VUserValidationLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_UserValidationLog", "Anthony_TRMaster");

                entity.Property(e => e.Nme)
                    .HasColumnName("nme")
                    .HasMaxLength(101);

                entity.Property(e => e.UserIndex).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VValVarNoDups>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ValVarNoDups", "Anthony_TRMaster");

                entity.Property(e => e.SessionVariable).HasMaxLength(50);
            });

            modelBuilder.Entity<ValVarDupMin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ValVarDupMin", "Anthony_TRMaster");

                entity.Property(e => e.Dl).HasColumnName("dl");

                entity.Property(e => e.Sv).HasColumnName("sv");
            });

            modelBuilder.Entity<ValidationVariable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ValidationVariable", "Anthony_TRMaster");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department10).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department3).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department4).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department8).HasDefaultValueSql("((0))");

                entity.Property(e => e.Department9).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentSessVar)
                    .HasColumnName("PArentSessVar")
                    .HasMaxLength(50);

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.SessVarInd).ValueGeneratedOnAdd();

                entity.Property(e => e.SessionVariable).HasMaxLength(50);

                entity.Property(e => e.UserInd).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(150);
            });

            modelBuilder.Entity<Years>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Years", "Anthony_TRMaster");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
