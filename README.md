# CPR-sim
## An audio-enhanced training module and scenario-based simulator built in a C# console app

This project was built in Visual Studio to create a training module for Cardio Pulmonary Resusitation (CPR).  This includes two main components:
   1. Presentation – several narrated screens of instructional information 
   2. Simulation – the participant navigates a text-driven simulation during a scenario

The goal was to create engaging content while exceeding what is normally expected within the constraints of a console application.

**This training module incorporates the following features:**
   - Formatted text (positions and colors)
   - ASCII art for visual enhancement
   - Synchronized audio files for text-to-speech engines and sound effects
   - Logic-based responses to user inputs
     
**These are improvements noted for future versions:**
   - Implementation of “Adult”, “Child”, and “Infant” classes to inherit from a parent “Patient” class
   (currently all code is written in the main method of the Program class)
   - Correct some of the logic that is not properly executing for user inputs
   - Fix the “Open PDF” feature on the “Training Part 1” screen
   - Add a timer function to determine rate of compressions, rescue breathing, and total CPR time
   - Create a “Final Report” screen at the end of the simulation to evaluate the participant’s CPR performance
     
*This was a fun project that allowed me to employ my medical background and push the limits of what a console app can do!*
