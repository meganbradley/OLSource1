---
title: "CTreeCtrl::GetDropHilightItem"
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
  - CTreeCtrl.GetDropHilightItem
  - GetDropHilightItem
  - CTreeCtrl::GetDropHilightItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDropHilightItem method
ms.assetid: b7de948d-6a46-478e-89f5-3e4bc68b481f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::GetDropHilightItem
Call this function to retrieve the item that is the target of a drag-and-drop operation.  
  
## Syntax  
  
```  
  
HTREEITEM GetDropHilightItem( ) const;  
```  
  
## Return Value  
 The handle of the item dropped if successful; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#9](../vs140/codesnippet/CPP/ctreectrl--getdrophilightitem_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)