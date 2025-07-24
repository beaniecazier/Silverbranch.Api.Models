using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum eOrganizationStatus
{

    [Display(Name = "ERROR")] ERROR = -1,
    [Display(Name = "Active")] Active = 0,
    [Display(Name = "Inactive")] Inactive = 1,
    [Display(Name = "Closed")] Closed = 2,
    
    /// <summary>
    /// These are all from an ai generated list
    /// needs reviewing to determine if they really fall under the context of this enum and if they provide value
    /// </summary>
    [Display(Name = "Operating")] Operating,
    [Display(Name = "Trading")] Trading,
    [Display(Name = "Running")] Running,
    [Display(Name = "Open")] Open,
    [Display(Name = "Staffed")] Staffed,
    [Display(Name = "Scaling")] Scaling,
    [Display(Name = "Pivoting")] Pivoting,
    [Display(Name = "Rebranding")] Rebranding,
    [Display(Name = "Recovering")] Recovering,
    [Display(Name = "Paused")] Paused,
    [Display(Name = "Suspended")] Suspended,
    [Display(Name = "On-Hold")] OnHold,
    [Display(Name = "Seasonal")] Seasonal,
    [Display(Name = "Limited")] Limited,
    [Display(Name = "Under Renovation")] UnderRenovation,
    [Display(Name = "Restructuring")] Restructuring,
    [Display(Name = "Under Review")] UnderReview,    
    [Display(Name = "Dissolved")] Dissolved,
    [Display(Name = "Defunct")] Defunct,
    [Display(Name = "Liquidated")] Liquidated,
    [Display(Name = "Bankrupt")] Bankrupt,
    [Display(Name = "Mothballed")] Mothballed,
    [Display(Name = "Merged")] Merged,
    [Display(Name = "Acquired")] Acquired,
    [Display(Name = "Retired")] Retired,    
    [Display(Name = "Emerging")] Emerging,
    [Display(Name = "Pre-Launch")] PreLaunch,
    [Display(Name = "Stealth")] Stealth,
    [Display(Name = "Incubating")] Incubating,
    [Display(Name = "Spinning Off")] SpinningOff,
    [Display(Name = "Pending")] Pending,
    [Display(Name = "Onboarding")] Onboarding,
    [Display(Name = "Auditing")] Auditing,
    [Display(Name = "Registered")] Registered,
    [Display(Name = "Listed")] Listed,
    [Display(Name = "Compliant")] Compliant,
    [Display(Name = "Accredited")] Accredited,    
    [Display(Name = "Profitable")] Profitable,
    [Display(Name = "Unprofitable")] Unprofitable,
    [Display(Name = "Funded")] Funded,
    [Display(Name = "Bootstrapped")] Bootstrapped,
    [Display(Name = "Public")] Public,
    [Display(Name = "Private")] Private,
    [Display(Name = "Remote-First")] RemoteFirst,
    [Display(Name = "Hybrid")] Hybrid,
    [Display(Name = "OnSite")] OnSite,
    [Display(Name = "Global")] Global,
    [Display(Name = "Local")] Local,
}