---
title: "CListBox::SetAnchorIndex"
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
  - "CListBox::SetAnchorIndex"
  - "SetAnchorIndex"
  - "CListBox.SetAnchorIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAnchorIndex method"
ms.assetid: 76ef39d7-b5a6-4d9e-8951-54df4ab33200
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetAnchorIndex
Sets the anchor in a multiple-selection list box to begin an extended selection.  
  
## Syntax  
  
```  
  
      void SetAnchorIndex(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the list-box item that will be the anchor.  
  
## Remarks  
 In a multiple-selection list box, the anchor item is the first or last item in a block of contiguous selected items.  
  
## Example  
 [!code[NVC_MFC_CListBox#29](../vs140/codesnippet/CPP/clistbox--setanchorindex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetAnchorIndex](../vs140/clistbox--getanchorindex.md)