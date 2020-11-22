using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmxV2.Model.StorageV2
{
  public static class IsFixedLengthFacet
  {
    public static SimpleTypeValidator TypeDefinition = new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean), null);
  }
}