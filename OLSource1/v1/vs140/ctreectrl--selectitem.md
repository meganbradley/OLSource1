---
title: "CTreeCtrl::SelectItem"
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
  - "CTreeCtrl::SelectItem"
  - "CTreeCtrl.SelectItem"
  - "SelectItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectItem method"
ms.assetid: 7b803d14-cbfd-46c9-9767-9c59a00da6ef
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SelectItem
Call this function to select the given tree view item.  
  
## Syntax  
  
```  
  
      BOOL SelectItem(  
   HTREEITEM hItem   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If `hItem` is **NULL**, then this function selects no item.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#26](../vs140/codesnippet/CPP/ctreectrl--selectitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::Select](../vs140/ctreectrl--select.md)   
 [CTreeCtrl::GetSelectedItem](../vs140/ctreectrl--getselecteditem.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)