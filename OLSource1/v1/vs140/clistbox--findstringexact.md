---
title: "CListBox::FindStringExact"
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
  - "CListBox::FindStringExact"
  - "CListBox.FindStringExact"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, string operations"
  - "FindStringExact method"
ms.assetid: a86d6f4b-67c4-41d5-81f9-4099e455ab5b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::FindStringExact
Finds the first list-box string that matches the string specified in `lpszFind`.  
  
## Syntax  
  
```  
  
      int FindStringExact(  
   int nIndexStart,  
   LPCTSTR lpszFind   
) const;  
```  
  
#### Parameters  
 `nIndexStart`  
 Specifies the zero-based index of the item before the first item to be searched. When the search reaches the bottom of the list box, it continues from the top of the list box back to the item specified by `nIndexStart`. If `nIndexStart` is –1, the entire list box is searched from the beginning.  
  
 `lpszFind`  
 Points to the null-terminated string to search for. This string can contain a complete filename, including the extension. The search is not case sensitive, so the string can contain any combination of uppercase and lowercase letters.  
  
## Return Value  
 The index of the matching item, or **LB_ERR** if the search was unsuccessful.  
  
## Remarks  
 If the list box was created with an owner-draw style but without the [LBS_HASSTRINGS](../vs140/list-box-styles.md) style, the `FindStringExact` member function attempts to match the doubleword value against the value of `lpszFind`.  
  
## Example  
 [!code[NVC_MFC_CListBox#11](../vs140/codesnippet/CPP/clistbox--findstringexact_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::FindString](../vs140/clistbox--findstring.md)   
 [LB_FINDSTRING](http://msdn.microsoft.com/library/windows/desktop/bb775187)   
 [LB_FINDSTRINGEXACT](http://msdn.microsoft.com/library/windows/desktop/bb775189)