---
title: "CTreeCtrl::SetItemState"
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
  - CTreeCtrl::SetItemState
  - CTreeCtrl.SetItemState
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetItemState method
ms.assetid: df7d7102-1c63-4f6c-a553-10e41d49982c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::SetItemState
Sets the state of the item specified by `hItem`.  
  
## Syntax  
  
```  
  
      BOOL SetItemState(  
   HTREEITEM hItem,  
   UINT nState,  
   UINT nStateMask   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the item whose state is to be set.  
  
 `nState`  
 Specifies new states for the item.  
  
 `nStateMask`  
 Specifies which states are to be changed.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 For information on states, see [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md).  
  
## Example  
 See the example for [CTreeCtrl::GetItemState](../vs140/ctreectrl--getitemstate.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)   
 [CTreeCtrl::GetItemState](../vs140/ctreectrl--getitemstate.md)