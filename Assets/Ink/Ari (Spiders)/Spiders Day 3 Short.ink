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
-> Ari6
-> END

=== Ari4_2 ===
(Ari) It's about a spider person who fights crime. 
* Not bad, but needs something more.
-
(Ari) Your right. I'll keep thinking.
-> Ari6
-> END

=== Ari4_3 ===
(Ari) Oh okay.
(Ari) I'll bug my husband about it later.
(Ari) Can I have my drink?
* Oh sure, here you go.
-> END

=== Ari6 ===
(Ari) Thank you for all the kind words always.
* Your welcome.
-
(Ari) Can I get my drink now please.
(Ari) I need to go clean the house.
* Sure. Here you go Ari.
-
* Have a great rest of your day.
-
(Ari) You too.
-> END
