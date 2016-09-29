---
title: "CTreeCtrl::SetCheck"
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
  - "CTreeCtrl::SetCheck"
  - "CTreeCtrl.SetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCheck method"
ms.assetid: 076496cd-aa42-413a-a3c8-e8be0dd393af
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetCheck
Call this member function to set the check state for a tree control item.  
  
## Syntax  
  
```  
  
      BOOL SetCheck(  
   HTREEITEM hItem,  
   BOOL fCheck = TRUE   
);  
```  
  
#### Parameters  
 `hItem`  
 The **HTREEITEM** to receive the check state change.  
  
 `fCheck`  
 Indicates whether the tree control item is to be checked or unchecked. By default, `SetCheck` sets the item to be checked.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 When the tree control item is checked (`fCheck` set to **TRUE**), the item appears with an adjacent checkmark.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#29](../vs140/codesnippet/CPP/ctreectrl--setcheck_1.cpp)]  
  
## Example  
 To use checkboxes, set TVS_CHECKBOXES before populating the tree control.  
  
 [!code[NVC_MFC_CTreeCtrl#30](../vs140/codesnippet/CPP/ctreectrl--setcheck_2.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetCheck](../vs140/ctreectrl--getcheck.md)