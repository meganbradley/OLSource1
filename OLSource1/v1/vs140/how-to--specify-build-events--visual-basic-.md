---
title: "How to: Specify Build Events (Visual Basic)"
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
ms.assetid: 40dc83bf-a7c5-4a14-816a-fa0980b6e4c3
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Specify Build Events (Visual Basic)
Build events in Visual Basic can be used to run scripts, macros, or other actions as a part of the compilation process. Pre-build events occur before compilation; post-build events occur after compilation.  
  
 Build events are specified in the **Build Events** dialog box, available from the **Compile** page of the **Project Designer**.  
  
> [!NOTE]
>  Visual Basic Express does not support entry of build events. This is supported only in the full Visual Studio product.  
  
## How to Specify Pre-Build and Post-Build Events  
  
#### To specify a build event  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Compile** tab.  
  
3.  Click the **Build Events** button to open the **Build Events** dialog box.  
  
4.  Enter the command-line arguments for your pre-build or post-build action, and then click **OK**.  
  
    > [!NOTE]
    >  Add a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement before all post-build commands that run .bat files. For example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  If your pre-build or post-build event does not complete successfully, you can terminate the build by having your event action exit with a code other than zero (0), which indicates a successful action.  
  
## Example: How to Change Manifest Information Using a Post-Build Event  
 The following procedure shows how to set the minimum operating system version in the application manifest using an .exe command called from a post-build event (the .exe.manifest file in the project directory). The minimum operating system version is a four-part number such as 4.10.0.0. To do this, the command will change the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> section of the manifest:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### To create an .exe command to change the application manifest  
  
1.  Create a console application for the command. From the **File** menu, click **New**, and then click **Project**.  
  
2.  In the **New Project** dialog box, in the **Visual Basic** node, select **Windows** and then the **Console Application** template. Name the project <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
3.  In Module1.vb, add the following line to the other <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statements at the top of the file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Add the following code in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The command takes two arguments. The first argument is the path to the application manifest (that is, the folder in which the build process creates the manifest, typically Projectname.publish). The second argument is the new operating system version.  
  
5.  On the **Build** menu, click **Build Solution**.  
  
6.  Copy the .exe file to a directory such as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 Next, invoke this command in a post-build event to change the application manifest.  
  
#### To invoke a post-build event to change the application manifest  
  
1.  Create a Windows application for the project to be published. From the **File** menu, click **New**, and then click **Project**.  
  
2.  In the **New Project** dialog box, in the **Visual Basic** node, select **Windows** and then the **Windows Application** template. Name the project <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
3.  With the project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
4.  In the Project Designer, go to the **Publish** page and set **Publishing location** to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
5.  Publish the project by clicking **Publish Now**.  
  
     The manifest file will be built and put in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. To view the manifest, right-click the file and click **Open with**, then click **Select the program from a list**, and then click **Notepad**.  
  
     Search in the file for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element. For example, the version might be:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  In the Project Designer, go to the **Compile** tab and click the **Build Events** button to open the **Build Events** dialog box.  
  
7.  In the **Post-build Event Command Line** box, enter the following command:  
  
     <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
     When you build the project, this command will change the minimum operating system version in the application manifest to 5.1.2600.0.  
  
     The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> macro expresses the full path for the executable being created. Therefore, $(TargetPath).manifest will specify the application manifest created in the bin directory. Publishing will copy this manifest to the publishing location that you set earlier.  
  
8.  Publish the project again. Go to the **Publish** page and click **Publish Now**.  
  
     View the manifest again. To view the manifest, go to the publish directory, right-click the file and click **Open with** and then **Select the program from a list**, and then click **Notepad**.  
  
     The version should now read:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Managing Compilation Properties](assetId:///94308881-f10f-4caf-a729-f1028e596a2c)   
 [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md)   
 [Publish Page, Project Designer](../vs140/publish-page--project-designer.md)   
 [Pre-build Event/Post-build Event Command Line Dialog Box](../vs140/pre-build-event-post-build-event-command-line-dialog-box.md)   
 [How to: Specify Build Events (C#)](../vs140/how-to--specify-build-events--csharp-.md)