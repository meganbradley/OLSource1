---
title: "CListBox::FindString"
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
  - CListBox::FindString
  - CListBox.FindString
dev_langs: 
  - C++
helpviewer_keywords: 
  - CListBox class, string operations
  - FindString method
ms.assetid: 8d9d2a00-e102-4097-8eed-dbe84dfe84ff
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::FindString
Finds the first string in a list box that contains the specified prefix without changing the list-box selection.  
  
## Syntax  
  
```  
  
      int FindString(  
   int nStartAfter,  
   LPCTSTR lpszItem   
) const;  
```  
  
#### Parameters  
 `nStartAfter`  
 Contains the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by `nStartAfter`. If `nStartAfter` is –1, the entire list box is searched from the beginning.  
  
 `lpszItem`  
 Points to the null-terminated string that contains the prefix to search for. The search is case independent, so this string may contain any combination of uppercase and lowercase letters.  
  
## Return Value  
 The zero-based index of the matching item, or **LB_ERR** if the search was unsuccessful.  
  
## Remarks  
 Use the [SelectString](../vs140/clistbox--selectstring.md) member function to both find and select a string.  
  
## Example  
 [!code[NVC_MFC_CListBox#10](../vs140/codesnippet/CPP/clistbox--findstring_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SelectString](../vs140/clistbox--selectstring.md)   
 [CListBox::AddString](../vs140/clistbox--addstring.md)   
 [CListBox::InsertString](../vs140/clistbox--insertstring.md)   
 [LB_FINDSTRING](http://msdn.microsoft.com/library/windows/desktop/bb775187)