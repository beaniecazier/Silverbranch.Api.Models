using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

/// <summary>
/// data, types and descriptions taken from
/// https://learn.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql?view=sql-server-ver17
/// </summary>
public enum eDbType
{
    [Display(Name = "ERROR",
        Description = "")]
    ERROR = -1,
    
    // Exact numerics
    [Display(Name = "tinyint",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql?view=sql-server-ver17
        
        Exact-number data types that use integer data.
        To save space in the database, use the smallest data type that can reliably contain all possible values.
        tinyint has a range of 0 to 255, or in other words is 1 byte.
        """)]
    TinyInt = 0,
    [Display(Name = "smallint",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql?view=sql-server-ver17
        
        Exact-number data types that use integer data.
        To save space in the database, use the smallest data type that can reliably contain all possible values.
        smallint has a range of -32,768 to 32,767, or in other words is 2 byte.
        """)]
    SmallInt = 1,
    [Display(Name = "int",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql?view=sql-server-ver17
        
        Exact-number data types that use integer data.
        To save space in the database, use the smallest data type that can reliably contain all possible values.
        int has a range of -2,147,483,648 to 2,147,483,647, or in other words is 1 byte.
        """)]
    Int = 2,
    [Display(Name = "bigint",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql?view=sql-server-ver17
        
        Exact-number data types that use integer data.
        To save space in the database, use the smallest data type that can reliably contain all possible values.
        bigint has a range of -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807, or in other words is 8 byte.
        """)]
    BigInt = 3,
    [Display(Name = "bit",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql?view=sql-server-ver17
        
        An integer data type that can take a value of 1, 0, or NULL."
        """)]
    Bit = 4,
    [Display(Name = "decimal",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/decimal-and-numeric-transact-sql?view=sql-server-ver17
        
        decimal and numeric are numeric data types that have a fixed precision and scale.
        decimal and numeric are synonyms and can be used interchangeably.
        """)]
    Decimal = 5,
    [Display(Name = "numeric",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/decimal-and-numeric-transact-sql?view=sql-server-ver17
        
        decimal and numeric are numeric data types that have a fixed precision and scale.
        decimal and numeric are synonyms and can be used interchangeably.
        """)]
    Numeric = 6,
    [Display(Name = "money",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/money-and-smallmoney-transact-sql?view=sql-server-ver17
        
        A data type that represent monetary or currency values.
        money has a range of -922,337,203,685,477.5808 to 922,337,203,685,477.5807
        (-922,337,203,685,477.58 to 922,337,203,685,477.58 for Informatica.
        Informatica only supports two decimals, not four.)
        This is 8 bytes of storage
        """)]
    Money = 7,
    [Display(Name = "smallmoney",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/money-and-smallmoney-transact-sql?view=sql-server-ver17
        
        A data type that represent monetary or currency values.
        smallmoney has a range of -214,748.3648 to 214,748.3647
        This is 4 bytes of storage
        """)]
    SmallMoney = 8,
    
    // Approximate numerics
    [Display(Name = "float",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/float-and-real-transact-sql?view=sql-server-ver17
        
        Approximate-number data types for use with floating point numeric data.
        Floating point data is approximate;
        therefore, not all values in the data type range can be represented exactly.
        The ISO synonym for real is float(24).
        """)]
    Float = 9,
    [Display(Name = "real",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/float-and-real-transact-sql?view=sql-server-ver17
        
        Approximate-number data types for use with floating point numeric data.
        Floating point data is approximate;
        therefore, not all values in the data type range can be represented exactly.
        The ISO synonym for real is float(24).
        """)]
    Real = 10,
    
    // Date and time
    [Display(Name = "date",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/date-transact-sql?view=sql-server-ver17
        
        Defines a date in SQL Server.
        The date data type was introduced in SQL Server 2008 (10.0.x).
        """)]
    Date = 11,
    [Display(Name = "time",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/time-transact-sql?view=sql-server-ver17
        
        Defines a time of a day.
        The time is without time zone awareness and is based on a 24-hour clock.
        """)]
    Time = 12,
    [Display(Name = "datetime2",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetime2-transact-sql?view=sql-server-ver17
        
        Defines a date that is combined with a time of day that is based on 24-hour clock.
        datetime2 can be considered as an extension of the existing datetime type that has a larger date range,
        a larger default fractional precision, and optional user-specified precision.
        """)]
    DateTime2 = 13,
    [Display(Name = "datetimeoffset",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetimeoffset-transact-sql?view=sql-server-ver17
        
        Defines a date that is combined with a time of a day based on a 24-hour clock like datetime2,
        and adds time zone awareness based on Coordinated Universal Time (UTC).
        """)]
    DateTimeOffset = 14,
    [Display(Name = "datetime",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetime-transact-sql?view=sql-server-ver17
        
        Defines a date that is combined with a time of day with fractional seconds that is based on a 24-hour clock.
        
        Avoid using datetime for new work.
        Instead, use the time, date, datetime2, and datetimeoffset data types.
        These types align with the SQL Standard, and are more portable.
        time, datetime2 and datetimeoffset provide more seconds precision.
        datetimeoffset provides time zone support for globally deployed applications.
        """)]
    DateTime = 15,
    [Display(Name = "smalldatetime",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/smalldatetime-transact-sql?view=sql-server-ver17
        
        Defines a date that is combined with a time of day.
        The time is based on a 24-hour day, with seconds always zero (:00) and without fractional seconds.
        """)]
    SmallDateTime = 16,

    // Character strings
    [Display(Name = "char",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/char-and-varchar-transact-sql?view=sql-server-ver17
        
        UTF-8 Character data types that are of a fixed-size.
        
        Starting with SQL Server 2019 (15.x), when a UTF-8 enabled collation is used,
        these data types store the full range of Unicode character data, and use the UTF-8 character encoding.
        If a non-UTF-8 collation is specified, then these data types store only a subset of characters
        supported by the corresponding code page of that collation.
        """)]
    Char = 17,
    [Display(Name = "varchar",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/char-and-varchar-transact-sql?view=sql-server-ver17
        
        UTF-8 Character data types that is of a variable-size.
        
        Starting with SQL Server 2019 (15.x), when a UTF-8 enabled collation is used,
        these data types store the full range of Unicode character data, and use the UTF-8 character encoding.
        If a non-UTF-8 collation is specified, then these data types store only a subset of characters
        supported by the corresponding code page of that collation.
        """)]
    VarChar = 18,
    [Display(Name = "text",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/ntext-text-and-image-transact-sql?view=sql-server-ver17
        
        Fixed and variable-length data types for storing large non-Unicode and Unicode character and binary data.
        Unicode data uses the Unicode UCS-2 character set.
        
        The ntext, text, and image data types will be removed in a future version of SQL Server.
        Avoid using these data types in new development work, and plan to modify applications that currently use them. Use nvarchar(max), varchar(max), and varbinary(max) instead.
        """)]
    Text = 19,
    
