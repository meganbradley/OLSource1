---
title: "CListBox::InsertString"
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
  - "CListBox.InsertString"
  - "CListBox::InsertString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, string operations"
  - "InsertString method"
ms.assetid: e46c0f23-6fe3-40bc-8a1e-a422a03839fa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::InsertString
Inserts a string into the list box.  
  
## Syntax  
  
```  
  
      int InsertString(  
   int nIndex,  
   LPCTSTR lpszItem   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the position to insert the string. If this parameter is –1, the string is added to the end of the list.  
  
 `lpszItem`  
 Points to the null-terminated string that is to be inserted.  
  
## Return Value  
 The zero-based index of the position at which the string was inserted. The return value is **LB_ERR** if an error occurs; the return value is **LB_ERRSPACE** if insufficient space is available to store the new string.  
  
## Remarks  
 Unlike the [AddString](../vs140/clistbox--addstring.md) member function, `InsertString` does not cause a list with the [LBS_SORT](../vs140/list-box-styles.md) style to be sorted.  
  
## Example  
 [!code[NVC_MFC_CListBox#24](../vs140/codesnippet/CPP/clistbox--insertstring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::AddString](../vs140/clistbox--addstring.md)   
 [LB_INSERTSTRING](http://msdn.microsoft.com/library/windows/desktop/bb761321)