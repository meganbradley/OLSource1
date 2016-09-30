---
title: "CTreeCtrl::GetCheck"
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
  - "CTreeCtrl::GetCheck"
  - "CTreeCtrl.GetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCheck method"
ms.assetid: c32c3ff1-6b75-46f7-bdd5-3b4431a36601
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetCheck
Call this member function to retrieve an item's check state.  
  
## Syntax  
  
```  
  
      BOOL GetCheck(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 The **HTREEITEM** about which to receive the state information.  
  
## Return Value  
 Nonzero if the tree control item is checked; otherwise 0.  
  
## Example  
 See the example for [CTreeCtrl::SetCheck](../vs140/ctreectrl--setcheck.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetCheck](../vs140/ctreectrl--setcheck.md)