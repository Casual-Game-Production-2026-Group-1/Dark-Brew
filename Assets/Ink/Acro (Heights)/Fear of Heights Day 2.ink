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
-> Acro3
-> END

=== Acro2_2 ===
(Acro) Yeah, it will help a lot of people.
* I bet it will, especially you.
-
(Acro) True, I can't go to a normal doctor.
* Thats not good.
-
(Acro) That's ok, I'm pretty healthy.
-> Acro3
-> END

=== Acro2_3 ===
(Acro) There are a lot of phobias in town.
* Really? I never noticed.
-
(Acro) Oh, okay then.
-> Acro3
-> END




=== Acro3 ===
*Anything else goin on?
-
(Acro) I scheduled that dance class.
(Acro) It is later this week.

* Thats awesome.
~ player_score +=1
-> Acro3_1
* Goodluck.
-> Acro3_2
*Eww, I hate dance.
~ player_score -=1
-> Acro3_3
-> END




=== Acro3_1 ===
(Acro) Thank you.
(Acro) I am excited.
* Lepi is a great dancer.
-
(Acro) I hope she can teach me.
(Acro) A super tall guy.
* Haha, yeah hopefully.
-> Acro4
-> END

=== Acro3_2 ===
(Acro) Thanks.
(Acro) It should be fun.
* Yeah it should be.
-
(Acro) It also takes my mind off work.
* Thats good too. 
-> Acro4
-> END
=== Acro3_3 ===
(Acro) Oh you do?
(Acro) Okay then, disregard what I said.
* I didn't mean it.
-
(Acro) Silence
* I'm sorry.
-
(Acro) Can I get my drink please?
* Here you are.
-> END

=== Acro4 ===
(Acro) Well, I gotta get back to work.
* Sounds good, see you again.
-> END











