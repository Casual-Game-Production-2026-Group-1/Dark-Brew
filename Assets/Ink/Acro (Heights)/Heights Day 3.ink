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
-> Acro4
-> END

=== Acro3_2 ===
(Acro) No, not really.
(Acro) Why? Do you doubt my work?
* No not at all.
-> Acro4
-> END

=== Acro3_3 ===
(Acro) The grand opening is on Saturday.
(Acro) Wanna come?
* I will if I don't work.
-
(Acro) No worries, sounds good.
-> Acro4
-> END


=== Acro4 ===
* Anything else going on?
-
(Acro) I feel sometimes I'm being used.
* Why's that?
-
(Acro) Because of my height.
(Acro) Why else would I be hired?

* Maybe for your actual skills.
-> Acro4_1
* Maybe because your a nice person.
~ player_score +=1
-> Acro4_2
* Umm, idk besides your tall.
~ player_score -=1
-> Acro4_3
-> END


=== Acro4_1 ===
(Acro) Maybe you are right.
(Acro) People do like my skills.
* I bet they do.
-
* You are a very hard worker.
-
(Acro) Thanks, you always know what to say.
* Your welcome Acro.
-> Acro5
-> END

=== Acro4_2 ===
(Acro) Thanks, that cheers me up.
* Your welcome, happy to help.
-> Acro5
-> END

=== Acro4_3 ===
(Acro) Oh, I see.
(Acro) So it is true then.
* No, I didn't mean it like that.
-
* I'm sorry for sounding mean.
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



















