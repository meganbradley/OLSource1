---
title: "CImageList::BeginDrag"
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
  - "BeginDrag"
  - "CImageList::BeginDrag"
  - "CImageList.BeginDrag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BeginDrag method"
ms.assetid: f76526b7-7aea-499e-a87b-d18775cbb322
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::BeginDrag
Call this function to begin dragging an image.  
  
## Syntax  
  
```  
  
      BOOL BeginDrag(  
   int nImage,  
   CPoint ptHotSpot   
);  
```  
  
#### Parameters  
 `nImage`  
 Zero-based index of the image to drag.  
  
 `ptHotSpot`  
 Coordinates of the starting drag position (typically, the cursor position). The coordinates are relative to the upper left corner of the image.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This function creates a temporary image list that is used for dragging. The image combines the specified image and its mask with the current cursor. In response to subsequent `WM_MOUSEMOVE` messages, you can move the drag image by using the `DragMove` member function. To end the drag operation, you can use the `EndDrag` member function.  
  
## Example  
 [!code[NVC_MFC_CImageList#3](../vs140/codesnippet/CPP/cimagelist--begindrag_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::Draw](../vs140/cimagelist--draw.md)   
 [CImageList::EndDrag](../vs140/cimagelist--enddrag.md)   
 [CImageList::DragMove](../vs140/cimagelist--dragmove.md)