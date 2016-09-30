---
title: "CListBox::GetSelItems"
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
  - "CListBox.GetSelItems"
  - "CListBox::GetSelItems"
  - "GetSelItems"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelItems method"
  - "CListBox class, multiple-line operations"
ms.assetid: 4d7230fb-00c1-408c-9bc8-8dbb063c31c9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetSelItems
Fills a buffer with an array of integers that specifies the item numbers of selected items in a multiple-selection list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the maximum number of selected items whose item numbers are to be placed in the buffer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a pointer to a buffer large enough for the number of integers specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 The actual number of items placed in the buffer. If the list box is a single-selection list box, the return value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFC_CListBox#20](../vs140/codesnippet/CPP/clistbox--getselitems_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_GETSELITEMS](http://msdn.microsoft.com/library/windows/desktop/bb761311)   
 [CListBox::GetSelCount](../vs140/clistbox--getselcount.md)