﻿using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmx.Model.StorageV2
{
  public static class CommandText
  {
    public static SimpleTypeValidator TypeDefinition = new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.String), new RestrictionFacets(((RestrictionFlags) (32)), null, 0, 0, null, null, 0, null, null, 0, null, 0, XmlSchemaWhiteSpace.Preserve));
  }
}