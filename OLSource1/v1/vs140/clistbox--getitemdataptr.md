---
title: "CListBox::GetItemDataPtr"
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
  - "CListBox.GetItemDataPtr"
  - "CListBox::GetItemDataPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemDataPtr method"
  - "CListBox class, general operations"
ms.assetid: 5bfe3c55-e3c9-4dd4-81dd-647c8cc074e1
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetItemDataPtr
Retrieves the application-supplied 32-bit value associated with the specified list-box item as a pointer (**void\***).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box.  
  
## Return Value  
 Retrieves a pointer, or –1 if an error occurs.  
  
## Example  
 [!code[NVC_MFC_CListBox#16](../vs140/codesnippet/CPP/clistbox--getitemdataptr_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::AddString](../vs140/clistbox--addstring.md)   
 [CListBox::GetItemData](../vs140/clistbox--getitemdata.md)   
 [CListBox::InsertString](../vs140/clistbox--insertstring.md)   
 [CListBox::SetItemData](../vs140/clistbox--setitemdata.md)   
 [LB_GETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb775202)