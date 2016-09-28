---
title: "CListBox::SetTopIndex"
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
  - "CListBox.SetTopIndex"
  - "CListBox::SetTopIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTopIndex method"
  - "CListBox class, general operations"
ms.assetid: 0021668d-7454-4946-b8bc-8b69a7d9f8c7
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetTopIndex
Ensures that a particular list-box item is visible.  
  
## Syntax  
  
```  
  
      int SetTopIndex(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the list-box item.  
  
## Return Value  
 Zero if successful, or **LB_ERR** if an error occurs.  
  
## Remarks  
 The system scrolls the list box until either the item specified by `nIndex` appears at the top of the list box or the maximum scroll range has been reached.  
  
## Example  
 [!code[NVC_MFC_CListBox#40](../vs140/codesnippet/CPP/clistbox--settopindex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetTopIndex](../vs140/clistbox--gettopindex.md)   
 [LB_SETTOPINDEX](http://msdn.microsoft.com/library/windows/desktop/bb761356)