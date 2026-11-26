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
(Lepi) May I have my drink please?
(Lepi) I have to run.
* Yes, here you go.
-
(Lepi) Thank you.

-> END
