---
title: "CListBox::AddString"
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
  - "CListBox::AddString"
  - "CListBox.AddString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, string operations"
  - "AddString method"
ms.assetid: 263e95d9-40cd-41ba-94ef-045b76019df2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::AddString
Adds a string to a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the null-terminated string that is to be added.  
  
## Return Value  
 The zero-based index to the string in the list box. The return value is **LB_ERR** if an error occurs; the return value is **LB_ERRSPACE** if insufficient space is available to store the new string.  
  
## Remarks  
 If the list box was not created with the [LBS_SORT](../vs140/list-box-styles.md) style, the string is added to the end of the list. Otherwise, the string is inserted into the list, and the list is sorted. If the list box was created with the **LBS_SORT** style but not the [LBS_HASSTRINGS](../vs140/list-box-styles.md) style, the framework sorts the list by one or more calls to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function.  
  
 Use [InsertString](../vs140/clistbox--insertstring.md) to insert a string into a specific location within the list box.  
  
## Example  
 [!code[NVC_MFC_CListBox#3](../vs140/codesnippet/CPP/clistbox--addstring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::InsertString](../vs140/clistbox--insertstring.md)   
 [CListBox::CompareItem](../vs140/clistbox--compareitem.md)   
 [LB_ADDSTRING](http://msdn.microsoft.com/library/windows/desktop/bb775181)