---
title: "CTreeCtrl::SortChildrenCB"
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
  - "CTreeCtrl::SortChildrenCB"
  - "TV_SORTCB"
  - "SortChildrenCB"
  - "CTreeCtrl.SortChildrenCB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SortChildrenCB method"
  - "TV_SORTCB"
ms.assetid: f5a2ee74-9b63-4e5a-b92b-560648b2987d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SortChildrenCB
Call this function to sort tree view items using an application-defined callback function that compares the items.  
  
## Syntax  
  
```  
  
      BOOL SortChildrenCB(  
   LPTVSORTCB pSort   
);  
```  
  
#### Parameters  
 *pSort*  
 Pointer to a [TVSORTCB](http://msdn.microsoft.com/library/windows/desktop/bb773462) structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The structure's comparison function, **lpfnCompare**, must return a negative value if the first item should precede the second, a positive value if the first item should follow the second, or zero if the two items are equivalent.  
  
 The `lParam1` and `lParam2` parameters correspond to the **lParam** member of the [TVITEM](http://msdn.microsoft.com/library/windows/desktop/bb773456) structure for the two items being compared. The `lParamSort` parameter corresponds to the **lParam** member of the `TV_SORTCB` structure.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#38](../vs140/codesnippet/CPP/ctreectrl--sortchildrencb_1.cpp)]  
  
 [!code[NVC_MFC_CTreeCtrl#39](../vs140/codesnippet/CPP/ctreectrl--sortchildrencb_2.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SortChildren](../vs140/ctreectrl--sortchildren.md)