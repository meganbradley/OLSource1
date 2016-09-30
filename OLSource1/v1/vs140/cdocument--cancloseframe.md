---
title: "CDocument::CanCloseFrame"
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
  - "CDocument.CanCloseFrame"
  - "CDocument::CanCloseFrame"
  - "CanCloseFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanCloseFrame method"
  - "frames, in documents"
  - "CDocument class, overridables"
  - "document frames"
ms.assetid: 5b2730a7-5aae-47c0-afea-1dbdf17400e5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::CanCloseFrame
Called by the framework before a frame window displaying the document is closed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the frame window of a view attached to the document.  
  
## Return Value  
 Nonzero if it is safe to close the frame window; otherwise 0.  
  
## Remarks  
 The default implementation checks if there are other frame windows displaying the document. If the specified frame window is the last one that displays the document, the function prompts the user to save the document if it has been modified. Override this function if you want to perform special processing when a frame window is closed. This is an advanced overridable.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::SaveModified](../vs140/cdocument--savemodified.md)