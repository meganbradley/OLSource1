---
title: "CListBox::GetCount"
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
  - "CListBox::GetCount"
  - "CListBox.GetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCount method [MFC]"
  - "CListBox class, general operations"
ms.assetid: a18bb8da-e8f1-4c28-84b5-ff5d68f401a9
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetCount
Retrieves the number of items in a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of items in the list box, or **LB_ERR** if an error occurs.  
  
## Remarks  
 The returned count is one greater than the index value of the last item (the index is zero-based).  
  
## Example  
 [!code[NVC_MFC_CListBox#12](../vs140/codesnippet/CPP/clistbox--getcount_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_GETCOUNT](http://msdn.microsoft.com/library/windows/desktop/bb775195)