using Piranha.AttributeBuilder;
using Piranha.Models;

namespace MyRazor.Models
{
    [PostType(Title = "Standard post")]
    public class StandardPost  : Post<StandardPost>
    {
    }
}