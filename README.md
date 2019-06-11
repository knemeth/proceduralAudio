# Movement Through Music
For CMPM 151

Thomas Ruiz, Daniel Martin, Kiefer Nemeth

# Controls: 
- Movement: WASD + Mouse
- Jump: Space
- Glide: Hold space after jumping
- Sprint: Hold Shift

# Mechanics: 
- Each form of movement (walking, sprinting, gliding) adds a voice to the backing music
- Many green platforms cause a change in the bacground music, such as the tempo, pitch, fm frequency, etc. when you stand on top of them. 
- The stump in the center island reverts changes to the backing music
- Your Y location affects the high/low pass filters on the backing music
- Your X location affects the FM frequency and intensity of the backing music (it also changes the tint of the screen!)

# Instructions: 

Start the game, move around the space by walking, sprinting, and gliding. Jump up the spiral staircase to hear the changes each produces in the sound. Stand on the central stump to revert those changes. 

Travel to the adjacent islands by gliding or jumping across platforms. Special songs are playing at the center of each other island. 

If you fall off the islands, fear not. You will be teleported back to the center. 

# Notes: 

All voices use the same base Pd patch. The synthesizer is designed to be versatile enough to be applicable as distinct instruments. 

The Pd patches are split into 4 folders because playing 4 individual voices in one Heavy-generated plugin wasn't working properly. The contents of each individual folder (bgSynth, walkSynth, etc.) are identical except for file/object names. 