    // Unicode character strings
    [Display(Name = "nchar",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/nchar-and-nvarchar-transact-sql?view=sql-server-ver17
        
        UTF-16 Character data type that is of a fixed-size.
        
        In SQL Server 2012 (11.x) and later versions, when a Supplementary Character (SC) enabled collation is used,
        these data types store the full range of Unicode character data and use the UTF-16 character encoding.
        If a non-SC collation is specified, then these data types store only the subset of character data
        supported by the UCS-2 character encoding.
        """)]
    NChar = 20,
    [Display(Name = "nvarchar",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/nchar-and-nvarchar-transact-sql?view=sql-server-ver17
        
        UTF-16 Character data type that is of variable-size.
        
        In SQL Server 2012 (11.x) and later versions, when a Supplementary Character (SC) enabled collation is used,
        these data types store the full range of Unicode character data and use the UTF-16 character encoding.
        If a non-SC collation is specified, then these data types store only the subset of character data
        supported by the UCS-2 character encoding.
        """)]
    NVarChar = 21,
    [Display(Name = "ntext",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/ntext-text-and-image-transact-sql?view=sql-server-ver17
        
        Fixed and variable-length data types for storing large non-Unicode and Unicode character and binary data.
        Unicode data uses the Unicode UCS-2 character set.
        
        The ntext, text, and image data types will be removed in a future version of SQL Server.
        Avoid using these data types in new development work, and plan to modify applications that currently use them. Use nvarchar(max), varchar(max), and varbinary(max) instead.
        """)]
    NText = 22,

    // BINARY STRINGS
    [Display(Name = "binary",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/binary-and-varbinary-transact-sql?view=sql-server-ver17
        
        Binary data type of fixed length.
        """)]
    Binary = 23,
    [Display(Name = "varbinary",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/binary-and-varbinary-transact-sql?view=sql-server-ver17
        
        Binary data typs of variable length.
        """)]
    VarBinary = 24,
    [Display(Name = "image",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/ntext-text-and-image-transact-sql?view=sql-server-ver17
        
        Fixed and variable-length data types for storing large non-Unicode and Unicode character and binary data.
        Unicode data uses the Unicode UCS-2 character set.
        
        The ntext, text, and image data types will be removed in a future version of SQL Server.
        Avoid using these data types in new development work, and plan to modify applications that currently use them. Use nvarchar(max), varchar(max), and varbinary(max) instead.
        """)]
    Image = 25,

    // SPACIAL TYPES
    [Display(Name = "geography",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/spatial-geography/spatial-types-geography?view=sql-server-ver17
        
        The geography spatial data type, geography, is implemented as a .NET common language runtime (CLR) data type in SQL Server.
        This type represents data in a round-earth coordinate system.
        The SQL Server geography data type stores ellipsoidal (round-earth) data,
        such as GPS latitude and longitude coordinates.
        """)]
    Geography = 26,
    [Display(Name = "geometry",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/spatial-geometry/spatial-types-geometry-transact-sql?view=sql-server-ver17
        
        The planar spatial data type, geometry, is implemented as a common language runtime (CLR) data type in SQL Server.
        This type represents data in a Euclidean (flat) coordinate system.
        
        SQL Server supports a set of methods for the geometry spatial data type.
        These methods include methods on geometry that are defined by the Open Geospatial Consortium (OGC)
        standard and a set of Microsoft extensions to that standard.
        
        The error tolerance for the geometry methods can be as large as 1.0e-7 * extents.
        The extents refer to the approximate maximal distance between points of the geometry object.
        """)]
    Geometry = 27,
    
