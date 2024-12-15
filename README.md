# Unexpected Mutability Behavior with Tuples in F#

This example demonstrates a subtle difference in how mutability works in F# when dealing with individual mutable variables versus tuples.

## The Bug
The `swap` function attempts to swap the values of two mutable variables.  When called with individual variables, it works as expected. However, when the same logic is applied to a tuple using `swapTuple`, the tuple remains unchanged outside the function.

## Solution
The key is understanding that tuples in F# are immutable.  Even though we're using mutable variables *within* the tuple, the tuple itself cannot be mutated. To achieve the desired swapping behavior with tuples, you need to return a new tuple with the swapped values.