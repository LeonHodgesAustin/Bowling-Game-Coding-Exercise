Bowling Game Coding Exercise

Problem Description

Create a program, which, given an integer array of a valid sequence of throws for one game of American Ten-Pin

Bowling, produces the total score for the game. Your code will become the core of a bowling score management

system, so make sure it’s production-quality.

Your input should be a string like the examples below.

Stuff That’s Out of Scope

Here are some things that the program does not need to do (today):

 check for valid throws (like scores that add to 11)

 check for the correct number of throws and frames

 provide any intermediate scores – it only has to provide the final score

The Rules

To briefly summarize the scoring for this form of bowling:

 One game of bowling is made up of ten frames.

 In each frame, the bowler has two throws to knock down all the pins.

 Possible results for a frame:

o Strike (‘X’): the bowler knocks down all 10 pins on the first throw.

o Spare (‘/’): the bowler knocks down all 10 pins using two throws.

o Open frame: the bowler knocks down less than 10 pins with his two throws. The score for the frame is

 The game score is the total of all frame scores.

 Special rules for the 10th frame:

o A strike in the tenth frame gives the bowler two bonus throws, to fill out the scoring formula for the

o A spare in the tenth frame gives the bowler one bonus throw, to fill out the scoring formula for the

o These throws count as part of the 10th frame.

o The process does not repeat – for example, knocking down all 10 pins on a bonus throw does not

Examples

Input String Calculated As Score

X-X-X-X-X-X-X-X-X-X-XX (10+10+10) + (10+10+10) + (10+10+10) +

The frame is over early. The score for the frame is 10 plus the total pins knocked down on the next

two throws.

The score for the frame is 10 plus the number of pins knocked down on the next throw.

the total number of pins knocked down.

last frame.

last frame.

provide any additional bonus throws.

45-54-36-27-09-63-81-18-90-72 9 + 9 + 9 + 9 + 9 + 9 + 9 + 9 + 9 + 9 90

5/-5/-5/-5/-5/-5/-5/-5/-5/-5/-5 (10+5) + (10+5) + (10+5) + (10+5) + (10+5) +

(10+10+10) + (10+10+10) + (10+10+10) +

(10+10+10) + (10+10+10) + (10+10+10) +

(10+10+10)

(10+5) + (10+5) + (10+5) + (10+5) + (10+5)

Allowed Languages

Java, Groovy, Ruby/JRuby, Clojure, Scala, C#, Common LISP, JavaScript
