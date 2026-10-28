VAR player_score = 0

(You) Hi Lepi, welcome back in.
* What would you like today?
-
(Lepi) I shall have my usual.
* One Americano? coming right up.
-
(Lepi) Thank you, what a nice day it is.
* It is nice out.
-
* How was your performance?
-
(Lepi) Thank you for remembering.
(Lepi) It went well. 
* That's great congrats.
-
(Lepi) A critic watched it and loved it.
* That is awesome.
-
* Hopefully that leads to more turnout next time.
-
(Lepi) Yeah hopefully.
* What else have you been up to.
-
(Lepi) I have been preparing to teach dance.
(Lepi) I was offered a job at a studio.


*Congradulations Lepi
~ player_score += 1
-> Lepi3_1

* Would that take away from your perfomances?
-> Lepi3_2

* Ew Teaching sucks.
~ player_score -= 1
-> Lepi3_3



=== Lepi3_1 ===
(Lepi) Thank you, it was an honor.
* I bet, what exactly would you do?
-
(Lepi) I would teach an open class to whomever.
* Cool, I bet they would learn a lot.
-> Lepi4
-> END

=== Lepi3_2 ===
(Lepi) I hope not.
(Lepi) I still want to perform.
* That's true, shouldn't take up too much time.
-
(Lepi) Yeah hopefully
-> Lepi4
-> END

=== Lepi3_3 ===
(Lepi) I guess it can but not always.
* Sorry, I guess you are right.
-
(Lepi) That's alright.
-> Lepi4
-> END




=== Lepi4 ===
* Funny enough, I recommended someone to you yesterday.
-
(Lepi) Really, who?
* A tall guy named Acro, he wants to learn.
-
(Lepi) Well that sounds splendid.
(Lepi) I would be honored to have a new student.

* That's great.
-
* Anything on your mind you wanna talk about.
-
(Lepi) I guess I'm just a little worried on how to teach.

* You got this.
-> Lepi4_3
* You'll do fine
-> Lepi4_2
* Everyone hates teachers, so just don't be mean.
-> Lepi4_1



-> END
=== Lepi4_3 ===
This is the content of the knot.
-> END


=== Lepi4_2 ===
This is the content of the knot.
-> END

=== Lepi4_1 ===
This is the content of the knot.
-> END






















