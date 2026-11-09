VAR player_score = 0
(You) Hi, Welcome to Dark Brew.
* What can I get you today Than?
-
(Than) Thank you for remembering my name mortal.
(Than) I shall have a class of Iced Milk?
* Okay sure, anything else?
-
(Than) That is all.
* Coming right up.
-
* What did you do today?
-
(Than) I took a day off like you said.
* That's great what did you do?
-
(Than) I slept in and went birdwatching.

* Oooh, thats fun.
~ player_score += 1
-> Than2_1
* Sounds relaxing.
-> Than2_2
* Birdwatching is boring.
~ player_score -= 1
-> Than2_3


=== Than2_1 ===
(Than) It was.
* See any cool birds?
-
(Than) I saw an Owl in the day.
* That is interesting.
-
(Than) Indeed very.
-> Than3
-> END

=== Than2_2 ===
(Than) Very relaxing.
(Than) It was a much needed break..
* That's good.
-
(Than) Thank you for the suggestion.
* Your welcome.
-> Than3
-> END

=== Than2_3 ===
(Than) It is not boring.
(Than) You are just wrong.
* Perhaps I am, sorry for being rude.
-> Than3
-> END



=== Than3 ===
* When do you plan to go back to work?
-
(Than) Tomorrow.
(Than) I can't take too long a break.
* That's fair.
-
* Did you do anything else during your day?
-
(Than) I also went a museum.

* Even more boring than birdwatching
~ player_score -= 1
-> Than3_1
* See any unique exhibits?
-> Than3_2
* Oh neat, I love museums.
~ player_score += 1
-> Than3_3
-> END

=== Than3_1 ===
(Than) Oh really?
(Than) Nevermind
* I don't mean to yuck your yum.
-
(Than) Give me my beverage please.
(Than) I would like to leave.
* Here you are.
-> END

=== Than3_2 ===
(Than) There was an exhibit on me.
* That's a bit of deja vu haha.
-
(Than) A bit. Some of the info was wrong haha.
* I bet. You should tell them to fix it.
-
(Than) Perhaps, but not today.
-> Than4
-> END

=== Than3_3 ===
(Than) Me too. 
(Than) Learning history is intriguing.
* Quite intriguing.
-> Than4
-> END



=== Than4 ===
(Than) I must head back home.
(Than) Spend the rest of my day calm.
* Have fun, heres your order.
-
(Than) Thank you mortal. Have a good day.
-> END



















