---
title: "CListBox::GetItemData"
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
  - "CListBox.GetItemData"
  - "CListBox::GetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemData method"
  - "CListBox class, general operations"
ms.assetid: eeb2b4f3-f5f0-466b-8312-200592f17c9f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetItemData
Retrieves the application-supplied doubleword value associated with the specified list-box item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item in the list box.  
  
## Return Value  
 The 32-bit value associated with the item, or **LB_ERR** if an error occurs.  
  
## Remarks  
 The doubleword value was the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter of a [SetItemData](../vs140/clistbox--setitemdata.md) call.  
  
## Example  
 [!code[NVC_MFC_CListBox#15](../vs140/codesnippet/CPP/clistbox--getitemdata_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::AddString](../vs140/clistbox--addstring.md)   
 [CListBox::GetItemDataPtr](../vs140/clistbox--getitemdataptr.md)   
 [CListBox::SetItemDataPtr](../vs140/clistbox--setitemdataptr.md)   
 [CListBox::InsertString](../vs140/clistbox--insertstring.md)   
 [CListBox::SetItemData](../vs140/clistbox--setitemdata.md)   
 [LB_GETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb775202)