---
title: "Video Walkthrough: Interoperate with Third-Party Tools"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 205ff175-00b9-45f9-b6d5-3af8e1184bed
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Video Walkthrough: Interoperate with Third-Party Tools
[!INCLUDE[cordova_disclaimer](../vs140/includes/cordova_disclaimer_md.md)]  
  
 Apache Cordova projects that you create using many third party tools are compatible with Visual Studio 2015, including projects that you create using command line interfaces (CLIs) such as Cordova and Ionic. In this video walkthrough, we show you how to use Visual Studio 2015 with a project that you create using the Ionic CLI.  
  
 This article matches the steps of the Cordova [Video tutorial](http://go.microsoft.com/fwlink/p/?LinkID=534728) on interoperability.  
  
## Prerequisites  
 To follow the steps in this tutorial, you must:  
  
1.  [Install Visual Studio 2015](http://go.microsoft.com/fwlink/p/?LinkId=397606) with Visual Studio Tools for Apache Cordova.  
  
2.  [Install the Ionic CLI](http://ionicframework.com/docs/cli/install.html)  
  
## Using a third party CLI (Ionic)  
  
#### To use Visual Studio and the Ionic CLI  
  
1.  Open a command line and switch to the folder where you will create the Ionic app using the CLI, such as Desktop.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Type the following command to create a new Ionic project using the Slide starter template:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Ionic creates the project. In File Explorer, you can find the new project, MyIonicApp, in the location that you created it.  
  
     Next, we will prepare the same project so that you can open it in Visual Studio. We will do that by adding files to the project that contain metadata required by Visual Studio.  
  
3.  Open Visual Studio and create a new Apache Cordova solution using the Blank App template and name the solution <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
4.  Close the solution in Visual Studio.  
  
5.  From the location of the Visual Studio project, copy cli.jsproj and taco.json to the project folder for MyIonicApp.  
  
     ![Project structure in Ionic](../vs140/media/cordova_videos_interoperability_ionic.png "Cordova_Videos_Interoperability_Ionic")  
  
6.  In Visual Studio, locate the cli.jsproj file in the MyIonicApp folder, select it, and open it.  
  
     Visual Studio loads the Ionic project as a Visual Studio solution.  
  
7.  In Solution Explorer, choose **Show All Files**.  
  
     ![Project structure in Visual Studio](../vs140/media/cordova_videos_interoperability_vs.png "Cordova_Videos_Interoperability_VS")  
  
8.  In the command prompt, switch to the MyIonicApp folder.  
  
9. Type the following command:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Ionic adds a platforms folder and populates the project with any other required files for Android.  
  
     From here, you can make project changes either using Visual Studio or the Ionic CLI.