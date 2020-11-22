using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmx.Model.StorageV3
{
  public static class IsFixedLengthFacet
  {
    public static SimpleTypeValidator TypeDefinition = new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.Boolean), null);
  }
}