    // OTHER TYPES
    [Display(Name = "cursor",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/cursor-transact-sql?view=sql-server-ver17
        
        A data type for variables or stored procedure OUTPUT parameters that contain a reference to a cursor.
        """)]
    Cursor = 28,
    [Display(Name = "hierarchyid",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/hierarchyid-data-type-method-reference?view=sql-server-ver17
        
        The hierarchyid data type is a variable length, system data type.
        Use hierarchyid to represent position in a hierarchy.
        A column of type hierarchyid does not automatically represent a tree.
        It is up to the application to generate and assign hierarchyid values in such a way
        that the desired relationship between rows is reflected in the values.
        
        A value of the hierarchyid data type represents a position in a tree hierarchy.
        Values for hierarchyid have the following properties:
        
        Extremely compact.
        The average number of bits that are required to represent a node in a tree with n nodes
        depends on the average fanout (the average number of children of a node).
        For small fanouts (0-7), the size is about 6*logAn bits, where A is the average fanout.
        A node in an organizational hierarchy of 100,000 people with an average fanout of 6 levels
        takes about 38 bits.
        This is rounded up to 40 bits, or 5 bytes, for storage.
        
        Comparison is in depth-first order.
        Given two hierarchyid values a and b, a<b means a comes before b in a depth-first traversal of the tree.
        Indexes on hierarchyid data types are in depth-first order,
        and nodes close to each other in a depth-first traversal are stored near each other.
        For example, the children of a record are stored adjacent to that record.
        For more information, see Hierarchical Data (SQL Server).
        
        Support for arbitrary insertions and deletions
        By using the GetDescendant method, it is always possible to generate a sibling
        to the right of any given node, to the left of any given node, or between any two siblings.
        The comparison property is maintained when an arbitrary number of nodes is inserted or
        deleted from the hierarchy.
        Most insertions and deletions preserve the compactness property.
        However, insertions between two nodes will produce hierarchyid values with a slightly
        less compact representation.
        
        The encoding used in the hierarchyid type is limited to 892 bytes.
        Consequently, nodes which have too many levels in their representation to fit into 892 bytes
        cannot be represented by the hierarchyid type.
        
        The hierarchyid type is available to CLR clients as the SqlHierarchyId data type.
        """)]
    HierarchyId = 29,
    [Display(Name = "json",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/json-data-type?view=azuresqldb-current&viewFallbackFrom=sql-server-ver17
        
        The native json data type that stores JSON documents in a native binary format.
        """)]
    Json = 30,
    [Display(Name = "vector",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/vector-data-type?view=sql-server-ver17&tabs=csharp-sample
        
        The vector data type is designed to store vector data optimized for operations
        such as similarity search and machine learning applications.
        Vectors are stored in an optimized binary format but are exposed as JSON arrays for convenience.
        Each element of the vector is stored as a single-precision (4-byte) floating-point value.
        """)]
    Vector = 31,
    [Display(Name = "rowversion",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/rowversion-transact-sql?view=sql-server-ver17
        
        Is a data type that exposes automatically generated, unique binary numbers within a database.
        rowversion is generally used as a mechanism for version-stamping table rows.
        The storage size is 8 bytes.
        The rowversion data type is just an incrementing number and does not preserve a date or a time.
        To record a date or time, use a datetime2 data type.
        """)]
    RowVersion = 32,
    [Display(Name = "sql_variant",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/sql-variant-transact-sql?view=sql-server-ver17
        
        A data type that stores values of various SQL Server-supported data types.
        """)]
    SqlVariant = 33,
    [Display(Name = "table",
        Description = """
        https://learn.microsoft.com/en-us/sql/t-sql/data-types/table-transact-sql?view=sql-server-ver17
        
        table is a special data type used to store a result set for processing at a later time.
        table is primarily used for temporarily storing a set of rows that are returned as the
        table-valued function result set.
        Functions and variables can be declared to be of type table.
        table variables can be used in functions, stored procedures, and batches.
        To declare variables of type table, use DECLARE @local_variable.
        """)]
    Table = 34,
    [Display(Name = "uniqueidentifier",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/data-types/uniqueidentifier-transact-sql?view=sql-server-ver17
        
        Is a 16-byte GUID.
        """)]
    UniqueIdentifier = 35,
    [Display(Name = "xml",
        Description = """
        Information copied from https://learn.microsoft.com/en-us/sql/t-sql/xml/xml-transact-sql?view=sql-server-ver17
        
        It's the data type that stores XML data.
        You can store xml instances in a column, or a variable of xml type.
        """)]
    Xml = 36,
    
    //
    [Display(Name = "One To One Relationship")]
    OneOne = 37,
    [Display(Name = "One To Many Relationship")]
    OneMany = 38,
    [Display(Name = "Many To One Relationship")]
    ManyOne = 39,
    [Display(Name = "Many To Many Relationship")]
    ManyMany = 40,
}