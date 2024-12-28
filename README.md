# Unexpected Behavior with Mutable Variables in F# swap function

This repository demonstrates a common error in F# when working with mutable variables and functions.  The `swap` function, despite seemingly swapping two values, produces an unexpected output due to the nature of mutable variable passing in F#.

The `bug.fs` file contains the erroneous code.  The `bugSolution.fs` file provides the correct implementation using a tuple, thereby avoiding the mutation-related issues.

This example highlights the importance of understanding how mutable variables behave in F#, especially when passed to functions. Using tuples or other immutability-focused techniques is often a safer and more predictable approach.