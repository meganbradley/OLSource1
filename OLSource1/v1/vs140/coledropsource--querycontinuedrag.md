---
title: "COleDropSource::QueryContinueDrag"
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
  - "QueryContinueDrag"
  - "COleDropSource::QueryContinueDrag"
  - "COleDropSource.QueryContinueDrag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDropSource class, overridables"
  - "QueryContinueDrag method"
ms.assetid: 4adf5bf4-1eac-4ca2-8c08-965b6d32f50e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropSource::QueryContinueDrag
After dragging has begun, this function is called repeatedly by the framework until the drag operation is either canceled or completed.  
  
## Syntax  
  
```  
  
      virtual SCODE QueryContinueDrag(  
   BOOL bEscapePressed,  
   DWORD dwKeyState   
);  
```  
  
#### Parameters  
 *bEscapePressed*  
 States whether the ESC key has been pressed since the last call to `COleDropSource::QueryContinueDrag`.  
  
 `dwKeyState`  
 Contains the state of the modifier keys on the keyboard. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
## Return Value  
 **DRAGDROP_S_CANCEL** if the ESC key or right button is pressed, or left button is raised before dragging starts. **DRAGDROP_S_DROP** if a drop operation should occur. Otherwise `S_OK`.  
  
## Remarks  
 Override this function if you want to change the point at which dragging is canceled or a drop occurs.  
  
 The default implementation initiates the drop or cancels the drag as follows. It cancels a drag operation when the ESC key or the right mouse button is pressed. It initiates a drop operation when the left mouse button is raised after dragging has started. Otherwise, it returns `S_OK` and performs no further operations.  
  
 Because this function is called frequently, it should be optimized as much as possible.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropSource Class](../vs140/coledropsource-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropSource::OnBeginDrag](../vs140/coledropsource--onbegindrag.md)   
 [COleDropTarget::OnDrop](../vs140/coledroptarget--ondrop.md)