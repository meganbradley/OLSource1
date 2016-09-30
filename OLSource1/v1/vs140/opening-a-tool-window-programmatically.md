---
title: "Opening a Tool Window Programmatically"
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
  - "tool windows, creating programmatically"
ms.assetid: 0017441e-7aa3-4a61-9939-57af11d90d97
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Opening a Tool Window Programmatically
Tool windows are typically opened by clicking a command on a menu, or by pressing an equivalent keyboard shortcut. However, you might have to open a tool window programmatically, like the command handler does.  
  
 To open a tool window in the managed VSPackage that provides it, use \<xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow*>. To open a tool window in another VSPackage, use \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.FindToolWindow*>. In either case, the tool window is created as required.  
  
 The following code is taken from the C# Reference.ToolWindow sample.  
  
### To open a tool window programmatically  
  
1.  Create the tool window pane, frame, and the VSPackage that implements them. For more information, see [How to: Create a Tool Window (C#)](../vs140/adding-a-tool-window.md).  
  
2.  Add the \<xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute*> to the VSPackage that provides it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     This registers the tool window PersistedWindowPane to be opened as docked to **Solution Explorer**. For more information, see [How To: Register a Tool Window (C#)](../vs140/registering-a-tool-window.md).  
  
3.  Use \<xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow*> to find the tool window pane or to create it if it does not already exist.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Get the tool window frame from the tool window pane.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
5.  Show the tool window.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>