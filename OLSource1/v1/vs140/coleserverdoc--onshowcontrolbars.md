---
title: "COleServerDoc::OnShowControlBars"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "OnShowControlBars"
  - "COleServerDoc::OnShowControlBars"
  - "COleServerDoc.OnShowControlBars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, overridables"
  - "OnShowControlBars method"
ms.assetid: 26f4faad-d134-4a86-8527-3d997f2807c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::OnShowControlBars
The framework calls this function to show or hide the server application's control bars associated with the frame window identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the frame window whose control bars should be hidden or shown.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Determines whether control bars are shown or hidden.  
  
## Remarks  
 The default implementation enumerates all control bars owned by that frame window and hides or shows them.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::ActivateInPlace](../vs140/coleserverdoc--activateinplace.md)   
 [COleServerDoc::OnReactivateAndUndo](../vs140/coleserverdoc--onreactivateandundo.md)   
 [COleServerDoc::OnFrameWindowActivate](../vs140/coleserverdoc--onframewindowactivate.md)   
 [COleServerDoc::IsInPlaceActive](../vs140/coleserverdoc--isinplaceactive.md)