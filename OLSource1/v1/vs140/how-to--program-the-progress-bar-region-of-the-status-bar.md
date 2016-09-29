---
title: "How to: Program the Progress Bar Region of the Status Bar"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Status Bar, progress bar region"
  - "progress bar, Status Bar"
  - "Status Bar, programming"
ms.assetid: 4b54616a-8c20-436d-b764-f2380e5760f2
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Program the Progress Bar Region of the Status Bar
The Progress Bar region of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] status bar displays the incremental progress of quick operations, for example, saving a file to disk.  
  
### To use the Progress Bar region of the Visual Studio status bar  
  
1.  Obtain an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar*> interface, which is made available through the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar*> service.  
  
2.  Initialize the progress bar to starting values by calling the [Progress](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Progress(System.UInt32@,System.Int32,System.String,System.UInt32,System.UInt32)?qualifyHint=False&autoUpgrade=True) method.  
  
3.  Update the progress bar as your operation proceeds by using the assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Progress(System.UInt32@,System.Int32,System.String,System.UInt32,System.UInt32)?qualifyHint=False&autoUpgrade=True method to set new values.  
  
## Example  
 This example demonstrates how to initialize and update the progress bar.  
  
 [!code[VSSDKProgressStatusBar#1](../vs140/codesnippet/CSharp/how-to--program-the-progress-bar-region-of-the-status-bar_1.cs)]
[!code[VSSDKProgressStatusBar#1](../vs140/codesnippet/VisualBasic/how-to--program-the-progress-bar-region-of-the-status-bar_1.vb)]  
  
 In the example, the code:  
  
-   Obtains an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar*> interface from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar*> service.  
  
-   Initializes the progress bar to given starting values by calling the assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Progress(System.UInt32@,System.Int32,System.String,System.UInt32,System.UInt32)?qualifyHint=False&autoUpgrade=True method.  
  
-   Simulates an operation by iterating through a `for` loop and updating the progress bar values by using the assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Progress(System.UInt32@,System.Int32,System.String,System.UInt32,System.UInt32)?qualifyHint=False&autoUpgrade=True method.  
  
-   Clears the progress bar by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Clear*> method.  
  
## See Also  
 [Status Bar Overview](../vs140/extending-the-status-bar.md)   
 [How to: Read from and Write to the Feedback Region of the Status Bar](../vs140/how-to--read-from-and-write-to-the-feedback-region-of-the-status-bar.md)   
 [How to: Use the Animation Region of the Status Bar](../vs140/how-to--use-the-animation-region-of-the-status-bar.md)   
 [How to: Program the Designer Region of the Status Bar](../vs140/how-to--program-the-designer-region-of-the-status-bar.md)