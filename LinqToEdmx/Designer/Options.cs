using System;
using System.Collections.Generic;
using System.Xml.Linq;
using LinqToEdmxV2.Model.StorageV2;
using Xml.Schema.Linq;

namespace LinqToEdmxV2.DesignerV2
{
  /// <summary>
  /// <para>
  /// Regular expression: (DesignerInfoPropertySet?)
  /// </para>
  /// </summary>
  public class Options : XTypedElement, IXMetaData
  {
    private static readonly Dictionary<XName, Type> LocalElementDictionary = new Dictionary<XName, Type>();

    private static readonly ContentModelEntity ContentModel;

    static Options()
    {
      BuildElementDictionary();
      ContentModel = new SequenceContentModelEntity(new NamedContentModelEntity(XName.Get("DesignerInfoPropertySet", "http://schemas.microsoft.com/ado/2008/10/edmx")));
    }

    /// <summary>
    /// <para>
    /// Occurrence: optional
    /// </para>
    /// <para>
    /// Regular expression: (DesignerInfoPropertySet?)
    /// </para>
    /// </summary>
    public DesignerInfoPropertySet DesignerInfoPropertySet
    {
      get
      {
        return ((DesignerInfoPropertySet) GetElement(XName.Get("DesignerInfoPropertySet", "http://schemas.microsoft.com/ado/2008/10/edmx")));
      }
      set
      {
        SetElement(XName.Get("DesignerInfoPropertySet", "http://schemas.microsoft.com/ado/2008/10/edmx"), value);
      }
    }

    #region IXMetaData Members

    Dictionary<XName, Type> IXMetaData.LocalElementsDictionary
    {
      get
      {
        return LocalElementDictionary;
      }
    }

    XName IXMetaData.SchemaName
    {
      get
      {
        return XName.Get("TOptions", "http://schemas.microsoft.com/ado/2008/10/edmx");
      }
    }

    SchemaOrigin IXMetaData.TypeOrigin
    {
      get
      {
        return SchemaOrigin.Fragment;
      }
    }

    ILinqToXsdTypeManager IXMetaData.TypeManager
    {
      get
      {
        return LinqToXsdTypeManager.Instance;
      }
    }

    ContentModelEntity IXMetaData.GetContentModel()
    {
      return ContentModel;
    }

    #endregion

    public static explicit operator Options(XElement xe)
    {
      return XTypedServices.ToXTypedElement<Options>(xe, LinqToXsdTypeManager.Instance);
    }

    public override XTypedElement Clone()
    {
      return XTypedServices.CloneXTypedElement(this);
    }

    private static void BuildElementDictionary()
    {
      LocalElementDictionary.Add(XName.Get("DesignerInfoPropertySet", "http://schemas.microsoft.com/ado/2008/10/edmx"), typeof (DesignerInfoPropertySet));
    }
  }
}