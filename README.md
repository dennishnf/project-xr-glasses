[![Made with Unity](https://img.shields.io/badge/Made%20with-Unity-57b9d3.svg?style=flat&logo=unity)](https://unity3d.com)
[![MIT Licence](https://badges.frapsoft.com/os/mit/mit.svg?v=103)](https://opensource.org/licenses/mit-license.php)
[![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](https://github.com/dennishnf/project-xr-glasses/issues)
[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)
[![Tweet](https://img.shields.io/twitter/url/http/shields.io.svg?style=social)](https://twitter.com/intent/tweet?text=Download%20and%20use%20the%20Project%20XR%20Glasses&url=https://github.com/dennishnf/project-xr-glasses&hashtags=unity,augmentedreality,unity3d,facedetection,arkit)     
    
    

# Project XR Glasses


## Description

Select the best glasses is time consuming and need to physically search in different shops.    

Here we implement a Real-Time Virtual Reality App for Android Devices that helps people to test a different variety of glasses without the need to physically test them. 



## Hardware & Software details

Developed in: Ubuntu 20.04 LTS    
Unity version: 2020.3.20f1    
Unity Packages:    
ProBuilder    
AR Foundation    
AR Core XR Plugin    
ARKit Face Tracking    
ARKit XR Plugin    
Intended Devices:    
Android Smartphones    
Versions >= 8.1.0 Oreo    
Tested on:    
Samsung Galaxy A32 (Android 11)    
Samsung Galaxy S10 (Android 11)    



## Wireframes

<p align="center">
<img src=".images-readme/wireframes.png" alt="Flowchart" width="450"/>
</p>

## Flowchart

<p align="center">
<img src=".images-readme/diagram.png" alt="Flowchart" width="340"/>
</p>


## Pseudo code: 

```
start the face detection
perform landmark extraction
run pre defined glasses models

for selected_glasses in models_list:
	anchor the points of face with glass 3d model
	show the face with the glasses
	read option of glasses
```


## Updates

### Update 23 Nov 2021:

Face detection and extraction of the most relevant points of the face were successfully implemented. The AR Foundation and ARKit Face Tracking packages were used for this purpose. The main challenges faced were: compatibility with android devices and successfully configuring the building options. 

<p align="center">
<img src=".images-readme/face-mask.png" alt="Examples" width="520"/>
</p>


### Update 30 Nov 2021:

Different lens models were collected in .obj format, but were converted to .prefab by creating a prefab object and then pulling the .obj lenses into that object. In addition, we tried to instantiate between a prefab object and a landmark point of the face, but we had problems with finding the indicated references.

<p align="center">
<img src=".images-readme/glasses.png" alt="Examples" width="450"/>
</p>


### Update 07 Dec 2021:

Successfully performed the attachment of a reference point of the face, and the placement of the lenses. This was done in several stages, in the first tests a prefab object was instantiated, then the position of the eyes was extracted and the position and rotation transformations were instantiated to that prefab object.

<p align="center">
<img src=".images-readme/glasses-face.png" alt="Examples" width="520"/>
</p>



## Demos

Demo on a Samsung Galaxy S10 (Android 11):

<p align="center">
<img src=".images-readme/final-version-1.gif" alt="Examples" width="150"/> 
&nbsp; &nbsp; &nbsp; &nbsp;
<img src=".images-readme/final-version-2.gif" alt="Examples" width="150"/>
</p>



## Using this repository

1. First, download or clone this repository.

2. Open Unity3D, and clic on "Add" in order to add the downloaded project

3. Go to "Settings Build and Run", then select "Android" and then "Switch Platform".

4. Install the packages: AR Fundation, AR Core XR Plugin, ARKit Face Tracking, ARKit XR Plugin.   

5. Then you can moddify the project or Build and Run on your Android smartphone. 

6. That's all, enjoy! :) 



## Group members

- Maikel BASTAWROUS  ([@MrMazagngy](https://github.com/MrMazagngy))   
- Yao SINAN  ([@iyfyao](https://github.com/iyfyao))    
- Dennis NUNEZ FERNANDEZ  ([@dennishnf](https://github.com/dennishnf))   



## References

- [AR Foundation Framework - Main Website](https://unity.com/unity/features/arfoundation)
- [Setting Up AR Foundation](https://learn.unity.com/tutorial/setting-up-ar-foundation#5fe2be51edbc2a1f5e69872f)    
- [ARKit Face Tracking](https://docs.unity3d.com/Packages/com.unity.xr.arkit-face-tracking@4.1/manual/index.html)    
- [Unity AR Foundation Tutorial - Getting Started with Face Tracking](https://www.youtube.com/watch?v=y0L_AdJICEU)    
- [Unity3d ARKit Face Tracking and placing face game objects with anchor data](https://www.youtube.com/watch?v=JQEovMKq2U0)    
- [Face Tracking using ARKit and AR Foundation with Unity](https://tutorialsforar.com/face-tracking-using-arkit-and-ar-foundation-with-unity/)    
- [ARKit 3 Face Tracking Tutorial](https://4experience.co/arkit-3-face-tracking/)
- [ARKit And ARCore - How To Dynamically Select Face Masks](https://www.youtube.com/watch?v=SzMeRtJ8oTc)    





<!---

git pull
git add -A
git commit -m "v0"
git push -u origin main

--->

