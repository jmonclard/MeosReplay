# MeosReplay
A program to replay an orienteering Event managed with MeOS

###2016-03-25 Initial release

##Description
MeosReplay is a program that can be used either for training or debugging. It allows replaying a race as it is seen by MeOS, the program used to manage the event.
The replay can be in real time or accelerated. Any control can be selected as a radio control, and SI card reading happens after a specified delay after arrival.
Any delay can have a random part, for instance to take into account the time spent by the runner between the arrival line and the SI card reading.

To use MeosReplay :
* run MeOS on a computer and load the MeOS XML event file as it was **before** the event,
* run MeosReplay either on another computer or on the same one and load the MeOS XML event file as it was **after** the event,
* define in MeosReplay the IP adress of the computer running MeOS (or 127.0.0.1 if there is only one)
* check the radio controls in the list of controls if needed
* define parameters (replay speed, etc...)
* press the *play* button

All issues that had actually been faced by the organizer during the race (for instance unregisterd SI card, no finish punch, unknown runner, etc.) will also happen during the replay.
If some radio controls have been selected, MeOS speaker view works as usual.

This is provided "as is" as open source code and can be freely used, modified, enhenced and distributed. It is licensed in the same conditions as MeOS.

