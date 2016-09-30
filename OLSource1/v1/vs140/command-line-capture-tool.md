---
title: "Command-Line Capture Tool"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: db75b3a7-80b2-4a74-91d2-fd6e0f73b45d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Command-Line Capture Tool
DXCap.exe is a command-line tool for graphics diagnostics capture and playback. It supports Direct3D 10 through Direct3D 12 across all feature levels.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Under capture mode (<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>), <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> specifies the name of the graphics log file that graphics information is recorded to. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not specified, graphics information is recorded to a file named <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> by default.  
  
 Under validation (-v) mode, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> specifies the name of the graphics log file to be validated. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is not specified, the graphics log that was last validated is used again.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Under capture mode, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> specifies the frames that you want to capture. The first frame is 1. You can specify multiple frames by using commas and ranges. For example, if <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, then frames <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are captured.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Under capture mode, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> specifies the ranges of time, in seconds, during which you want to capture frames. You can specify multiple periods by using commas and ranges. For example if <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, then frames that are rendered between <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> seconds, and between<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> seconds are captured.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Under capture mode, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> specifies that frames will be captured manually by pressing the Print Screen key. Frames can be captured when the app starts; to stop capturing frames, return to the command line interface and press enter.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>]  
 Capture mode. Under capture mode, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> specifies the name of the app that you want to capture graphics information from; <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> specifies additional command-line parameters to that app.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>]  
 Playback mode (<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>). Under playback mode, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> specifies the name of the graphics log file to be played back. If <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is not specified, the graphics log that was last played back is used again.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Under playback mode, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> specifies that playback should be performed with the Direct3D debug layer enabled.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Under playback mode, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> specifies that playback should be performed using the WARP software renderer.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Under playback mode, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> specifies that playback should be performed using GPU hardware.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Under playback mode, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> displays information about the machine that was used to capture the graphics log file, if this information was recorded to the log.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Under playback mode, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> specifies that playback should be performed without modification to the recorded events. Under normal operation, playback mode might make minor changes to playback to simplify debugging and speed up playback. For example, it may simulate swap chain output rather than executing swap chain commands. Usually this is not a problem, but you might need playback to occur in a way that's more faithful to the recorded events; for example, you can use this option to restore full-screen rendering behavior to an app that was captured while running in full-screen mode.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>]  
 Under playback mode, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> specifies the name of the file where an XML representation of playback is written to. If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> is not specified, the XML representation is written to a file named the same as the file being played back, but given an <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> extension.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Validation mode. Under validation mode, captured frames are played back on both hardware and WARP, and their results are compared using an image comparison function. You can use this feature to quickly identify driver issues that affect your rendering.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 Under validation mode, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> specifies the set of graphics events whose immediate results are compared. For example, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> limits the comparison to only the events belonging to those categories.  
  
> [!TIP]
>  We recommend starting with <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> because this will reveal most issues but take significantly less time than a more extensive set of events. If necessary, you can specify a larger or different set of events to validate those events and reveal other kinds of issues.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Under validation mode, <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> halts validation when differences are detected between the hardware and WARP renderer. Validation resumes after a key is pressed.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Under validation mode, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> exits validation immediately when differences are detected between the hardware and WARP renderer. When the program exits in this way, it returns <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to the environment; otherwise it returns <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Under validation mode, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> displays progress information about the validation session. WARP progress is displayed on the left; hardware progress is displayed on the right.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Enumerates the Windows Store apps that are installed. You can use this information to perform command-line captures with Windows Store apps.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 Displays information about the machine and capture DLLs.  
  
