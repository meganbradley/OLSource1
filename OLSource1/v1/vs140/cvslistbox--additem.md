---
title: "CVSListBox::AddItem"
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
  - "CVSListBox.AddItem"
  - "AddItem"
  - "CVSListBox::AddItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddItem method"
ms.assetid: 2a8ccaeb-9675-4950-8c4e-828c947de0cc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CVSListBox::AddItem
Adds a string to a list control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a string.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An application-specific 32-bit value that is associated with the string. The default value is 0.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The zero-based index of the position that will hold the string. If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is -1, the string is added to the end of the list. The default value is -1.  
  
## Return Value  
 The zero-based index of the position of the string in the list control.  
  
## Remarks  
 Use the [CVSListBox::GetItemData](../vs140/cvslistbox--getitemdata.md) method to retrieve the value that is specified by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter. This value can be an application-specific integer or a pointer to other data.  
  
## Requirements  
 **Header:** afxvslistbox.h  
  
## See Also  
 [CVSListBox Class](../vs140/cvslistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CVSListBox::GetItemData](../vs140/cvslistbox--getitemdata.md)