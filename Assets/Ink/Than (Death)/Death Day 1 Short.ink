VAR player_score = 0

(You) Hi, Welcome to Dark Brew
* What can I get ya?
-
(???) I'll have a Caramel Cold Brew
(You) Perfect, coming right up.
* Can I get a name for your order?
-
(???) You already know my name
(???) I am and have always been
(???) I have seen all and nothing
* Okay, Ill write Kyle
-

* Where are you coming from?
-
(???)Im on my break, just getting a pick me up.
* Nice, how has today been so far?
-
(???) I helped someone cross over today, they seemed content about it.
What would you do if I came to you?

* I would be scared as shit
-> Than1_1
* I would accept it as I cannot control what happens
~ player_score += 1
-> Than1_2
* I would start beating you with my baseball bat
~ player_score -= 1
-> Than1_3
-

=== Than1_1 ===
(???) That is fair, I would be scared too if I could feel emotion.
(???) It becomes tiring doing this everyday.
* Yeah I bet it does, do you ever take a break?
-
(???) I do not
* Thats unfortunate, what do you do for fun?
--
(???) I do not have fun, I do my job and do it well.
-> Than2

=== Than1_2 ===
(???) You are right, life is a centripetal force that cannot be altered.
* Like a Ying Yang?
-
(???) Precicesly
(???) It bends and wanes as it goes for enternity.
* Yeah I guess
-
-> Than2

=== Than1_3 ===
(???) Interesting, it would merely not hit me as I can choose when to apparate
* Oh ok
(???) I have only had that happen to me once before
-
(???) It was funny to see their reaction haha
* Haha, yeah I bet they were pretty suprised lol
-> Than2




=== Than2 ===
* What did you mean by cross over?
-
(???) I help them to the afterlife.

* Oh cool, so like the grim reaper?
~ player_score += 1
-> Than2_1
* Thats cool, must have some interesting stories.
-> Than2_2
* Way to bring down the mood.
~ player_score -= 1
-> Than2_3
-> END

=== Than2_1 ===
(???) Essentially
(???) I am a guide for the souls
* So you have helped everyone who have died?
-
(???) Yes, since the dawn of humanity.
-> Than3


=== Than2_2 ===
(???) I do, but they are too long for a time like this.
(???) Perhaps I will tell one next time we meet.
* Sure thing, come back whenever you like.
-
-> Than3


=== Than2_3 ===
(???) I am sorry, forgive me for bringing this "mood" down.
* No I'm sorry for being rude. You do a thankless job.
-
(???) I guess I do, never thought about it like that.
-> Than3




=== Than3 ===
(???) Thank you for talking with my stranger, I shall grace you with my name
* Oh cool, what is it?
-
(Than) My name is Than, or Thanatophobia
(Than)  I am the the fear of death
* Oh wow thats cool, thank you for sharing with me.
-
(Than) May I have my beverage so I may ponder?
* Here you go, have a great day!
-> END
