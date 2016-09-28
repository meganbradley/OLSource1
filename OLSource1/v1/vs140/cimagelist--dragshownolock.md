---
title: "CImageList::DragShowNolock"
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
  - "CImageList::DragShowNolock"
  - "DragShowNolock"
  - "CImageList.DragShowNolock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DragShowNolock method"
ms.assetid: fb8a3055-4f91-476b-8c84-f391c030d443
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::DragShowNolock
Shows or hides the drag image during a drag operation, without locking the window.  
  
## Syntax  
  
```  
  
      static BOOL PASCAL DragShowNolock(  
   BOOL bShow   
);  
```  
  
#### Parameters  
 `bShow`  
 Specifies whether the drag image is to be shown.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The [CImageList::DragEnter](../vs140/cimagelist--dragenter.md) function locks all updates to the window during a drag operation. This function, however, does not lock the window.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::BeginDrag](../vs140/cimagelist--begindrag.md)   
 [CImageList::EndDrag](../vs140/cimagelist--enddrag.md)   
 [CImageList::DragEnter](../vs140/cimagelist--dragenter.md)   
 [CImageList::DragLeave](../vs140/cimagelist--dragleave.md)   
 [CImageList::Draw](../vs140/cimagelist--draw.md)