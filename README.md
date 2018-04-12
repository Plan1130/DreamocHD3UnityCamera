# DreamocHD3UnityCamera

This file is a quick template that allows a Unity project to be displayed 
on a Dreamoc HD3 by Real Fiction (www.realfiction.com).

Download: https://github.com/Plan1130/DreamocHD3UnityCamera/releases/latest

The Dreamoc underneath is little more than a fancy monitor, and does not do 
any positioning/resizing of screens and requires the user to format video
files in a manner that may require too much effort from a non technical
user. There is an official template for AfterEffects that allows one single
video to be displayed on all 3 sides. Because of it's 3D selling point this
may seem not all too appropriate, and it doesn't do well to the potential
of the Dreamoc HD3.

This is where this simple, but nifty little program comes in. It's
basically a camera on which three other cameras are projected. In more
technical terms; it shows a canvas, where 3 RenderTextures are pre-installed.
The textures are rendered through a mask that provides the cut outs, as 
defined by the AfterEffects template by Real Fiction.

The easiest way to have a camera displayed, is to set the Target Texture
setting of a camera to a RenderTexture (e.g. FrontRenderTexture). For
this you will need 3 different cameras. If you want one camera displayed
on different panels, you need to add the script CameraToBuffer to that
camera, and add the RenderTextures to the 'textures' list.

For a demo on how to use it, see my other project:
https://github.com/Plan1130/DreamocHD3UnityCameraDemoProject
It may bug you about whether or not Blender is installed, but it should 
run perfectly fine without it. This is the open source MAVEN model, by NASA,
that is causing this, but it is non-essential to the functioning of the
project. However, Blender is free and open source, so you might want to look
into it.

NOTE1: The Dreamoc HD3 has a resolution of 1920x1080. You might want to
stick to it. At the very least, keep a 16:9 ratio.

NOTE2: For every camera, set the background to Solid Color, and the color
to black. This greatly enhances the 'floating' illusion.

NOTE3: If you experience lag, this is due to the fact that Unity renders 3
screens of each 1280x720 resolution. You may change this in the 
RenderTextures folder, for each RenderTexture.

NOTE4: The Projections show a cropped image. They are positioned so that
the middle of the camera are optically in the middle, and so the the entire
screen can be used. It may, however, require a little tweaking on your end.


I spent quite some effort on it, but you are free to use it as defined 
in the LICENSE file. If we meet some day, and you think this stuff is 
worth it, you can buy me a beer in return.                    Sander Koning
