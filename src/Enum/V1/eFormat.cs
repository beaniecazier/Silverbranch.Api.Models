using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

/// <summary>
/// The way in which data will be encoded,
///
/// for use in the Scaffolder tool to determine code
/// needed to parse and unpack data
/// </summary>
public enum eFormat
{
    // System
    [Display(Name = "ERROR",
        Description = """
        Flagged as being in an error state
        """)]
    ERROR,
    [Display(Name ="None",
        Description = """
        No specified format selected
        """)]
    None,

    // Text
    [Display(Name ="Any text",
        Description = """
        Any allowable text value                
        """)]
    AnyText,
    [Display(Name ="Regex",
        Description = """
        A Regular Expression often used as a search term
        """)]
    Regex,

    // Digital Location
    IpAddressV4,
    IpAddressV6,
    MacAddress,
    Hostname,
    [Display(Name ="Email",
        Description = """
        An email formatted string (e.g., user@example.com).
        """)]
    Email,
    [Display(Name ="Hyperlink",
        Description = """
        A hyperlink or URL starting with http(s).
        """)]
    Hyperlink,
    [Display(Name ="FileLocation",
        Description = """
        A path to a local or remote file.
        """)]
    FileLocation,

    //Date and Time
    [Display(Name ="Date",
        Description = """
        A date value (YYYY-MM-DD).
        """)]
    Date,
    [Display(Name ="Time",
        Description = """
        A time value (e.g., 14:30:00).
        """)]
    Time,
    [Display(Name ="DateTime",
        Description = """
        A date and time combined (e.g., 2025-06-12T14:30:00), where the time zone is unspecified
        """)]
    DateTime,
    [Display(Name ="DateTimeUTC",
        Description = """
        "A date and time combined (e.g., 2025-06-12T14:30:00) where the time zone is assumed to be UTC"
        """)]
    DateTimeUtc,
    Duration,

    // File formats
    [Display(Name ="Csv",
        Description = """
        Comma-separated values format.
        """)]
    Csv,
    [Display(Name ="Json",
        Description = """
        JavaScript Object Notation.
        """)]
    Json,
    [Display(Name ="Xml",
        Description = """
        Extensible Markup Language.
        """)]
    Xml,
    [Display(Name = "XAML",
        Description = """
        Extensible Application Markup Language.
        """)]
    Xaml,
    [Display(Name ="Yaml",
        Description = """
        YAML Ain’t Markup Language structured data file.
        """)]
    Yaml,
    [Display(Name ="PDF",
        Description = """
        A document in Portable Document Format (.pdf).
        """)]
    Pdf,
    [Display(Name ="Html",
        Description = """
        Hypertext Markup Language content or file.
        """)]
    Html,
    [Display(Name ="Markdown",
        Description = """
        Lightweight markup language (e.g., README.md).
        """)]
    Markdown,
    [Display(Name ="Excel",
        Description = """
        A Microsoft Excel spreadsheet (.xls, .xlsx).
        """)]
    Excel,
    [Display(Name ="Word",
        Description = """
        A Microsoft Word document (.doc, .docx).
        """)]
    Word,
    [Display(Name ="LaTex",
        Description = """
        YAML Ain’t Markup Language structured data file.
        """)]
    LaTex,
    [Display(Name ="C#",
        Description = """
        C# code/file.
        """)]
    CSharp,
    [Display(Name ="Python",
        Description = """
        Python code/file.
        """)]
    Python,
    [Display(Name ="Javascript",
        Description = """
        Javascript code/file.
        """)]
    Javascript,
    [Display(Name ="Rust",
        Description = """
        Rust code/file.
        """)]
    Rust,
    Audio,
    Video,

    [Display(Name ="Image",
        Description = """
        A raster or vector image format (e.g., PNG, JPG, SVG).
        """)]
    Image,
    [Display(Name ="Money",
        Description = """
        A currency value (e.g., $123.45).
        """)]
    Money,
    [Display(Name ="ColorHex",
        Description = """
        A hexadecimal color code (e.g., #FF5733).
        """)]
    ColorHex,
    [Display(Name ="EAN",
        Description = """
        A European Article Number barcode format.
        """)]
    EanBarcode,
    [Display(Name ="UPC",
        Description = """
        A Universal Product Code barcode format.
        """)]
    UpcBarcode,
    [Display(Name ="Name",
        Description = """
        A name.
        """)]
    Name,
    
    PostalCode,
    Country,
    Langage,
    LanguageCode,
    
    Token,
    Password,
    Uuid,
    NanoId,
    Enum,
}