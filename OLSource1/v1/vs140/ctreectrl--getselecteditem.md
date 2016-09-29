---
title: "CTreeCtrl::GetSelectedItem"
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
  - "CTreeCtrl::GetSelectedItem"
  - "CTreeCtrl.GetSelectedItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelectedItem method"
ms.assetid: 9897be77-ca12-4420-95db-205297c117e3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetSelectedItem
Call this function to retrieve the currently selected item of the tree view control.  
  
## Syntax  
  
```  
  
HTREEITEM GetSelectedItem( ) const;  
```  
  
## Return Value  
 The handle of the selected item; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#24](../vs140/codesnippet/CPP/ctreectrl--getselecteditem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::Select](../vs140/ctreectrl--select.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)   
 [CTreeCtrl::GetDropHilightItem](../vs140/ctreectrl--getdrophilightitem.md)