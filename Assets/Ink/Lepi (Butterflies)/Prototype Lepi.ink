VAR player_score = 0

* Hi, welcome to Dark Brew, what can I get ya?
(???) Hello, may I get a Normal Espresso
-

* Sure, coming right up
-
* What is your name?
-
(Lepi) My name is Lepidopterophobia, but you may call me Lepi.

* Nice to meet you Lepi, how's your day going?
~ player_score +=1
-> Main1
* Lepi, what a unique name.
-> Name3

* That's a weird name
~ player_score -=1
-> NameMean
=== NameMean ===
(Lepi) Oh it is then. May I get my beverage please.
* Yes you can, it is almost done.
-> END

=== Main1 ===
(Lepi) It’s going marvelous, a bloke screamed and ran away when I was walking here.
-
* I see why lol
~player_score -=1
-> Mean1
* How rude, what a jerk
~ player_score +=1
-> Nice1
* Im sorry that happened.
-> Neutral1
-> END
=== Mean1===
(Lepi) What choice words, just give me my coffee and let me on my way.
* Sure, whatever ->END
* On it, sorry about my joke, it was in poor taste ->END
* Yes maam
-> END

=== Nice1 ===
(Lepi) Thank you, but I get it all too often these days.
-> Main2
-> END

=== Neutral1 ===
(Lepi) Thank you darling, people can be so harsh these days.
* Yeah I know, but you can't control other people, only yourself.
(Lepi) Yes I know, thank you for allowing an aging soul to vent.
-
* Your welcome, happy to help.
-> Main2


=== Main2 ===
* Sometimes people can be mean, you just have to worry about yourself you know.
(Lepi) Thank you, may I get my coffee please?
(Lepi) I'm quite knackered and in a rush.
-
* Yes, almost done.
(Lepi) Thank you so much, may your day be splendid.
-> END


=== Name3 ===
(Lepi) Thank you
(Lepi) I haven't seen you working here before?
* No, your just blind lol
~ player_score -=1
-> New1
* Yeah, this is my first shift, you're actually my first customer
~ player_score +=1
-> Name2
* Yeah I am new.
-> Name4
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

=== Name4 ===
(Lepi) Nice, keep up the marvelous work
(Lepi) Catch you next time new barista.
* See you around.

-> END


