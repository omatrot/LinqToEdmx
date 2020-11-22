using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmxV2.Model.ConceptualV2
{
  public static class MaxLengthFacet
  {
    public static SimpleTypeValidator TypeDefinition = new UnionSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.AnyAtomicType), null, new[]
                                                                                                                                                           {
                                                                                                                                                             Max.TypeDefinition, new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger), null)
                                                                                                                                                           });
  }
}