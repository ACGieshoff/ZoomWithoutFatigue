# This project and any scripts related to it comes without any warranty. You are responsible yourself for teh content you download.

# Zoom without Fatigue
"Zoom without Fatigue. A pilot study on the use of Augmented Reality in video conferences" is a project that investigates whether the use of augmented reality technology can decrease Zoom fatigue experienced during video conferences and video interpreting. To explore this question, an app has been developped aaht simulates a video conference (emphasis on "simulates". It's not a real one). 
The project has been conducted from Jan 2023 to June 2024 at the ZHAW - Zurich university of Applied Sciences, School of Applied Linguistics, and funded by the digital initiative Zurich (for more information see https://www.zhaw.ch/en/research/research-database/project-detailview/projektid/6056/). 

The demo version accessible here was developed on Unity using the MRTK Toolkit for Hololens 2 (details see below). It illustrates the functionalities of the app:
- 4 holograms (2 with videos, 2 with images) and a menu. the 
- interactable holograms. That is: They can be moved and rescaled. The idea here is that the user can arrange the holograms according to their convenience. The rotation is constrained on the x- and y axis so that the holograms are always "straight".
- playing two videos on button press (for the study, I used one speaker video and one video for the audience)
- stopping and resetting the "video conference"
- displaying "slides" that change automatically with the source speech (you'll have to define the timepoints when the slides need to change, though)
- displaying an additional, static "slide"
- toggling gesture commands. They are desactivated automatically when the video starts to play, but can be activated again by pressing the gesture toggle button
- exiting the app

What you can do:
1) Open the demo app in unity
2) Change the video and slide material with your own material (mp4 and jpg)
   - drag the videos on the video player ojects: Look at the Project and the Assets (bottom of your screen). Drag your videos in the "Video" Directory. You can create subdirectories for your videos, if that helps. Have a look at the hierachy on teh right side of the screen, click on Speaker, click on VideoPplayerSpeaker, look at the Inspector on the left side of the screen, scroll down to "Play Video List", put the number of videos in first field just next to "video clip"s and drag the videos on each line starting with "Element". Do the same with the "Attendees" object.
   - Now the slides: Drag your images Materials directory. Create for each image a material. To do so, click right on the Asset > Materials windows (bottom of the screen), create new..., choose material. open the Material in teh inspector (just click on it) and drag the image on the Albedo field (I really mean that little field left to the word "Albedo"). I highly recommend to rename the material in some meaningful way (ex: TextA_slide1 or so).Do so with all your images. then, open the "Slides" object, scroll down to Material Changer, indicate the number of slides for each speech and drag and drop your slide materials on each line starting with "Element". In teh "change duratoin" section, indicate the duration for each slide. If you write 3, it'll be visible for 3 seconds.
3) rebuild the app: Open the File > build settings> Player settings > adapt imformation over there (name of the app, etc.); In  Build Settings > target Device hololens, Architecure ARM64, Build: USB device, check Development Build. Attention: unity needs an empty directory for the build. Just create a new folder in your Explorer
4) Open the .sln file in Visual Studio, on the righten side your find the project explorer. Click right on the name of the app and choose "Publish". I followed the instructions here: https://www.linkedin.com/pulse/how-create-unity-app-installer-hololens-2-appx-install-ivana-tilca and it worked.

The detailed version information:
- Unity version: 2020.3.38f1
- Architecture: ARM64
- Minimum platform version: 10.0.10240.0
- MRTK Toolkit 2.8.3

Please keep in mind that I'm not a developper. So there will be a lot of information here that you miss (because you are probably much more experienced and know what to expect in such a file). Just ask. 
