﻿using System.Xml.Linq;
using System.Xml.Schema;
using LinqToEdmx.Model.StorageV3;
using Xml.Schema.Linq;

namespace LinqToEdmx.MapV3
{
  public class ScalarProperty : XTypedElement, IXMetaData
  {
    /// <summary>
    /// <para>
    /// Occurrence: required
    /// </para>
    /// </summary>
    public string Name
    {
      get
      {
        return XTypedServices.ParseValue<string>(Attribute(XName.Get("Name", "")), XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Token).Datatype);
      }
      set
      {
        SetAttribute(XName.Get("Name", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Token).Datatype);
      }
    }

    /// <summary>
    /// <para>
    /// Occurrence: required
    /// </para>
    /// </summary>
    public string ColumnName
    {
      get
      {
        return XTypedServices.ParseValue<string>(Attribute(XName.Get("ColumnName", "")), XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
      }
      set
      {
        SetAttribute(XName.Get("ColumnName", ""), value, XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String).Datatype);
      }
    }

    #region IXMetaData Members

    XName IXMetaData.SchemaName
    {
      get
      {
        return XName.Get("TScalarProperty", "http://schemas.microsoft.com/ado/2009/11/mapping/cs");
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
      return ContentModelEntity.Default;
    }

    #endregion

    public static explicit operator ScalarProperty(XElement xe)
    {
      return XTypedServices.ToXTypedElement<ScalarProperty>(xe, LinqToXsdTypeManager.Instance);
    }

    public override XTypedElement Clone()
    {
      return XTypedServices.CloneXTypedElement(this);
    }
  }
}