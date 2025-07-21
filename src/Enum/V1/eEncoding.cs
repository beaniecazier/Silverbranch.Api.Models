using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

/// <summary>
/// The way in which data will be encoded,
///
/// for use in the Scaffolder tool to determine code
/// needed to parse and unpack data
/// </summary>
public enum eEncoding
{
    [Display(Name = "Error",
        Description = """
        An unspecified or unknown encoding, usually indicating an error has occured or the value was never set.
        """)]
    ERROR,
    [Display(Name = "None",
        Description = """
        An unspecified or unknown encoding.
        """)]
    None,
    
    
    
    // Codes & Identifiers
    ShortCode,          // e.g., "US", "USD", "NY"
    CountryCode,        // ISO 3166-1 alpha-2 or alpha-3
    PhoneCountryCode,   // e.g., "+1", "+44"
    LanguageCode,       // ISO 639-1/2 codes like "en", "fr"
    CurrencyCode,       // e.g., "USD", "EUR"
    Uuid,               // e.g., "550e8400-e29b-41d4-a716-446655440000"
    HexColor,           // e.g., "#FF5733", "#FFF"
    [Display(Name = "Base64",
        Description = """
        Encodes binary data into text using base-64 representation.
        """)]
    Base64,
    [Display(Name = "Hexadecimal",
        Description = """
        Encodes data using hexadecimal representation.
        """)]
    Hex,
    [Display(Name = "Binary",
        Description = """
        Raw binary format, usually non-human readable.
        """)]
    Binary,
    
    // 
    [Display(Name = "ASCII",
        Description = """
        American Standard Code for Information Interchange.
        """)]
    Ascii,
    [Display(Name = "UTF-8",
        Description = """
        8-bit Unicode Transformation Format.
        """)]
    Utf8,
    [Display(Name = "UTF-16",
        Description = """
        16-bit Unicode Transformation Format.
        """)]
    Utf16,
    [Display(Name = "UTF-32",
        Description = """
        32-bit Unicode Transformation Format.
        """)]
    Utf32,
    
    
    // Structured data strings
    [Display(Name = "JSON Encoding",
        Description = """
        Encoding rules specific to JSON formatting.
        """)]
    Json,
    [Display(Name = "XML Encoding",
        Description = """
        Encoding data using XML entities and structures.
        """)]
    Xml,
    [Display(Name = "HTML Encoding",
        Description = """
        Encodes characters for safe use in HTML (e.g., &amp;).
        """)]
    HtmlEncoding,
    [Display(Name = "YAML",
        Description = """
        Human-readable data serialization standard.
        """)]
    Yaml,
    [Display(Name = "CSV",
        Description = """
        Comma-Separated Values as a text serialization.
        """)]
    Csv,
    
    
    
    
    
    
    
    
    [Display(Name = "GZip",
        Description = """
        GZip cmcpression encoding.
        """)]
    Gzip,
    [Display(Name = "Brotli",
        Description = """
        Efficient compression developed by Google.
        """)]
    Brotli,
    [Display(Name = "Deflate",
        Description = """
        Lossless data compression algorithm.
        """)]
    Deflate,
    [Display(Name = "Zlib",
        Description = """
        Compression format using DEFLATE algorithm.
        """)]
    Zlib,
    [Display(Name = "Bzip2",
        Description = """
        High-compression algorithm using Burrows–Wheeler transform.
        """)]
    Bzip2,
    [Display(Name = "LZMA",
        Description = """
        Lempel-Ziv-Markov chain compression algorithm.
        """)]
    Lzma,
    [Display(Name = "MessagePack",
        Description = """
        Efficient binary serialization format.
        """)]
    MsgPack,
    [Display(Name = "Protocol Buffers",
        Description = """
        Compact, fast, binary serialization from Google.
        """)]
    Protobuf,
    [Display(Name = "Apache Avro",
        Description = """
        Row-oriented binary serialization format.
        """)]
    Avro,
    [Display(Name = "Apache Thrift",
        Description = """
        Serialization framework for scalable cross-language services.
        """)]
    Thrift,
    [Display(Name = "JWT",
        Description = """
        JSON Web Token encoding (base64url encoded header.payload.signature).
        """)]
    Jwt,
    [Display(Name = "PEM",
        Description = """
        Privacy-Enhanced Mail: Base64-encoded certificates/keys with headers.
        """)]
    Pem,
    [Display(Name = "DER",
        Description = """
        Distinguished Encoding Rules: binary format for X.509 and ASN.1.
        """)]
    Der,
    
    
    
    
    // Date formats
    IsoDate,         // yyyy-MM-dd
    IsoDateTime,     // yyyy-MM-ddTHH:mm:ss
    BasicDate,       // yyyyMMdd
    DmySlash,        // dd/MM/yyyy
    MdyDash,         // MM-dd-yyyy
    FullDateTime,    // dddd, MMMM d, yyyy h:mm tt
    UnixTimestamp,   // Seconds since 1970-01-01

    // Time formats
    Time24Hour,      // HH:mm
    Time12Hour,      // hh:mm tt
    IsoTime,         // HH:mm:ss
    IsoUtc,          // yyyy-MM-ddTHH:mm:ssZ

    // Numeric
    Currency,        // $1,234.56
    FixedPoint,      // 1234.56
    Exponential,     // 1.23E+03
    Percentage,      // 56%
    IntegerGrouping, // 1,000,000

    // Other templated formats
    CreditCard,      // 1234-5678-9012-3456
    Ssn,             // 123-45-6789
    PhoneUs,         // (123) 456-7890
    PostalCodeUs,    // 12345 or 12345-6789
    Iban,            // International Bank Account Number
    
    
    
    
    
    
    
    
    

    // Identity/User-related
    Username,
    PersonName,         // First or last name
    EmailAddress,
    PhoneNumber,

