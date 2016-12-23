# Julien's puzzler project

In order to complete my Udacity Nanodegree, I had to create a VR mobile application named Project4puzzler.

It is a simple game using Google Cardboard, similar to the game \*Simon says\*.

This document explains the development process, testing and results.

# Project4Puzzler

The goal of this game is to escape th%e dungeon by repeating the pattern of Orbs lighting up.

<a href="https://youtu.be/RFXElq1QyFo" alt="Project4Puzzler Video" target="_blank"><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/img3.png" alt="Project4Puzzler video" width="560">
<br>Click to watch a Walkthrough Video</a>

##Design process

###Statement of Purpose:
Project4Puzzler is a simple VR game to demonstrate my abilities to create a quick demo on Unity and GoogleVR

###Persona

For this project I created a user persona named Sophia

HR recruiter at a gaming studio

&quot;not hiring is better than hiring the wrong person&quot;

Sophia&#39;s motivation is to hire the best person for the job

Sophia has to introduce the company to candidates, she likes meeting and interacting with people.

She likes being the first person to greet newcomers to a company.

She likes games but has never tried anything on VR.

###Sketches

Here are a few quick sketches to illustrate the concept of the game.

<img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/img1.jpg" alt="Overall Design Sketch" width="300">
<img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/img2.jpg" alt="Overall Design Sketch" width="300">

###User testing outcomes and iteration

Testing the scene and atmosphere

I asked my friend to test a first implementation of the game to determine the scale of the environment and the mood of the scene.

The scale was appropriate the portal size appeared to the user as a dungeon size door, which was the effect I was looking for.

The user had a bit of a trouble to define the scene mood, but the experience still felt comfortable.

As the first user testing felt appropriate, I did not modify the application.

In the last round of user testing, the subject was asked to run through the game and provide feedback on the experience.

The user did not have any problem going through the game, but felt that the design felt a bit empty, and the game not really interesting.

To address the first comment I added a few more lights and I added a Terrain mountain around the dungeon.

To address the second comment I feel it would require a lot more effort and would require the complete rewrite of the goal of this project, and so I did not address that issue.

##Breakdown of the final application

Here are few screenshots of the result of the project.
<BR><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/ss1.png" alt="screenshot" width="300">
<BR><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/ss2.png" alt="screenshot" width="300">

After clicking the start button, the user is moved automatically inside the dungeon.
<BR><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/ss3.png" alt="screenshot" width="300">

The orbs start to animate following a pattern of light and sound.
<BR><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/ss4.png" alt="screenshot" width="300">

The user repeats the pattern by clicking on the orbs.
<BR><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/ss5.png" alt="screenshot" width="300">

After successfully repeating the correct pattern, the user is moved outside of the dungeon, through the second door.

<BR><img src="https://github.com/otiasj/udacity/blob/master/VR/P4/docs/ss6.png" alt="screenshot" width="300">

The restart panel is then showed. If the user clicks the restart button, the user is moved back in front of the orb to complete the puzzle again.

##Conclusion

The project runs correctly and is easy enough for a beginner in VR to have a fun experience.

The demo only last a minute or two which is perfect for first time users.

###Next steps

As a next iteration, it would be fun to add the Daydream controller as an input device.

The controller feels more intuitive than clicking while looking and it might improve the usability.

###Link to additional work

All the work for this project is on [Github](https://github.com/otiasj/udacity/tree/master/VR) in my Udacity repository.
