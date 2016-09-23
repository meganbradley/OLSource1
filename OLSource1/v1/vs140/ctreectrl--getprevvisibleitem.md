---
title: "CTreeCtrl::GetPrevVisibleItem"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CTreeCtrl::GetPrevVisibleItem
  - GetPrevVisibleItem
  - CTreeCtrl.GetPrevVisibleItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPrevVisibleItem method
ms.assetid: 6ed0fa1b-80f5-4b0b-819c-ecb82c9961d2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::GetPrevVisibleItem
Call this function to retrieve the previous visible item of `hItem`.  
  
## Syntax  
  
```  
  
      HTREEITEM GetPrevVisibleItem(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 The handle of the previous visible item; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#23](../vs140/codesnippet/CPP/ctreectrl--getprevvisibleitem_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetNextVisibleItem](../vs140/ctreectrl--getnextvisibleitem.md)   
 [CTreeCtrl::GetFirstVisibleItem](../vs140/ctreectrl--getfirstvisibleitem.md)   
 [CTreeCtrl::EnsureVisible](../vs140/ctreectrl--ensurevisible.md)   
 [CTreeCtrl::GetVisibleCount](../vs140/ctreectrl--getvisiblecount.md)