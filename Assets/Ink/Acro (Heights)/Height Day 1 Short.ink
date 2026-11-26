VAR player_score = 0

(You) Hi, Welcome to Dark Brew
* What can I get ya?
-
(???) One Extra Large Iced Cinnamon Medium Roast with Soy Milk

* Can I get a name for the order?
-
(Acro) It's Acro
* Sounds good Acro, your drink is on its way.
-
(Acro) Thank you.
* How has your day been so far?
-
(Acro) Been good so far.

* Thats good.
~ player_score += 1
-> Acro1_1

* How's the weather up there?
~ player_score -= 1
-> Acro1_2

* This is a choice that can only be chosen once
-> Acro1_3



=== Acro1_1 ===
(Acro) Yeah, slow day today
* Nice, chance to relax and have fun.
-
(Acro) Yes, time for fun.
* What do you like to do for fun?
-
(Acro) I like bird watching
* That sounds really calming
-
(Acro) It is.
-> Acro2

=== Acro1_2 ===
(Acro) Haha funny
(Acro) Haven't heard that one before
* My bad, I bet you do hear that a lot.
-
(Acro) Its ok, I'm used to it.
-> Acro2

=== Acro1_3 ===
This is the content of the knot.
-> END



=== Acro2 ===
I shall see you tomorrow
-> END
