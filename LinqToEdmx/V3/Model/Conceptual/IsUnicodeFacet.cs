using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmx.Model.ConceptualV3
{
  public static class IsUnicodeFacet
  {
    public static SimpleTypeValidator TypeDefinition = new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean), null);
  }
}