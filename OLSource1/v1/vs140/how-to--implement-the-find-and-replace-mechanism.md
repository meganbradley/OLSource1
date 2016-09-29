---
title: "How to: Implement the Find and Replace Mechanism"
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
  - "editors [Visual Studio SDK], legacy - find and replace"
ms.assetid: bbd348db-3d19-42eb-99a2-3e808528c0ca
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Implement the Find and Replace Mechanism
Visual Studio provides two ways of implementing Find/Replace. One way is to pass a text image to the shell and let it handle searching, highlighting, and replacing text. This allows users to specify multiple text spans. Alternatively, your VSPackage can control this functionality itself. In both cases you must notify the shell about the current target and the targets for all open documents.  
  
### To implement Find/Replace  
  
1.  Implement the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget*> interface on one of the objects returned by the frame properties <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_DocView*> or <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID.VSFPROPID_DocData*>. If you are creating a custom editor, you should implement this interface as part of the custom editor class.  
  
2.  Use the [GetCapabilities](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetCapabilities(System.Boolean[],System.UInt32[])?qualifyHint=False&autoUpgrade=True) method to specify the options that your editor supports and to indicate whether it implements text image searching.  
  
     If your editor supports text image searching, implement [GetSearchImage](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetSearchImage(System.UInt32,Microsoft.VisualStudio.TextManager.Interop.IVsTextSpanSet[],Microsoft.VisualStudio.TextManager.Interop.IVsTextImage@)?qualifyHint=False&autoUpgrade=True).  
  
     Otherwise, implement [Find](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find(System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.UInt32@)?qualifyHint=False&autoUpgrade=True) and [Replace](assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace(System.String,System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.Int32@)?qualifyHint=False&autoUpgrade=True).  
  
3.  If you implement the assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find(System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.UInt32@)?qualifyHint=False&autoUpgrade=True and assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace(System.String,System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.Int32@)?qualifyHint=False&autoUpgrade=True methods, you can simplify your searching tasks by calling the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper*> interface.  
  
## See Also  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper*>   
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget*>   
 assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Find(System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.UInt32@)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.GetSearchImage(System.UInt32,Microsoft.VisualStudio.TextManager.Interop.IVsTextSpanSet[],Microsoft.VisualStudio.TextManager.Interop.IVsTextImage@)?qualifyHint=False&autoUpgrade=True   
 assetId:///M:Microsoft.VisualStudio.TextManager.Interop.IVsFindTarget.Replace(System.String,System.String,System.UInt32,System.Int32,Microsoft.VisualStudio.TextManager.Interop.IVsFindHelper,System.Int32@)?qualifyHint=False&autoUpgrade=True   
 <xref:Microsoft.VisualStudio.Shell.Interop.__VSPROPID*>