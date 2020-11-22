﻿using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmx.Model.ConceptualV2
{
  public static class PrecisionFacet
  {
    public static SimpleTypeValidator TypeDefinition = new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger), null);
  }
}