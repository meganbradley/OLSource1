---
title: "CTreeCtrl::GetNextVisibleItem"
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
  - "GetNextVisibleItem"
  - "CTreeCtrl::GetNextVisibleItem"
  - "CTreeCtrl.GetNextVisibleItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextVisibleItem method"
ms.assetid: 419a0e2d-af13-4b2d-8d5f-76575b129cc4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetNextVisibleItem
Call this function to retrieve the next visible item of `hItem`.  
  
## Syntax  
  
```  
  
      HTREEITEM GetNextVisibleItem(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 The handle of the next visible item; otherwise **NULL**.  
  
## Example  
 See the example for [CTreeCtrl::SetCheck](../vs140/ctreectrl--setcheck.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetPrevVisibleItem](../vs140/ctreectrl--getprevvisibleitem.md)   
 [CTreeCtrl::GetFirstVisibleItem](../vs140/ctreectrl--getfirstvisibleitem.md)   
 [CTreeCtrl::EnsureVisible](../vs140/ctreectrl--ensurevisible.md)   
 [CTreeCtrl::GetParentItem](../vs140/ctreectrl--getparentitem.md)