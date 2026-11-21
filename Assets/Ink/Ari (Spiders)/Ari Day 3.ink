VAR player_score = 0
(You) Hi Ari, welcome back in.
* What would you like?
-
(Ari) I'll have my usual please.
* 4 Espressos, coming right up.
-
(Ari) Thank you. Hows your shift going?
* Good so far, hows your day?
-
(Ari) It's good.
(Ari) The kids are back tonight.
(Ari) So I have a little more free time.
* That's good.
-
* How is the writing coming along.
-
(Ari) Good. Wanna hear about my latest story idea?
* Sure, I'm all ears.
~ player_score +=1
-> Ari4_1
* Okay, why not.
-> Ari4_2
* Not really.
~ player_score -=1
-> Ari4_3


=== Ari4_1 ===
(Ari) It's about a spider person who fights crime.
* That sounds cool. Is it about you?
-
(Ari) Not really, only some things.
(Ari) I just like the idea.
* It is an interesting idea.
-> Ari5
-> END

=== Ari4_2 ===
(Ari) It's about a spider person who fights crime. 
* Not bad, but needs something more.
-
(Ari) Your right. I'll keep thinking.
-> Ari5
-> END

=== Ari4_3 ===
(Ari) Oh okay.
(Ari) I'll bug my husband about it later.
* Oh okay.
-> Ari5
-> END

=== Ari5 ===
(Ari) Wanna know something else?
* Sure, what?
-
(Ari) Because I left my cards here.
(Ari) I have gotten lots of more commissions.
* That's great Ari, congrats.
-
(Ari) Thanks, but the credit its yours.
* Sure I guess.
-
(Ari) Question, do my arms make me look weird.
* Why do you ask?
-
(Ari) I don't know.
(Ari) There was a kid staring at them earlier.
(Ari) So do they?

* Not at all.
-> Ari5_1
* You look perfectly normal.
~ player_score +=1
-> Ari5_2
* I mean maybe a little.
~ player_score -=1
-> Ari5_3
-> END


=== Ari5_1 ===
(Ari) Why thank you.
(Ari) That is refreshing to hear.
* You are welcome.
-
* Do not care what kids think, they stare at whatever.
-
(Ari) Your right.
-> Ari6
-> END

=== Ari5_2 ===
(Ari) Aww Thanks.
* You are welcome Ari.
-
* Children are rude. Do not pay attention to them.
-
(Ari) True, just gotta keep going with my day.
* Exactly.
-> Ari6
-> END

=== Ari5_3 ===
(Ari) Oh they do?
(Ari) I'm gonna leave.
(Ari) Can I have my drink?
* Here you go. I'm sorry for saying that.
-> END



=== Ari6 ===
(Ari) Thank you for all the kind words always.
* Thank you for talking to me everyday.
-
(Ari) Your welcome. It is nice to have someone to talk to.
(Ari) Especially not my husband haha.
* Haha yeah. I bet he enjoys it too.
-
(Ari) Yeah probably.
(Ari) Can I get my drink now please.
(Ari) I need to go clean the house.
* Sure. Here you go Ari.
-
* Have a great rest of your day.
-
(Ari) You too.
-> END

















