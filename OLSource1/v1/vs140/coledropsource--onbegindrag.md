---
title: "COleDropSource::OnBeginDrag"
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
  - "OnBeginDrag"
  - "COleDropSource::OnBeginDrag"
  - "COleDropSource.OnBeginDrag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDropSource class, overridables"
  - "OnBeginDrag method"
ms.assetid: d997751c-b571-4846-9b46-da91f19f574c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropSource::OnBeginDrag
Called by the framework when an event occurs that could begin a drag operation, such as pressing the left mouse button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the window that contains the selected data.  
  
## Return Value  
 Nonzero if dragging is allowed, otherwise 0.  
  
## Remarks  
 Override this function if you want to modify the way the dragging process is started. The default implementation captures the mouse and stays in drag mode until the user clicks the left or right mouse button or hits ESC, at which time it releases the mouse.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropSource Class](../vs140/coledropsource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropSource::GiveFeedback](../vs140/coledropsource--givefeedback.md)