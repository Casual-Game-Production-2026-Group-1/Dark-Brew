VAR player_score = 0
(You) Hi Welcome to Dark Brew

* What can I get you today, Ari?
-
(Ari) I'll have a cinnamon whole latte please.
* Coming right up.
-
* No 4 espressos today?
-
(Ari) Yeah no, the kids are on a field trip for school.
(Ari) So they will be gone for a few days.
* Nice, get some time to relax and recompose.
-
(Ari) Exactly, time to reset and do my work. 

* That's cool, what is your job?
-
(Ari) I'm a weaver.

*Thats awesome, what do you weave?
-
(Ari) I weave murals, tapestries, and more.

* Cool, I might have to commission one.
-
(Ari) Thanks, I appreciate the business.

* You're welcome.
-
* You can leave business cards with us too.
-
(Ari) Really, that would be helpful.
* Was that always what you wanted to do?
-
(Ari) No, its not my true passion.

* What is your passion?
-
(Ari) I wanna be a full time writer.
(Ari) I already write part time.

* Oh neat.
-> Ari2_1
* You should follow your passion.
~ player_score +=1
-> Ari2_2
* Thats kinda lame.
~ player_score -=1
-> Ari2_3


=== Ari2_1 ===
(Ari) Thanks, I really wanna try to do it.
* Thats good, you shouldn't do something you don't fully love.
-
(Ari) Yeah, that's fair.
-> Ari3
-> END

=== Ari2_2 ===
(Ari) Thank you, I really appreciate your adivce.
-> Ari3
-> END

=== Ari2_3 ===
(Ari) Oh, ok then.
(Ari) Can I get drink, I gotta go.
* Yes you can, here you are.
-> END


=== Ari3 ===
* Anything else goin on?
-
(Ari) I'm just a little overwhelmed with the kids.
(Ari) It was good that I got this break.
* I get that. Sometimes it can be too much.
-
(Ari) Exactly.
(Ari) That doesn't make me a bad parent right?

* Not at all.
-> Ari3_1
* No, that is just life.
~ player_score +=1
-> Ari3_2
* A little bit.
~ player_score -=1
-> Ari3_3

-> END

=== Ari3_1 ===
(Ari) Thank you.
(Ari) Even though you don't have kids haha.
* Haha, true. My kids are work.
-> Ari4
-> END

=== Ari3_2 ===
(Ari) Yes it is.
(Ari) It can be too much with anything.
* Yes. Especially something everyday.
-> Ari4
-> END

=== Ari3_3 ===
(Ari) It does?
(Ari) I think I'm gonna leave.
(Ari) Can I get my drink?
* Yes maam, here you go.
-> END



=== Ari4 ===
(Ari) I have to get back.
(Ari) I have some commissions to make.
* Nice that sounds fun.
-
(Ari) It is.
(Ari) See you next time?
* Heres your drink. And sure I'll be working.
-> END












