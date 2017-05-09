# Task

Given an input file containing a rectangular block of dot
characters ('.') and two or more hash characters ('#'), write a
program called 'pather' that writes to an output file the same
block of dot characters, but with the '#' characters connected
by asterisks ('*').

The command will be invoked like this:

  pather input.txt output.txt

The rules for the path:

* No diagonals.
* Only change direction once per pair of '#' characters.
* Start with a vertical line and then complete with a horizontal line.

Please feel free to write further tests if you believe the program can be
improved upon. Have fun with it.

# Examples

See examples in task.txt.