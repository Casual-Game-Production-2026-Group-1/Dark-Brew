VAR player_score = 0

Hi Welcome to Dark Brew.
* What can I get ya?
-
(???) Uhh hi, can I get a Light Roast Coffee with Oat Milk and Ice please?
* Can I get a name for the order?
-
(???) Uhh yeah, its uh Phobo.
* Ok Phobo perfect, coming right up
-
* Hows your day going?
-
(Phobo) Uhh its going fine,just a lot going on.
* Are you ok? You seem nervous.
-
(Phobo) Ooh thats just how I always am.
(Phobo) I'm afraid of just about everything.

* So am I lol
-> Phobo1_1

* That's ok, sometimes you just have to breath and take it slow.
~ player_score += 1
-> Phobo1_2

* Wow that must suck for you.
~ player_score -= 1
-> Phobo1_3


=== Phobo1_1 ===
(Phobo) Really? It's hard to find someone who is like me.
* Yeah, it is uncommon.
-
(Phobo) Thank you for understanding.
* Your welcome Phobo
-> Phobo2
-> END

=== Phobo1_2 ===
(Phobo) Yeah I know
(Phobo) I've been doing meditation to take it slow. 
* That's good. Breathing helps.
-
(Phobo) It does. Especially when I'm anxious.
-> Phobo2
-> END

=== Phobo1_3 ===
(Phobo) It does suck.
(Phobo) Thank you for reminding me.
* Oh I didn't mean it like that.
-
(Phobo) (Silence)
* I apologize.
-> Phobo2
-> END


=== Phobo2 ===
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
-> END

=== Phobo2_3 ===
(Phobo) Oh ummm... Okay
(Phobo) May I umm... have my drink to go please.
* Yes sir, here you are.
-> END



== Phobo3 ===
(Phobo) Thank you for talking.
(Phobo) I gotta head back.
(Phobo) My break is ending.
* Okay, here you go.
-
(Phobo) Thank you. Have a uhh nice day.
* You too.
-> END
















