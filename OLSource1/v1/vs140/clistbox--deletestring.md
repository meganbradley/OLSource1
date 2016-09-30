---
title: "CListBox::DeleteString"
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
  - "CListBox.DeleteString"
  - "CListBox::DeleteString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, string operations"
  - "DeleteString method"
ms.assetid: 905c25c0-3e44-4d98-b77f-cfbc5fa067a4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::DeleteString
Deletes the item in position <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> from the list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the string to be deleted.  
  
## Return Value  
 A count of the strings remaining in the list. The return value is **LB_ERR** if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies an index greater than the number of items in the list.  
  
## Remarks  
 All items following <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> now move down one position. For example, if a list box contains two items, deleting the first item will cause the remaining item to now be in the first position. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>=0 for the item in the first position.  
  
## Example  
 [!code[NVC_MFC_CListBox#7](../vs140/codesnippet/CPP/clistbox--deletestring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_DELETESTRING](http://msdn.microsoft.com/library/windows/desktop/bb775183)   
 [CListBox::AddString](../vs140/clistbox--addstring.md)   
 [CListBox::InsertString](../vs140/clistbox--insertstring.md)