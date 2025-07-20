using System.ComponentModel.DataAnnotations.Schema;
using Swashbuckle.AspNetCore.Annotations;

namespace Gay.Silverbranch.API.Models.Entities.V1;

public abstract class BaseModel
{
    // ProjectScaffolder.Models Specific Notes Here
    //--------------------------------------------------------------------------
    //

    //protected const string CLASS_NAME = "BaseModel";

    #region Properties

    private const string NameDescription = "Reference name of model";
    [SwaggerSchema(Description = NameDescription)]
    // [ModelDocumentation(Description = NameDescription,
    //     DBType = "nvarchar",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     Required = true,
    //     ReadOnly = false)]
    public string Name { get; set; } = "";

    private const string NotesDescription = "Entry specific notes";
    [SwaggerSchema(Description = NotesDescription)]
    // [ModelDocumentation(Description = NotesDescription,
    //     DBType = "nvarchar",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     Required = true,
    //     ReadOnly = false)]
    public string Notes { get; set; } = "";

    //Both API and database

    //Database only

    #region IDENTITY Properties

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int _entryIdentity;
    private string _commonIdentity = "0130PU55Y0130";
    private string _ownedBy = "INVALID NOT A USER";

    private const string EntryIdDescription = "Database specific entry id";
    [SwaggerSchema(Description = EntryIdDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = EntryIdDescription,
    //     DBType = "int",
    //     Format = "uint",
    //     Encoding = "uint",
    //     Required = true,
    //     ReadOnly = true)]
    public int EntryIdentity => _entryIdentity;

    private const string CommonIdDescription = "The common model id, used to relate a model to its history";
    [SwaggerSchema(Description = CommonIdDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = CommonIdDescription,
    //     DBType = "int",
    //     Format = "uint",
    //     Encoding = "uint",
    //     Required = true,
    //     ReadOnly = true)]
    public string CommonIdentity => _commonIdentity;
    
    private const string OwnedByDescription = "Entry specific notes";
    [SwaggerSchema(Description = OwnedByDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = OwnedByDescription,
    //     DBType = "char(13)",
    //     Format = "nanoid",
    //     Encoding = "ascii",
    //     Required = true,
    //     ReadOnly = true)]
    public string OwnedBy => _ownedBy;

    #endregion

    #region CREATED/MODIFIED Property

    //private string _createdBy = "";
    //private DateTime _createdOn;
    private string _modifiedBy = "___ERROR___";
    private DateTime _modifiedOn;

    private const string ModifiedByDescription = "User who made changes list in notes for entry";
    [SwaggerSchema(Description = ModifiedByDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = ModifiedByDescription,
    //     DBType = "nvarchar",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     Required = true,
    //     ReadOnly = true)]
    public string ModifiedBy => _modifiedBy;

    private const string ModifiedOnDescription = "Date of modification";
    [SwaggerSchema(Description = ModifiedOnDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = ModifiedOnDescription,
    //     DBType = "char(22)",
    //     Format = "yyyyHHmm_HHmmss.ffffff")]
    public DateTime ModifiedOn => _modifiedOn;

    #endregion

    #region HIDDEN Properies

    private bool _isHidden = false;
    private string? _hiddenBy = null;
    private DateTime? _hiddenOn = null;

    private const string IsHiddenDescription = "Is the model marked as alive but should be hidden from queries";
    [SwaggerSchema(Description = IsHiddenDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = IsHiddenDescription,
    //     DBType = "bit")]
    public bool IsHidden => _isHidden;

    private const string HiddenByDescription = "User who marked the model or entry as hidden";
    [SwaggerSchema(Description = HiddenByDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = HiddenByDescription,
    //     DBType = "nvarchar",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     Required = true,
    //     ReadOnly = true)]
    public string? HiddenBy => _hiddenBy;

    private const string HiddenOnDescription = "Date of model was last set as hidden";
    [SwaggerSchema(Description = HiddenOnDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = HiddenOnDescription,
    //     DBType = "char(22)",
    //     Format = "yyyyHHmm_HHmmss.ffffff")]
    public DateTime? HiddenOn => _hiddenOn;

    #endregion

    #region DELETED Properties

    private bool _isDeleted = false;
    private string? _deletedBy = null;
    private DateTime? _deletedOn = null;

    private const string IsDeletedDescription = "Is the model marked as deleted";
    [SwaggerSchema(Description = IsDeletedDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = IsDeletedDescription,
    //     DBType = "bit")]
    public bool IsDeleted => _isDeleted;

    private const string DeletedByDescription = "User who marked this model or entry as deleted";
    [SwaggerSchema(Description = DeletedByDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = DeletedByDescription,
    //     DBType = "nvarchar",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     Required = true,
    //     ReadOnly = true)]
    public string? DeletedBy => _deletedBy;

    private const string DeletedOnDescription = "Date of deletion";
    [SwaggerSchema(Description = DeletedOnDescription, ReadOnly = true)]
    // [ModelDocumentation(Description = DeletedOnDescription,
    //     DBType = "char(22)",
    //     Format = "yyyyHHmm_HHmmss.ffffff")]
    public DateTime? DeletedOn => _deletedOn;

    #endregion

    //API only

    // Code side only
    [NotMapped]
    [SwaggerIgnore]
    public bool IsModified { get; set; } = false;

    #endregion

    #region Constructors

    protected BaseModel() { }

    protected BaseModel(string id, string name, string createdBy, DateTime createdOn, string notes)
    {
        Name = name;
        Notes = notes;

        _commonIdentity = id;
        _ownedBy = createdBy;
        _modifiedBy = createdBy;
        _modifiedOn = createdOn;
    }

    protected BaseModel(BaseModel model, string user, bool? isHidden = false, bool? isDeleted = false)
    {
        Name = model.Name;
        Notes = model.Notes;
        _ownedBy = model.OwnedBy;

        _commonIdentity = model.CommonIdentity;
        _modifiedBy = model.ModifiedBy;
        _modifiedOn = model.ModifiedOn;

        _hiddenBy = isHidden.HasValue ? user : model.HiddenBy;
        _hiddenOn = isHidden.HasValue ? DateTime.UtcNow : model.HiddenOn;
        _isHidden = isHidden ?? model.IsHidden;

        _deletedBy = isDeleted.HasValue ? user : model.DeletedBy;
        _deletedOn = isDeleted.HasValue ? DateTime.UtcNow : model.DeletedOn;
        _isDeleted = isDeleted ?? model.IsDeleted;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    protected BaseModel(BaseModel model, int entryId, string user, bool? isHidden = false, bool? isDeleted = false)
    {
        _entryIdentity = entryId;
        
        Name = model.Name;
        Notes = model.Notes;
        _ownedBy = model.OwnedBy;

        _commonIdentity = model.CommonIdentity;
        _modifiedBy = model.ModifiedBy;
        _modifiedOn = model.ModifiedOn;

        _hiddenBy = model.HiddenBy;
        _hiddenOn = model.HiddenOn;
        _isHidden = model.IsHidden;

        _deletedBy = isDeleted.HasValue ? user : model.DeletedBy;
        _deletedOn = isDeleted.HasValue ? DateTime.UtcNow : model.DeletedOn;
        _isDeleted = isDeleted ?? model.IsDeleted;
    }

    #endregion

    public void SetHiddenState(bool newState, string user)
    {
        _isHidden = newState;
        _hiddenBy = user;
        _hiddenOn = DateTime.UtcNow;
        
        _modifiedBy = user;
        _modifiedOn = DateTime.UtcNow;
    }
    
    public void SetDeletedState(bool newState, string user)
    {
        _isDeleted = newState;
        _deletedBy = user;
        _deletedOn = DateTime.UtcNow;
        
        _modifiedBy = user;
        _modifiedOn = DateTime.UtcNow;
    }

    //public static bool operator ==(BaseModel lhs, BaseModel rhs) => lhs.Equals(rhs);
    //public static bool operator ==(BaseModel lhs, int rhs) => lhs.Equals(rhs);
    //public static bool operator ==(int lhs, BaseModel rhs) => rhs.Equals(lhs);

    //public static bool operator !=(BaseModel lhs, BaseModel rhs) => !lhs.Equals(rhs);
    //public static bool operator !=(BaseModel lhs, int rhs) => !lhs.Equals(rhs);
    //public static bool operator !=(int lhs, BaseModel rhs) => !rhs.Equals(lhs);

    //public static bool operator <(BaseModel lhs, BaseModel rhs) => lhs.Equals(rhs) && lhs.OlderThan(rhs);

    //public static bool operator >(BaseModel lhs, BaseModel rhs) => rhs.Equals(lhs) && rhs.OlderThan(lhs);

    //private bool OlderThan(BaseModel lhs)
    //{
    //    return false;
    //}

    ////public override string ToString()
    ////{
    ////    return String.Format("({0}, {1}, {2})", length, breadth, height);
    ////}

    //public new abstract bool Equals(object? obj);
    //public abstract bool Equals(int? obj);
    //public abstract bool Equals(string? obj);
}
