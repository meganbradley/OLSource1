---
title: "Extending the Status Bar"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "status bars, about status bars"
  - "status bars, overview"
ms.assetid: f955115c-4c5f-45ec-b41b-365868c5ec0c
caps.latest.revision: 27
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extending the Status Bar
You can use the Visual Studio status bar at the bottom of the IDE to display information.  
  
 When you extend the status bar, you can display information and UI in four regions: the feedback region, the progress bar, the animation region, and the designer region. The feedback region allows you to display text and highlight the displayed text. The progress bar shows incremental progress for short-running operations such as saving a file. The animation region displays a continuously-looped animation for long-running operations or operation of undetermined length, such as building multiple projects in a solution. And the designer region shows the line and column number of the cursor location.  
  
 You can get the status bar by using the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar*> interface (from the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar*> service). In addition, any object sited on a window frame can register as a status bar client object by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser*> interface. Whenever a window is activated, Visual Studio queries the object sited on that window for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface. If found, it calls the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo*> method on the returned interface and the object can update the status bar from within that method. Document windows, for example, can use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo*> method to update information in the designer region when they become active.  
  
 The following procedures assume that you understand how to create a VSIX project and add a custom menu command. For information, see [Creating an Extension with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md).  
  
## Modifying the Status Bar  
 This procedure shows you how to set and get text, display static text, and highlight the displayed text in the feedback region of the status bar.  
  
#### Reading and writing to the status bar  
  
1.  Create a VSIX project named **TestStatusBarExtension** and add a menu command named **TestStatusBarCommand**.  
  
2.  In TestStatusBarCommand.cs, replace the command handler method code (MenuItemCallback) with the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Compile the code and start debugging.  
  
4.  Open the **Tools** menu in the experimental instance of Visual Studio. Click the **Invoke TestStatusBarCommand** button.  
  
     You should see that the text in the status bar now reads **“We just wrote to the status bar.”** and the message box that appears has the same text.  
  
#### Updating the progress bar  
  
1.  In this procedure we will show how to initialize and update the progress bar.  
  
2.  Open the TestStatusBarCommand.cs file and replace the MenuItemCallback method with the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Compile the code and start debugging.  
  
4.  Open the **Tools** menu in the experimental instance of Visual Studio. Click **Invoke TestStatusBarCommand** button.  
  
     You should see that the text in the status bar now reads **“Writing to the progress bar.”** You should also see the progress bar get updated every second for 20 seconds. After that the status bar and the progress bar are cleared.  
  
#### Displaying an animation  
  
1.  The status bar displays a looping animation that indicates either a long-running operation (for example, building multiple projects in a solution). If you do not see this animation, make sure you have the correct **Tools / Options** settings:  
  
     Go to the **Tools/Options / General** tab and uncheck **Automatically adjust visual experience based on client performance**. Then check the sub-option **Enable rich client visual experience**. You should now be able to see the animation when you build the project in your experimental instance of Visual Studio.  
  
     In this procedure we display the standard Visual Studio animation which represents building a project or solution.  
  
2.  Open the TestStatusBarCommand.cs file and replace the MenuItemCallback method with the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
3.  Compile the code and start debugging.  
  
4.  Open the **Tools** menu in the experimental instance of Visual Studio and click **Invoke TestStatusBarCommand**.  
  
     When you see the message box, you should also see the animation in the status bar on the far right. When you dismiss the message box, the animation disappears.