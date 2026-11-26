VAR player_score = 0
(You) Hi, Welcome to Dark Brew.
* What can I get you today?
-
(Phobo) I'll have a small Iced Caramel Latte.
* Perfect, I will get right to it.
-
(Phobo) How is your day going.
* It's going great, how's yours.
-
(Phobo) So far so good.
(Phobo) Got a day off tomorrow so will be fun.
* Oh nice, what are you planning to do?
-
(Phobo) I plan on feeding the ducks at the pond.
* What do you do for a living?
-
(Phobo) Oh I'm an accountant

* That sounds interesting.
~ player_score += 1
-> Phobo2_1
* Neato
-> Phobo2_2
* I would hate to have that job.
~ player_score -= 1
-> Phobo2_3
-> END

=== Phobo2_1 ===
(Phobo) Thanks. It is a reliable job. 
* I bet it is.
-
(Phobo) It allows me to relax while doing it.
(Phobo) And not talk to people. 
* That is good.
-> Phobo3
-> END

=== Phobo2_2 ===
(Phobo) Yeah, definitely neat.
* What exactly do you do?
-
(Phobo) I do the paperwork in the back.
* Sounds a little boring but I get it haha.
-
(Phobo) Yeah a little.
(Phobo) But to me it is fun.
* That's fair. As long as you find it fun.
-> Phobo3
-> END

=== Phobo2_3 ===
(Phobo) Oh ummm... Okay
(Phobo) May I umm... have my drink to go please.
* Yes sir, here you are.
-> END


=== Phobo3 ===
(Phobo) Gotta run.
(Phobo) See you tomorrow?
* Sounds good, Heres you drink.
-
(Phobo) Thanks.
-> END










