---
title: "How to: Specify Build Events (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "pre-build events"
  - "events [Visual Studio], builds"
  - "post-build events"
  - "build events [Visual Studio]"
  - "builds [Visual Studio], events"
ms.assetid: b4ce1ad9-5215-4b6f-b6a2-798b249aa335
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify Build Events (C#)
Use build events to specify commands that run before the build starts or after the build finishes. Build events are executed only if the build successfully reaches those points in the build process.  
  
 When a project is built, pre-build events are added to a file that is named PreBuildEvent.bat and post-build events are added to a file that is named PostBuildEvent.bat. If you want to ensure error checking, add your own error-checking commands to the build steps.  
  
 [!INCLUDE[note_settings_general](../vs140/includes/note_settings_general_md.md)]  
  
## How to Specify Pre-Build and Post-Build Events  
  
#### To specify a build event  
  
1.  In **Solution Explorer**, select the project for which you want to specify the build event.  
  
2.  On the **Project** menu, click **Properties**.  
  
3.  Select the **Build Events** tab.  
  
4.  In the **Pre-build event command line** box, specify the syntax of the build event.  
  
    > [!NOTE]
    >  Pre-build events do not run if the project is up to date and no build is triggered.  
  
5.  In the **Post-build event command line** box, specify the syntax of the build event.  
  
    > [!NOTE]
    >  Add a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement before all post-build commands that run .bat files. For example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
6.  In the **Run the post-build event** box, specify under what conditions to run the post-build event.  
  
    > [!NOTE]
    >  To add lengthy syntax, or to select any build macros from the [Pre-build Event/Post-build Event Command Line Dialog Box](../vs140/pre-build-event-post-build-event-command-line-dialog-box.md), click the Ellipsis button (**…**) to display an edit box.  
  
     The build event syntax can include any command that is valid at a command prompt or in a .bat file. The name of a batch file should be preceded by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to ensure that all subsequent commands are executed.  
  
     **Note** If your pre-build or post-build event does not complete successfully, you can terminate the build by having your event action exit with a code other than zero (0), which indicates a successful action.  
  
## Example: How to Change Manifest Information by Using a Post-Build Event  
 The following procedure shows how to set the minimum operating system version in the application manifest by using an .exe command that is called from a post-build event (the .exe.manifest file in the project directory). The minimum operating system version is a four-part number such as 4.10.0.0. To do this, the command will change the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section of the manifest:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### To create an .exe command to change the application manifest  
  
1.  Create a console application for the command. From the **File** menu, point to **New**, and then click **Project**.  
  
2.  In the **New Project** dialog box, expand **Visual C#**, click **Windows**, and then click the **Console Application** template. Name the project <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
3.  In Program.cs, add the following line to the other <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statements at the top of the file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  In the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> namespace, replace the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class implementation with the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The command takes two arguments: the path of the application manifest (that is, the folder in which the build process creates the manifest, typically Projectname.publish), and the new operating system version.  
  
5.  Build the project. On the **Build** menu, click **Build Solution**.  
  
6.  Copy the .exe file to a directory such as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 Next, invoke this command in a post-build event to modify the application manifest.  
  
#### To invoke a post-build event to modify the application manifest  
  
1.  Create a Windows application for the project to be published. From the **File** menu, point to **New**, and then click **Project**.  
  
2.  In the **New Project** dialog box, expand **Visual C#**, click **Windows**, and then click the **Windows Forms Application** template. Name the project <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
3.  With the project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
4.  In the Project Designer, locate the **Publish** page and set **Publishing location** to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
5.  Publish the project by clicking **Publish Now**.  
  
     The manifest file will be built and put in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. To view the manifest, right-click the file, click **Open with**, select **Select the program from a list**, and then click **Notepad**.  
  
     Search in the file for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element. For example, the version might be:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  In the Project Designer, click the **Build Events** tab and click the **Edit Post-build** button.  
  
7.  In the **Post-build Event Command Line** box, type the following command:  
  
     <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
     When you build the project, this command will change the minimum operating system version in the application manifest to 5.1.2600.0.  
  
     Because the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> macro expresses the full path for the executable being created,  the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.manifest will specify the application manifest created in the bin directory. Publishing will copy this manifest to the publishing location that you set earlier.  
  
8.  Publish the project again. Go to the **Publish** page and click **Publish Now**.  
  
     View the manifest again. To view the manifest, open the publish directory, right-click the file, click **Open with**, select **Select the program from a list**, and then click **Notepad**.  
  
     The version should now read:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Build Events Page, Project Designer (C#)](../vs140/build-events-page--project-designer--csharp-.md)   
 [Pre-build Event/Post-build Event Command Line Dialog Box](../vs140/pre-build-event-post-build-event-command-line-dialog-box.md)   
 [How To: Specify Build Events (Visual Basic)](../vs140/how-to--specify-build-events--visual-basic-.md)   
 [Building in Visual Studio](../vs140/compiling-and-building-in-visual-studio.md)