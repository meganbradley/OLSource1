---
title: "How to: Read from and Write to the Feedback Region of the Status Bar"
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
  - "feedback region, Status Bar"
  - "Status Bar, feedback region"
  - "Status Bar, overview"
ms.assetid: e639561c-e1e7-4660-b2a2-8bca80f34a29
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Read from and Write to the Feedback Region of the Status Bar
The Feedback region of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] status bar displays text. You can set and retrieve text, display static text, and highlight the displayed text.  
  
### To use the Feedback region of the Visual Studio Status bar  
  
1.  Obtain an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar*> interface, which is made available through the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar*> service.  
  
2.  Determine whether the status bar is frozen by calling the [IsFrozen](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.IsFrozen(System.Int32@)?qualifyHint=False&autoUpgrade=True) method of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar*> instance.  
  
3.  Set the text of the Feedback region by calling the [SetText](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.SetText(System.String)?qualifyHint=False&autoUpgrade=True) method and passing in a text string.  
  
4.  Read the text of the Feedback region by calling the [GetText](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.GetText(System.String@)?qualifyHint=False&autoUpgrade=True) method.  
  
## Example  
 This example demonstrates how to write text to and read text from the Feedback region.  
  
 [!code[VSSDKFeedbackStatusBar#1](../vs140/codesnippet/CSharp/how-to--read-from-and-write-to-the-feedback-region-of-the-status-bar_1.cs)][!code[VSSDKFeedbackStatusBar#1](../vs140/codesnippet/VisualBasic/how-to--read-from-and-write-to-the-feedback-region-of-the-status-bar_1.vb)]  
  
 In the above example, the code does the following things:  
  
-   Obtains an instance of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar*> interface from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar*> service.  
  
-   Checks to see if the status bar is frozen by calling the assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.IsFrozen(System.Int32@)?qualifyHint=False&autoUpgrade=True method.  
  
-   Inhibits further updates to the status bar by calling the [FreezeOutput](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.FreezeOutput(System.Int32)?qualifyHint=False&autoUpgrade=True) method.  
  
-   Reads the text from the status bar by calling the assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.GetText(System.String@)?qualifyHint=False&autoUpgrade=True method and displays it in a message box.  
  
-   Allows updates to the status bar by calling assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.FreezeOutput(System.Int32)?qualifyHint=False&autoUpgrade=True and passing 0 in the parameter.  
  
-   Clears the contents of the status bar by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar.Clear*> method.  
  
## See Also  
 [Status Bar Overview](../vs140/extending-the-status-bar.md)   
 [How to: Program the Progress Bar Region of the Status Bar](../vs140/how-to--program-the-progress-bar-region-of-the-status-bar.md)   
 [How to: Use the Animation Region of the Status Bar](../vs140/how-to--use-the-animation-region-of-the-status-bar.md)   
 [How to: Program the Designer Region of the Status Bar](../vs140/how-to--program-the-designer-region-of-the-status-bar.md)