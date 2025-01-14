﻿using System;
using ConsoleColorOutput;

namespace TestCCO
{
    class Program
    {
        static void Main(string[] args)
        {
            var ou = new ConsoleOutputHelper();

            // First test case: we need to change to color with the {color} syntax
            ou.WriteLine("{yellow}Hello World!{}");

            // Second test case: headings
            ou.WriteLine("# This should be white as it is something important.");

            // Third test case: wrapping 
            ou.WriteLine(@"This is written in multiple
lines in the source code. But a single line break should
not break the output into multiple lines. Instead, the output
should flow around the console. So this multi line
message should fit inside the console, and get wrapped
accordingly.");

			// Fourth test case: inline colors
			ou.WriteLine(@"So let's color {cyan}something{} in the middle.");

			// Fifth test case
			ou.WriteLine(@"When we are creating many text.

And I mean many.

Many {yellow}many{} many.

We want this to pause when the console is full. 

Or display.

Whatever.

More text here.

More text here.

More text here.

More text here.

More text here.

More text here.

More text here.

More text here.

More text here. More text here. More text here. More text here. More text here. More text here. More text here.
More text here. More text here. More text here. More text here. More text here. More text here. More text here.

More text here.

More text here.

");
        }
    }
}
