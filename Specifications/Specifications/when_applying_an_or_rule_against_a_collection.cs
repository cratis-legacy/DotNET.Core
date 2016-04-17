using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;

namespace Cratis.Core.Specifications.Specifications
{
    [Subject(typeof(Specification<>))]
    public class when_applying_an_or_rule_against_a_collection : given.rules_and_colored_shapes
    {
        static IEnumerable<ColoredShape> satisfied_shapes;
        static IEnumerable<ColoredShape> the_greens;
        static IEnumerable<ColoredShape> the_squares;
        static IEnumerable<ColoredShape> green_or_squares;

        Establish context = () =>
            {
                the_greens = my_colored_shapes.Where(s => s.Color == "Green").AsEnumerable();
                the_squares = my_colored_shapes.Where(s => s.Shape == "Square").AsEnumerable();

                green_or_squares = the_greens.Union(the_squares).Distinct();

            };

        Because of = () => satisfied_shapes = squares.Or(green).SatisfyingElementsFrom(my_colored_shapes);

        It should_have_all_instances_satisfying_either_part = () => satisfied_shapes.ShouldContainOnly(green_or_squares);
    }
}