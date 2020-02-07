# friendly-waffle
I have a weird idea that guitar tabs cna be expressed via a programming language, I'm wondering if I can introduce a abstraction layer that allows people to create TAB from a simplistic programming language, from playing around with some ideas here is what I have so far:

`section` 
This is much like defining a function, sample: `section "intro"`, we define an intro section and then we can "call" this function later via a `play_section` function, which will esentially render those tabs next

`let`
define a new chord, (much like a variable) sample: 
```
    let MyNewChord
        :e 7 :B 7 :G 7 :D 7 :A 7 :E 7
```

Now every time we call `play` we can specify that chord: `play MyNewChord` and it will print the TAB of the chord

`main:`
the entry point of the tab 

`repeat [0-9]`
a loop, the number given will be the amount of times that chord or section willl be printed in the TAB 

`:[eBGDAE]`
The name of the string to play

`play`
print out the TAB of whatever comes next

`play_section`
call a "section"

`slide`
pass in a "from" and "to" where you slide from one note to another

`hammer_on`
pass in a "from" and "to" where you hammer on from and to

`pull_off`
pass in a "from" and "to" where you pull on from and to

`bend`
pass in a "from" and "to" where you bend on from and to

`wait`
Some sort of wait function to say wait for a beat


Not yet thought through:
- Music Key (some sort of conifg?)
- Time signature (config)
- Vibrato
- Alt. Tuning
- Lyrics
- Strumming patterns?
- Chord diagrams
