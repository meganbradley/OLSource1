---
title: "CListBox::SelectString"
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
  - SelectString
  - CListBox.SelectString
  - CListBox::SelectString
dev_langs: 
  - C++
helpviewer_keywords: 
  - CListBox class, string operations
  - SelectString method
ms.assetid: ae03e135-fcc7-439f-b108-aacab6d82481
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::SelectString
Searches for a list-box item that matches the specified string, and if a matching item is found, it selects the item.  
  
## Syntax  
  
```  
  
      int SelectString(  
   int nStartAfter,  
   LPCTSTR lpszItem   
);  
```  
  
#### Parameters  
 `nStartAfter`  
 Contains the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by `nStartAfter`. If `nStartAfter` is –1, the entire list box is searched from the beginning.  
  
 `lpszItem`  
 Points to the null-terminated string that contains the prefix to search for. The search is case independent, so this string may contain any combination of uppercase and lowercase letters.  
  
## Return Value  
 The index of the selected item if the search was successful. If the search was unsuccessful, the return value is **LB_ERR** and the current selection is not changed.  
  
## Remarks  
 The list box is scrolled, if necessary, to bring the selected item into view.  
  
 This member function cannot be used with a list box that has the [LBS_MULTIPLESEL](../vs140/list-box-styles.md) style.  
  
 An item is selected only if its initial characters (from the starting point) match the characters in the string specified by `lpszItem`.  
  
 Use the `FindString` member function to find a string without selecting the item.  
  
## Example  
 [!code[NVC_MFC_CListBox#27](../vs140/codesnippet/CPP/clistbox--selectstring_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::FindString](../vs140/clistbox--findstring.md)   
 [LB_SELECTSTRING](http://msdn.microsoft.com/library/windows/desktop/bb761327)