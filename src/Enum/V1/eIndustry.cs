using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum eIndustry
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    
    [Display(Name = "Humanitarian Volunteer")]
    HumanitarianVolunteer = 0,
    
    [Display(Name = "Agriculture & Farming")]
    AgricultureFarming = 1,

    [Display(Name = "Forestry & Logging")]
    ForestryLogging = 2,

    [Display(Name = "Fishing & Aquaculture")]
    FishingAquaculture = 3,

    [Display(Name = "Mining & Quarrying")]
    MiningQuarrying = 4,

    [Display(Name = "Oil & Gas Extraction")]
    OilGasExtraction = 5,

    [Display(Name = "Automotive Manufacturing")]
    AutomotiveManufacturing = 6,

    [Display(Name = "Chemical Manufacturing")]
    ChemicalManufacturing = 7,

    [Display(Name = "Electronics & Semiconductor Manufacturing")]
    ElectronicsManufacturing = 8,

    [Display(Name = "Food & Beverage Processing")]
    FoodBeverageProcessing = 9,

    [Display(Name = "Machinery & Equipment Manufacturing")]
    MachineryManufacturing = 10,

    [Display(Name = "Textile & Apparel")]
    TextileApparel = 11,

    [Display(Name = "Residential & Commercial Construction")]
    ConstructionResidentialCommercial = 12,

    [Display(Name = "Civil Engineering")]
    CivilEngineering = 13,

    [Display(Name = "Architecture & Urban Planning")]
    ArchitectureUrbanPlanning = 14,

    [Display(Name = "Interior Design")]
    InteriorDesign = 15,

    [Display(Name = "Software Development")]
    SoftwareDevelopment = 16,

    [Display(Name = "Cybersecurity")]
    Cybersecurity = 17,

    [Display(Name = "Artificial Intelligence & Machine Learning")]
    AIMachineLearning = 18,

    [Display(Name = "IT Consulting & Services")]
    ITConsultingServices = 19,

    [Display(Name = "Cloud Computing")]
    CloudComputing = 20,

    [Display(Name = "Hardware & Semiconductor")]
    HardwareSemiconductor = 21,

    [Display(Name = "Banking & Financial Services")]
    BankingFinancialServices = 22,

    [Display(Name = "Investment & Asset Management")]
    InvestmentAssetManagement = 23,

    [Display(Name = "Insurance")]
    Insurance = 24,

    [Display(Name = "Accounting & Auditing")]
    AccountingAuditing = 25,

    [Display(Name = "Consulting Services")]
    ConsultingServices = 26,

    [Display(Name = "Hospitals & Healthcare Providers")]
    HealthcareProviders = 27,

    [Display(Name = "Biotechnology & Life Sciences")]
    BiotechnologyLifeSciences = 28,

    [Display(Name = "Pharmaceuticals")]
    Pharmaceuticals = 29,

    [Display(Name = "Medical Devices & Equipment")]
    MedicalDevicesEquipment = 30,

    [Display(Name = "Mental Health Services")]
    MentalHealthServices = 31,

    [Display(Name = "Primary & Secondary Schools")]
    PrimarySecondaryEducation = 32,

    [Display(Name = "Universities & Higher Education")]
    HigherEducation = 33,

    [Display(Name = "Research Institutions")]
    ResearchInstitutions = 34,

    [Display(Name = "Educational Technology (EdTech)")]
    EducationalTechnology = 35,

    [Display(Name = "Publishing")]
    Publishing = 36,

    [Display(Name = "Film & Television Production")]
    FilmTelevision = 37,

    [Display(Name = "Music & Performing Arts")]
    MusicPerformingArts = 38,

    [Display(Name = "Gaming & Esports")]
    GamingEsports = 39,

    [Display(Name = "Advertising & Marketing")]
    AdvertisingMarketing = 40,

    [Display(Name = "E-commerce")]
    ECommerce = 41,

    [Display(Name = "Fashion & Apparel")]
    FashionApparel = 42,

    [Display(Name = "Luxury Goods")]
    LuxuryGoods = 43,

    [Display(Name = "Grocery & Supermarkets")]
    GrocerySupermarkets = 44,

    [Display(Name = "Airlines & Aviation")]
    AirlinesAviation = 45,

    [Display(Name = "Rail & Public Transit")]
    RailPublicTransit = 46,

    [Display(Name = "Shipping & Maritime")]
    ShippingMaritime = 47,

    [Display(Name = "Trucking & Freight")]
    TruckingFreight = 48,

    [Display(Name = "Renewable Energy (Solar, Wind, Hydro)")]
    RenewableEnergy = 49,

    [Display(Name = "Electric Power Generation")]
    ElectricPowerGeneration = 50,

    [Display(Name = "Water Supply & Management")]
    WaterManagement = 51,

    [Display(Name = "Waste Management")]
    WasteManagement = 52,

    [Display(Name = "Federal & Local Government")]
    Government = 53,

    [Display(Name = "Law Enforcement & Security")]
    LawEnforcementSecurity = 54,

    [Display(Name = "Postal & Delivery Services")]
    PostalDeliveryServices = 55,

    [Display(Name = "Social Services")]
    SocialServices = 56,

    [Display(Name = "Hotels & Resorts")]
    HotelsResorts = 57,

    [Display(Name = "Restaurants & Food Services")]
    RestaurantsFoodServices = 58,

    [Display(Name = "Travel & Tourism Agencies")]
    TravelTourism = 59,

    [Display(Name = "Charity Organizations")]
    CharityOrganizations = 60,

    [Display(Name = "Environmental Advocacy")]
    EnvironmentalAdvocacy = 61,

    [Display(Name = "Human Rights & Social Justice")]
    HumanRightsSocialJustice = 62
}