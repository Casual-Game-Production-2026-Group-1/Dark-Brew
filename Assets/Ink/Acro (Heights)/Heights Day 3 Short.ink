VAR player_score = 0

(You) Hey Acro, hows it going?
* What can I get for you today?
-
(Acro) I'll have a Medium light cinnamon latte
* Gotcha, coming right up.
-
* How is the construction coming?
-
(Acro) Going well.
(Acro) Should be done by Friday.

* Thats cool.
-> Acro3_1
* Is that too fast?
~ player_score -=1
-> Acro3_2
* Congradulations Acro.
~ player_score +=1
-> Acro3_3

=== Acro3_1 ===
(Acro) Thank you.
(Acro) Me and my crew work hard.
* I bet, especially to get it done this fast.
-
(Acro) Haha, true.
-> Acro5
-> END

=== Acro3_2 ===
(Acro) No, not really.
(Acro) Why? Do you doubt my work?
* No not at all.
-> END

=== Acro3_3 ===
(Acro) The grand opening is on Saturday.
(Acro) Wanna come?
* I will if I don't work.
-
(Acro) No worries, sounds good.
-> Acro5
-> END

=== Acro5 ===
(Acro) I gotta run back to my crew.
(Acro) See you tomorrow?
* Sure, I work tomorrow.
-
* Hands Coffee
-
(Acro) Thanks, see you.
-> END

