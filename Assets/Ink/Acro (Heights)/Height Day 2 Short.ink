VAR player_score = 0
(You) Hi Acro, welcome back in.
* What would you like, your usual?
-
(Acro) I'll have a large dark roast Americano
* Sounds good, coming right up.
-
* Big day ahead?
-
(Acro) Yes, big building project this week.
* Congrats, what are you building?
-
(Acro) The new Hospital.
* Thats great Acro.
-
(Acro) Yes it is, wanna get it done very soon.
* Why's that?
-
(Acro) It will be the first hospital in the area with a Phobia wing.
* What does that entail?
-
(Acro) A wing of the hospital specifically for treating phobias.

* Wow thats really cool
-> Acro2_1

* That sounds like a great thing.
~ player_score +=1
-> Acro2_2

* Why would it need that?
~ player_score -=1
-> Acro2_3


=== Acro2_1 ===
(Acro) Yeah it is.
(Acro) Would be great to show people we care.
* Yeah it would be.
-> Acro4
-> END

=== Acro2_2 ===
(Acro) Yeah, it will help a lot of people.
* I bet it will, especially you.
-
(Acro) True, I can't go to a normal doctor.
* Thats not good.
-
(Acro) That's ok, I'm pretty healthy.
-> Acro4
-> END

=== Acro2_3 ===
(Acro) There are a lot of phobias in town.
* Really? I never noticed.
-
(Acro) Oh, okay then.
-> END

=== Acro4 ===
(Acro) Well, I gotta get back to work.
* Sounds good, see you again.
-> END

