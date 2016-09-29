---
title: "CImageList::DragLeave"
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
  - "CImageList::DragLeave"
  - "CImageList.DragLeave"
  - "DragLeave"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DragLeave method"
ms.assetid: c11a88a7-7f49-4d41-aec5-17151f3dca1b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::DragLeave
Unlocks the window specified by `pWndLock` and hides the drag image, allowing the window to be updated.  
  
## Syntax  
  
```  
  
      static BOOL PASCAL DragLeave(  
   CWnd* pWndLock   
);  
```  
  
#### Parameters  
 `pWndLock`  
 Pointer to the window that owns the drag image.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CImageList::EndDrag](../vs140/cimagelist--enddrag.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CImageList::BeginDrag](../vs140/cimagelist--begindrag.md)   
 [CImageList::EndDrag](../vs140/cimagelist--enddrag.md)   
 [CImageList::DragMove](../vs140/cimagelist--dragmove.md)   
 [CImageList::DragEnter](../vs140/cimagelist--dragenter.md)