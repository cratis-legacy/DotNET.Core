using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Cratis.Core.Specifications.Specifications
{
    [Subject(typeof(Specification<>))]
    public class when_applying_a_simple_rule_against_a_non_satisfying_instance : given.rules_and_colored_shapes
    {
        static bool is_satisfied;

        Because of = () => is_satisfied = squares.IsSatisfiedBy(green_circle);

        It should_be_satisfied = () => is_satisfied.ShouldBeFalse();
    }
}