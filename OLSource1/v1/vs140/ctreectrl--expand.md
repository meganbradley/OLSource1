---
title: "CTreeCtrl::Expand"
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
  - TVE_COLLAPSERESET
  - CTreeCtrl::Expand
  - CTreeCtrl.Expand
  - TVE_COLLAPSE
  - TVE_TOGGLE
  - TVE_EXPAND
dev_langs: 
  - C++
helpviewer_keywords: 
  - TVE_COLLAPSERESET
  - TVE_EXPAND
  - TVE_COLLAPSE
  - TVE_TOGGLE
  - Expand method
ms.assetid: 1520e332-eb3d-4d0e-a7f7-d2897c5313b2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::Expand
Call this function to expand or collapse the list of child items, if any, associated with the given parent item.  
  
## Syntax  
  
```  
  
      BOOL Expand(  
   HTREEITEM hItem,  
   UINT nCode   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the tree item being expanded.  
  
 `nCode`  
 A flag indicating the type of action to be taken. This flag can have one of the following values:  
  
-   `TVE_COLLAPSE` Collapses the list.  
  
-   `TVE_COLLAPSERESET` Collapses the list and removes the child items. The **TVIS_EXPANDEDONCE** state flag is reset. This flag must be used with the `TVE_COLLAPSE` flag.  
  
-   `TVE_EXPAND` Expands the list.  
  
-   `TVE_TOGGLE` Collapses the list if it is currently expanded or expands it if it is currently collapsed.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CTreeCtrl::EnsureVisible](../vs140/ctreectrl--ensurevisible.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::EnsureVisible](../vs140/ctreectrl--ensurevisible.md)