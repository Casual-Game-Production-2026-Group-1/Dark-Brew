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
-> Than4
-> END

=== Than2_2 ===
(Than) Very relaxing.
(Than) It was a much needed break..
* That's good.
-
(Than) Thank you for the suggestion.
* Your welcome.
-> Than4
-> END

=== Than2_3 ===
(Than) It is not boring.
(Than) You are just wrong.
* Perhaps I am, sorry for being rude.
-
(Than) Just get me my drink.
* Yes sir, here it is.
-> END

=== Than4 ===
(Than) I must head back home.
(Than) Spend the rest of my day calm.
* Have fun, heres your order.
-
(Than) Thank you mortal. Have a good day.
-> END
