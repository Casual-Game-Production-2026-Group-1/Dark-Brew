VAR player_score = 0

* Hi, welcome to Dark Brew, what can I get ya?
(???) Hello, may I get a Normal Espresso
-

* Sure, coming right up. Can I get a name for the order?
-
(Lepi) My name is Lepidopterophobia, but you may just write Lepi.

* Nice to meet you Lepi, how's your day going?
-> Main1
=== Main1 ===
(Lepi) It’s going marvelous, a bloke screamed and ran away when I was walking here.
-
* I see why lol
~player_score -=1
-> New1
* How rude, what a jerk
~ player_score +=1
-> Nice1
* Im sorry that happened.
-> Nice1
-> END
=== Nice1===
(Lepi) Thank you.
(Lepi) May I have my coffee please?
* Here you are.
-> END

=== New1 ===
(Lepi) Oh am I?
(Lepi) Is my coffee almost done?
* Yes it is, here you go.
-> END

=== Name2 ===
(Lepi) I am, hoping I am doing a good job.
*So far so good
-
(Lepi) Well thank you, gotta dash, but may we have a poised conversation again.
* See you next time
-> END

