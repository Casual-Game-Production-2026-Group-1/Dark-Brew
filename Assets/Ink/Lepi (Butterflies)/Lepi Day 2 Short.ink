VAR player_score = 0

Hi Welcome to Dark Brew.
* What can I get ya?
-
(Lepi) Hello again, I shall have an Americano.

* Sure thing Lepi, coming right up.
-
* How has your day been?
-
(Lepi) It has been quite tiresome. Have a performance later tonight.
* That sounds cool, what kind?
~ player_score += 1
-> Lepi1_1
* Perfomances are lame.
~ player_score -= 1
-> Lepi1_2
* Neat, break a leg haha.
-> Lepi1_3
=== Lepi1_1 ===
(Lepi) Its a solo dance about butterflies.
* That sounds awesome.
-
(Lepi) Thank you, I have been hard at work on it for months.
* Wow, thats a lot of work. No wonder you keep ordering coffees haha.
-
(Lepi) Haha, it is a knackering job.

-> Lepi2
-> END
=== Lepi1_2 ===
(Lepi) Oh, ok then.
* I'm sorry, didnt mean to offend you.
-
(Lepi) It's fine. Give me my coffee please.
* Here you are.
-> END
=== Lepi1_3 ===
(Lepi) Thank you darling, come by and see it.
* Wish I could but I work all day today.
-
(Lepi) That is unfortunate.
(Lepi) Do not fret, I shall have a recording.
* Can't wait to see it.
-> Lepi2
-> END
=== Lepi2 ===
(Lepi) May I have my drink?
* Sure, coming right up.
-
(Lepi) Have a nice day.

-> END









