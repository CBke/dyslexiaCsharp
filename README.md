
# They say not all ltteers slhoud be in oderr to make shmnetoig radaeble... but diong it ctontnsaly ...

a rewrite of an old perl script in C# to experience difficulte reading

```
#!/usr/bin/perl

use strict;

foreach (<>)
{
 foreach (split /\s+/)
 {
  my @letters = split //; 
  my $first_letter = shift @letters;
  my $last_letter = pop @letters;
  my $srecewdletters = join "", sort {int(rand(3))-1} @letters; 
  print "$first_letter$srecewdletters$last_letter ";
 }
 print "\n";
}
```
