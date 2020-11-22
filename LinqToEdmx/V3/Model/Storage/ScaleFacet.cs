using System.Xml.Schema;
using Xml.Schema.Linq;

namespace LinqToEdmx.Model.StorageV3
{
  public static class ScaleFacet
  {
    public static SimpleTypeValidator TypeDefinition = new AtomicSimpleTypeValidator(XmlSchemaType.GetBuiltInSimpleType(XmlTypeCode.NonNegativeInteger), null);
  }
}