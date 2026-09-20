* Hi, welcome to Dark Brew, what can I get ya?
Hi can I get a Normal Espresso
-

* Sure, coming right up
-
* What is your name?
-
My name is Lepidopterophobia, but you can call me Lepi.

* Nice to meet you Lepi, how's your day going?
-> Main1
* Lepi, what a unique name.
-> Name3

* That's a weird name
-> NameMean
=== NameMean ===
Oh it is, ok then. Can I get my coffee please.
* Yes you can, it is almost done.
-> END

=== Main1 ===

It’s going ok, someone screamed and ran away when I was walking here.
-
* I see why lol
-> Mean1
* How rude, what a jerk
-> Nice1
* Im sorry that happened.
-> Neutral1
-> END
=== Mean1===
How rude of you to say that, just give me my coffee and let me on my way.
* Sure, whatever ->END
* On it, sorry about my joke, it was in poor taste ->END
* Yes maam
-> END

=== Nice1 ===
Thank you,but I get it all too often nowadays.
-> Main2
-> END

=== Neutral1 ===
Thank you, people can be so harsh these days.
* Yeah I know, but you can't control other people, only yourself.
Yeah I know, thanks for letting me vent to you.
-
See you tomorrow?
* I'll be on shift, see you then.
-> END


=== Main2 ===
* Sometimes people can be mean, you just have to worry about yourself you know.
Thanks, can I get my coffee please, I'm in a bit of a rush.
-
* Yes, almost done.
Thank you so much, have a good day
-> END


=== Name3 ===
Thanks
Haven't seen you working here before, you new?
* No, your just blind lol
-> New1
* Yeah, this is my first shift, your actually my first customer
-> Name2
* Yeah I am new.
-> Name4
-> END

=== New1 ===
Oh ok then, is my coffee almost done?
* Yes it is, here you go.
-> END

=== Name2 ===
I am, hoping I am doing a good job.
*So far so good
-
Well thanks, gotta run, but hope I'll see you tomorrow.
* See you tomorrow
-> END

=== Name4 ===
Nice, well keep up the good work then, catch you around new barista.
* See you around.

-> END


