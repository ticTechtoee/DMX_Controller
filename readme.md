# DMX Controll Software using OpenDMX

A Desktop application built using C#.net and Winforms to control "Confetti Cannon".

There are only 2 buttons to control the "Confetti Cannon".
	1-On
	2-Off

For On I have set the value to "255" and for Off I  have set value to "0" (You can play with these values as it seems fit)

I have set the Channel to "1" (Corrsponding to the channel set on "Confetti Cannon")

I have also made few changes in "OpenDMX.cs" class to fix some unattended issues which were left by original author of this class.

Created "OpenDmxController.cs" class to open the connection to the controller.

NOTE:
	"FTD2XX.dll", "OpenDmx.dll", Classes were borrowed from VB6 Example. Without these .dll files this software won't work.

Original Examples can be found on this page: https://ftdichip.com/software-examples/code-examples/

For "Confetti Cannon" check out this page for more technical information: https://www.chauvetdj.com/products/funfetti-shot/