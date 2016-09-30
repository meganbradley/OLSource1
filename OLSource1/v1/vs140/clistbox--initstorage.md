---
title: "CListBox::InitStorage"
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
  - "CListBox::InitStorage"
  - "CListBox.InitStorage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitStorage method"
  - "CListBox class, initialization"
ms.assetid: be3a3faa-bf8e-45af-b609-92b9f0bbedec
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::InitStorage
Allocates memory for storing list-box items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of items to add.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the amount of memory, in bytes, to allocate for item strings.  
  
## Return Value  
 If successful, the maximum number of items that the list box can store before a memory reallocation is needed, otherwise **LB_ERRSPACE**, meaning not enough memory is available.  
  
## Remarks  
 Call this function before adding a large number of items to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 This function helps speed up the initialization of list boxes that have a large number of items (more than 100). It preallocates the specified amount of memory so that subsequent [AddString](../vs140/clistbox--addstring.md), [InsertString](../vs140/clistbox--insertstring.md), and [Dir](../vs140/clistbox--dir.md) functions take the shortest possible time. You can use estimates for the parameters. If you overestimate, some extra memory is allocated; if you underestimate, the normal allocation is used for items that exceed the preallocated amount.  
  
 Windows 95/98 only: The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is limited to 16-bit values. This means list boxes cannot contain more than 32,767 items. Although the number of items is restricted, the total size of the items in a list box is limited only by available memory.  
  
## Example  
 [!code[NVC_MFC_CListBox#23](../vs140/codesnippet/CPP/clistbox--initstorage_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::CListBox](../vs140/clistbox--clistbox.md)   
 [CListBox::Create](../vs140/clistbox--create.md)   
 [CListBox::ResetContent](../vs140/clistbox--resetcontent.md)   
 [LB_INITSTORAGE](http://msdn.microsoft.com/library/windows/desktop/bb761319)