## Remarks  
 DXCap.exe operates in three modes:  
  
 Capture mode (-c)  
 Capture graphics information from a running app and record it to a graphics log file. The capture capabilities and file format are identical to those of Visual Studio.  
  
 Playback mode (-p)  
 Play back previously captured graphics events from an existing graphics log file. By default, playback occurs in a window, even when the graphics log file was captured from a fullscreen app. Playback occurs in full-screen only when the graphics log file was captured from a fullscreen app and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is specified.  
  
 Validation mode (<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>)  
 Validates rendering behavior by playing back captured frames on both hardware and WARP, then comparing their results by using an image comparison function. You can use this feature to quickly identify driver issues that affect your rendering.  
  
 In addition to these modes, dxcap.exe performs two other functions that do not perform capture or playback of graphics information.  
  
 Enumeration function (<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>)  
 Displays details about the Windows Store apps that are installed on the machine. These details include the package name and appid that identify the executable file in a Windows Store app. To capture graphics information from a windows store app using DXCap.exe, use the package name and appid instead of the executable filename that's used when you capture a desktop app.  
  
 Info function (<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Displays details about the machine and capture DLLs.  
  
## Examples  
  
### Capture graphics information from a desktop app  
 Use <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> to specify the app from which you want to capture graphics information.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 By default, graphics information is recorded to a file named <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to specify a different file to record to.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specify additional command-line parameters to the app that you're capturing from by including them after the app's filename.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The command in the example above captures graphics information from the desktop version of Internet Explorer while viewing the webpage located at www.fishgl.com which uses the WebGL API to render 3-D content.  
  
> [!NOTE]
>  Because command line arguments that appear after the app are passed to it, you must specify the arguments intended for DXCap.exe before using the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> option.  
  
### Capture graphics information from a Windows Store app.  
 You can capture graphics information from a Windows Store app.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Using DXCap.exe to capture from a Windows Store app is similar to using it to capture from a Windows desktop app, but instead identifying a desktop app by its filename, you identify a Windows Store app by its package name and the name or ID of the executable inside that package that you want to capture from. To make it easier to find out how to identify the Windows Store apps that are installed on your machine, use the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> option with DXCap.exe to enumerate them:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 You can provide an optional search string to help find the app that you're looking for. When the search string is provided, DXCap.exe enumerates the Windows Store apps whose package name, app name or app IDs match the search string. The search is case-insensitive.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The command above enumerates Windows Store apps that match "map"; here is the output:  
  
 **Package "Microsoft.BingMaps":**  
 **InstallDirectory : C:\Program Files\WindowsApps\Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe**  
 **FullName         : Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe**  
 **UserSID          : S-1-5-21-2127521184-1604012920-1887927527-5603533**  
 **Name             : Microsoft.BingMaps**  
 **Publisher        : CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US**  
 **Version          : 2.1.2914.1734**  
 **Launchable Applications:**  
 **Id   : AppexMaps**  
 **Exe  : C:\Program Files\WindowsApps\Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe\Map.exe**  
 **IsWWA: No**  
 **AppSpec (to launch): **DXCap.exe -c Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe,AppexMaps**** The last line of output for each enumerated app displays the command you can use to capture graphics information from it.  
  
### Capture specific frames or frames between specific times.  
 Use <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> to specify the frames that you want to capture using commas and ranges:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Or, use <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> to specify a set of time ranges during which to capture frames. Time ranges are specified in seconds, and multiple ranges can be specified:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Capture frames interactively.  
 Use <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> to capture frames interactively. Press the Enter key to start capture, and press the Enter key again to stop.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Play back a graphics log file  
 Use <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> to play back a previously captured graphics log file.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Leave out the filename to play back the graphics log that was captured most recently.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Play back in raw mode  
 Use <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> to play back captured commands exactly as they occurred. Under normal playback, certain commands are emulated, for example, a graphics log file captured from a full screen app will play back in a window; with raw mode enabled, the same file will attempt to play back in full screen.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Play back using WARP or a hardware device  
 You might want to force play back of a graphics log file captured on a hardware device to use WARP, or force playback of a log captured on WARP to use a hardware device. Use <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> to play back using WARP.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Use <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> to play back using hardware.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Validate a graphics log file against WARP  
 Under validation mode, the graphics log file is played back on both hardware and WARP, and their results are compared. This can help you identify rendering errors that are caused by the driver. Use –v to validate correct behavior of graphics hardware against WARP.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 To reduce the amount of comparisons, you can specify a subset of commands for validation to compare and other commands will be ignored. Use –examine to specify the commands whose results you want to compare.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Convert a Graphics Log file to PNGs  
 To view or analyze frames from a graphics log file, DXCap.exe can save captured frames as .png (Portable Network Graphics) image files. Use <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> to under playback mode to output captured frames as .png files.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Use <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> to specify the frames that you want to output.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Convert a Graphics Log file to XML  
 To process and analyze graphics logs using familiar tools like FindStr or XSLT, DXCap.exe can convert a graphics log file to XML. Use <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> under playback mode to convert the log to XML instead of playing it back.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 By default, the XML output is written to a file with the same name as the graphics log, but which has been given a .xml extension. In the example above, the XML file will be named **regression_test_12.xml**. To give the XML file a different name, specify it after <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The resulting file will contain XML that looks similar to this:  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
## Requirements