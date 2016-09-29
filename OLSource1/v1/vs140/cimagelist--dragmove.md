---
title: "CImageList::DragMove"
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
  - "CImageList::DragMove"
  - "CImageList.DragMove"
  - "DragMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DragMove method"
ms.assetid: 2ac0ab9e-b2a8-4eb2-9028-a2b2ead18184
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::DragMove
Call this function to move the image that is being dragged during a drag-and-drop operation.  
  
## Syntax  
  
```  
  
      static BOOL PASCAL DragMove(  
   CPoint pt   
);  
```  
  
#### Parameters  
 `pt`  
 New drag position.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This function is typically called in response to a `WM_MOUSEMOVE` message. To begin a drag operation, use the `BeginDrag` member function.  
  
## Example  
 [!code[NVC_MFC_CImageList#4](../vs140/codesnippet/CPP/cimagelist--dragmove_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::BeginDrag](../vs140/cimagelist--begindrag.md)   
 [CImageList::EndDrag](../vs140/cimagelist--enddrag.md)   
 [CImageList::Draw](../vs140/cimagelist--draw.md)