---
title: "CListBox::SetItemData"
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
  - "CListBox.SetItemData"
  - "CListBox::SetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemData method"
  - "CListBox class, general operations"
ms.assetid: 10ca5434-ebb6-4c1c-9371-6f4ef07671ff
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetItemData
Sets a 32-bit value associated with the specified item in a list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the item.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the value to be associated with the item.  
  
## Return Value  
 **LB_ERR** if an error occurs.  
  
## Example  
 [!code[NVC_MFC_CListBox#34](../vs140/codesnippet/CPP/clistbox--setitemdata_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetItemDataPtr](../vs140/clistbox--setitemdataptr.md)   
 [CListBox::GetItemData](../vs140/clistbox--getitemdata.md)   
 [LB_SETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb761346)