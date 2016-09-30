---
title: "CTreeCtrl::SortChildren"
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
  - "SortChildren"
  - "CTreeCtrl.SortChildren"
  - "CTreeCtrl::SortChildren"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SortChildren method"
ms.assetid: 1f724529-8853-4691-988a-407222af158c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SortChildren
Call this function to alphabetically sort the child items of the given parent item in a tree view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle of the parent item whose child items are to be sorted. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is **NULL**, sorting will proceed from the root of the tree.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will not recurse through the tree; only the immediate children of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be sorted.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#37](../vs140/codesnippet/CPP/ctreectrl--sortchildren_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SortChildrenCB](../vs140/ctreectrl--sortchildrencb.md)