VAR player_score = 0

(You) Hi Welcome to Dark Brew
* What can I get ya?
-
(???) Can I get 4 Espressos please?
* Yes miss, coming right up.
-
(???) Thank you, Im in a bit of a hurry.
* Why's that?
-
(???) I got to get back to work, and go pick up the kids, and take them to a dance recital, and then back home, and much much more.
* Sounds like an eventful day.
~ player_score += 1
-> Ari1_1
* Dang, being a parent must suck.
~ player_score -= 1
-> Ari1_2
* Why doesn't you have your husband help u?
-> Ari1_3


=== Ari1_1 ===
It is, especially when I do this everyday.
* Do you ever slow down?
-
(???) I can't, not with my 999 kids.
* Wow, thats a lot of kids.
-
(???) Your telling me. I'm living it.
-> Ari3_3
-> END

=== Ari1_2===
(???) It most certainly does not. May I have my coffee please?
* Yes, here you go.
-
(???) Thank you.
-> END

=== Ari1_3 ===
(???) He can't, He's to busy at home.
(???) And He does not want to talk to me rn.
* Why not?
-
(???) Its a spider thing, same thing happened to my cousin Joey.
* How did he solve it?
-
(???) IDK
(???) Never saw him again.
* He died?!?!
-
(???) Most likely, thats a spider thing too.
-> Ari3_3

=== Ari3_3 ===
(Ari) Let me get my coffees please, gotta get the kids now from school.
* Yes maam, here you go.
-> END