﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.7.3081.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Config {
    
    private Directories directoriesField;
    
    private bool useInventoriesField;
    
    private bool useCaravanField;
    
    private bool useVaultsField;
    
    private bool useITField;
    
    private bool useSPField;
    
    private bool useAEField;
    
    private bool useRField;
    
    private bool useAtlField;
    
    private bool useEEField;
    
    private string languageField;
    
    private bool useItemCountField;
    
    private bool useItemOwnedField;
    
    private bool useItemNameCountField;
    
    private bool useCheckBoxField;
    
    private bool useSocketedField;
    
    private string refreshTimerField;
    
    private Filters filtersField;
    
    public Config() {
        this.useItemOwnedField = true;
        this.refreshTimerField = "180";
    }
    
    /// <remarks/>
    public Directories Directories {
        get {
            return this.directoriesField;
        }
        set {
            this.directoriesField = value;
        }
    }
    
    /// <remarks/>
    public bool UseInventories {
        get {
            return this.useInventoriesField;
        }
        set {
            this.useInventoriesField = value;
        }
    }
    
    /// <remarks/>
    public bool UseCaravan {
        get {
            return this.useCaravanField;
        }
        set {
            this.useCaravanField = value;
        }
    }
    
    /// <remarks/>
    public bool UseVaults {
        get {
            return this.useVaultsField;
        }
        set {
            this.useVaultsField = value;
        }
    }
    
    /// <remarks/>
    public bool UseIT {
        get {
            return this.useITField;
        }
        set {
            this.useITField = value;
        }
    }
    
    /// <remarks/>
    public bool UseSP {
        get {
            return this.useSPField;
        }
        set {
            this.useSPField = value;
        }
    }
    
    /// <remarks/>
    public bool UseAE {
        get {
            return this.useAEField;
        }
        set {
            this.useAEField = value;
        }
    }
    
    /// <remarks/>
    public bool UseR {
        get {
            return this.useRField;
        }
        set {
            this.useRField = value;
        }
    }
    
    /// <remarks/>
    public bool UseAtl {
        get {
            return this.useAtlField;
        }
        set {
            this.useAtlField = value;
        }
    }
    
    /// <remarks/>
    public bool UseEE {
        get {
            return this.useEEField;
        }
        set {
            this.useEEField = value;
        }
    }
    
    /// <remarks/>
    public string Language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    public bool UseItemCount {
        get {
            return this.useItemCountField;
        }
        set {
            this.useItemCountField = value;
        }
    }
    
    /// <remarks/>
    public bool UseItemOwned {
        get {
            return this.useItemOwnedField;
        }
        set {
            this.useItemOwnedField = value;
        }
    }
    
    /// <remarks/>
    public bool UseItemNameCount {
        get {
            return this.useItemNameCountField;
        }
        set {
            this.useItemNameCountField = value;
        }
    }
    
    /// <remarks/>
    public bool UseCheckBox {
        get {
            return this.useCheckBoxField;
        }
        set {
            this.useCheckBoxField = value;
        }
    }
    
    /// <remarks/>
    public bool UseSocketed {
        get {
            return this.useSocketedField;
        }
        set {
            this.useSocketedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string RefreshTimer {
        get {
            return this.refreshTimerField;
        }
        set {
            this.refreshTimerField = value;
        }
    }
    
    /// <remarks/>
    public Filters Filters {
        get {
            return this.filtersField;
        }
        set {
            this.filtersField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Directories {
    
    private string vaultsField;
    
    private string tqField;
    
    private string itField;
    
    private string aeField;
    
    /// <remarks/>
    public string Vaults {
        get {
            return this.vaultsField;
        }
        set {
            this.vaultsField = value;
        }
    }
    
    /// <remarks/>
    public string TQ {
        get {
            return this.tqField;
        }
        set {
            this.tqField = value;
        }
    }
    
    /// <remarks/>
    public string IT {
        get {
            return this.itField;
        }
        set {
            this.itField = value;
        }
    }
    
    /// <remarks/>
    public string AE {
        get {
            return this.aeField;
        }
        set {
            this.aeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Filters {
    
    private MonsterInfrequent monsterInfrequentField;
    
    private Relics relicsField;
    
    private Charms charmsField;
    
    private Artifacts artifactsField;
    
    private Sets setsField;
    
    private Uniques uniquesField;
    
    private Parchments parchmentsField;
    
    private Formulae formulaeField;
    
    /// <remarks/>
    public MonsterInfrequent MonsterInfrequent {
        get {
            return this.monsterInfrequentField;
        }
        set {
            this.monsterInfrequentField = value;
        }
    }
    
    /// <remarks/>
    public Relics Relics {
        get {
            return this.relicsField;
        }
        set {
            this.relicsField = value;
        }
    }
    
    /// <remarks/>
    public Charms Charms {
        get {
            return this.charmsField;
        }
        set {
            this.charmsField = value;
        }
    }
    
    /// <remarks/>
    public Artifacts Artifacts {
        get {
            return this.artifactsField;
        }
        set {
            this.artifactsField = value;
        }
    }
    
    /// <remarks/>
    public Sets Sets {
        get {
            return this.setsField;
        }
        set {
            this.setsField = value;
        }
    }
    
    /// <remarks/>
    public Uniques Uniques {
        get {
            return this.uniquesField;
        }
        set {
            this.uniquesField = value;
        }
    }
    
    /// <remarks/>
    public Parchments Parchments {
        get {
            return this.parchmentsField;
        }
        set {
            this.parchmentsField = value;
        }
    }
    
    /// <remarks/>
    public Formulae Formulae {
        get {
            return this.formulaeField;
        }
        set {
            this.formulaeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class MonsterInfrequent {
    
    private Amount amountField;
    
    private bool normalField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public enum Amount {
    
    /// <remarks/>
    None,
    
    /// <remarks/>
    Some,
    
    /// <remarks/>
    All,
    
    /// <remarks/>
    Any,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Relics {
    
    private Amount amountField;
    
    private bool normalField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Charms {
    
    private Amount amountField;
    
    private bool normalField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Artifacts {
    
    private Amount amountField;
    
    private bool normalField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Sets {
    
    private Amount amountField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    private bool countField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
    
    /// <remarks/>
    public bool Count {
        get {
            return this.countField;
        }
        set {
            this.countField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Uniques {
    
    private Amount amountField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Parchments {
    
    private Amount amountField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://localhost/TQCConfig")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://localhost/TQCConfig", IsNullable=false)]
public partial class Formulae {
    
    private Amount amountField;
    
    private bool normalField;
    
    private bool epicField;
    
    private bool legendaryField;
    
    /// <remarks/>
    public Amount Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    /// <remarks/>
    public bool Normal {
        get {
            return this.normalField;
        }
        set {
            this.normalField = value;
        }
    }
    
    /// <remarks/>
    public bool Epic {
        get {
            return this.epicField;
        }
        set {
            this.epicField = value;
        }
    }
    
    /// <remarks/>
    public bool Legendary {
        get {
            return this.legendaryField;
        }
        set {
            this.legendaryField = value;
        }
    }
}
