---
title: "CTreeCtrl::GetPrevSiblingItem"
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
  - "GetPrevSiblingItem"
  - "CTreeCtrl::GetPrevSiblingItem"
  - "CTreeCtrl.GetPrevSiblingItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPrevSiblingItem method"
ms.assetid: 60a15c4b-bc04-4c9b-9865-5e425097b3f9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetPrevSiblingItem
Call this function to retrieve the previous sibling of `hItem`.  
  
## Syntax  
  
```  
  
      HTREEITEM GetPrevSiblingItem(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 The handle of the previous sibling; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#22](../vs140/codesnippet/CPP/ctreectrl--getprevsiblingitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetNextSiblingItem](../vs140/ctreectrl--getnextsiblingitem.md)   
 [CTreeCtrl::GetParentItem](../vs140/ctreectrl--getparentitem.md)   
 [CTreeCtrl::GetChildItem](../vs140/ctreectrl--getchilditem.md)