    // Web & File
    [Display(Name = "URL Encoding",
        Description = """
                      Encodes data for safe transmission in URLs.
                      """)]
    Url,
    FilePath,

    // Textual content
    Sentence,
    Paragraph,
    BlockText,

    // Templated or formatted strings
    DateString,         // e.g., "yyyy-MM-dd"
    TimeString,         // e.g., "HH:mm"
    DateTimeString,     // e.g., "yyyy-MM-ddTHH:mm:ssZ"

    // Domain-specific
    BarcodeString,      // EAN/UPC/ISBN-like codes
    Hashtag,            // e.g., "#OpenAI"
    Handle,             // e.g., "@username"

    // Numeric representation
    CurrencyString,     // "$1,000.00"
    PercentageString,   // "75%"
    IntegerString,      // "123456"
    DecimalString       // "123.45"
}
 
 
/*
 
| Enum Value     | Pattern                      | Example Output                  |
| -------------- | ---------------------------- | ------------------------------- |
| `IsoDate`      | `yyyy-MM-dd`                 | 2025-06-12                      |
| `BasicDate`    | `yyyyMMdd`                   | 20250612                        |
| `DmySlash`     | `dd/MM/yyyy`                 | 12/06/2025                      |
| `Time12Hour`   | `hh:mm tt`                   | 03:45 PM                        |
| `FullDateTime` | `dddd, MMMM d, yyyy h:mm tt` | Thursday, June 12, 2025 3:45 PM |

*/

/*
 * whqt are different kinds of strings, there general length ranges and are the generall ascii, utf or utf16?
like for example  names, links, file paths, emails, sentences, blocks of text or descriptions, and short string codes for things like country calling codes are all going to be different kinds of string, following different rules and have different expected lengths and encodings


ChatGPT said:
Excellent question — you're pointing at a foundational design concern in modern software systems: not all strings are created equal.

Strings are used to represent semantically distinct types of data, and each type has typical lengths, formats, encodings, and validation rules.

Below is a classification of common types of strings with details on:

Purpose

Expected length range

Encoding used

Character set

Examples

Notes or validation rules

🔠 Classification of Common String Types
Type	Purpose	Typical Length	Encoding	Character Set	Example	Notes
Short Code	Abbreviations, IDs	2–6 chars	ASCII or UTF-8	A-Z, 0-9	US, INR, USD	Often fixed-length; no spaces
Country Code	ISO 3166-1 alpha-2 or alpha-3	2–3 chars	ASCII	A-Z	US, GB, DE	Strict format
Phone Country Code	Telephony prefix	1–4 digits	ASCII	0–9	+1, +44, +91	Often prefixed with +
Username	User handle or ID	3–20 chars	UTF-8 or ASCII	Alphanumeric/_	user_01, johnDoe	Lowercase preferred, no spaces
Name (First/Last)	Person name	2–50 chars	UTF-8 or UTF-16	Unicode	María, Nguyễn	Needs Unicode for internationalization
Email Address	User contact	6–254 chars	ASCII (mostly)	A-Z, 0-9, symbols	user@example.com	Format: local@domain.tld
Phone Number	Contact number	7–20 chars	ASCII	0–9, +, -, space	+1 (555) 123-4567	E.164: max 15 digits
URL / Link	Web resource locator	10–2000+ chars	UTF-8 (escaped)	URI-safe	https://example.com	RFC 3986 compliant
File Path	OS file location	10–255 chars	UTF-8 or UTF-16	Filesystem-specific	C:\Users\Name\file.txt	Windows uses UTF-16
UUID / GUID	Unique identifier	36 chars	ASCII	Hex + dashes	550e8400-e29b-41d4...	Canonical 8-4-4-4-12 format
Color Code (Hex)	Color value	4–9 chars	ASCII	#0–9A–F	#FFF, #00FFCC	Case-insensitive
Date String	Date/time representation	8–30 chars	ASCII	0–9, -, :, T, Z	2025-06-12T15:00Z	Often ISO 8601
Sentence	Description/phrase	20–150 chars	UTF-8 or UTF-16	Unicode	Welcome to the site.	Might need punctuation
Paragraph/Text	Rich user-generated content	100–5000+ chars	UTF-8 or UTF-16	Unicode	Lorem ipsum...	Multiline, rich text possible
JSON/XML/YAML	Structured string data	20–100,000+ chars	UTF-8 or UTF-16	Unicode	{ "name": "Alice" }	Needs special parsing
Barcode String	Machine-readable ID	8–14 chars	ASCII	Numeric or mixed	0123456789012	Often fixed-length (EAN, UPC)
Hashtag / Handle	Social tag or ref	2–30 chars	UTF-8	Unicode + _	#OpenAI, @elonmusk	Regex-valid
Language Code	ISO 639-1/2	2–3 chars	ASCII	a–z	en, fr, zh	Lowercase

🧩 Encoding Summary
String Type	Encoding Usually Used
Codes & IDs	ASCII or UTF-8
Names, Descriptions	UTF-8 or UTF-16
Paths (Windows)	UTF-16
Web Data (URLs, JSON)	UTF-8
Barcodes, UUIDs	ASCII
Emails, Dates, Numbers	ASCII (limited UTF-8)
User-generated Content	UTF-8 or UTF-16

✅ Why This Matters
Understanding the type of string helps you:

Choose the right validation rules (regex, formats)

Apply the appropriate encoding

Set reasonable length limits (UX + DB design)

Enable internationalization (i18n) where needed

👇 Want more?
I can generate:

A C# enum for StringDataType

Metadata (e.g. max length, sample format, encoding)

Regex patterns for each type

Validation helper methods (e.g., IsValidEmail(string s))

Would you like a code implementation of this?
*/