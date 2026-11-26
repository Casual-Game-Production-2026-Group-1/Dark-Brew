VAR player_score = 0

(You) Hey Acro, hows it going?
* What can I get for you today?
-
(Acro) I'll have a dark brew with a shot of espresso please.
* Sounds good Acro.
-
* How's the building coming?
-
(Acro) Good.
(Acro) Will be done tomorrow.
* That's great.
-
(Acro) Yes. Need the extra energy to finish.
* Fair haha.
-
* Are you excited for the opening?
-
(Acro) I am.
(Acro) But I do have to speak at it.
(Acro) And I am a bit nervous.

* I bet you will do great.
~ player_score +=1
-> Acro4_1
* Just don't choke up there.
~ player_score -=1
-> Acro4_2
* Everyone gets stage fright.
-> Acro4_3


=== Acro4_1 ===
(Acro) Thank you.
(Acro) That means a lot.
* Your welcome. Now break a leg.
-
(Acro) Haha, I will.
-> Acro5
-> END

=== Acro4_2 ===
(Acro) Umm. I guess I need to practice then.
(Acro) Can I have my drink to go?
* Yes you can here you are.
-> END

=== Acro4_3 ===
(Acro) That is true.
* Just take a deep breath before.
-
(Acro) Your right.
-> Acro5
-> END


=== Acro5 ===
(Acro) Thank you for the advice.
* Your welcome Acro.
-
(Acro) I gotta run cause my break is ending.
(Acro) Will I see you at the event?
* If I can get off work.
-
* Heres your coffee.
-
(Acro) Thank you. Hopefully see you then.
-> END


















