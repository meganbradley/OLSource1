---
title: "CList::AddHead"
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
  - "CList.AddHead"
  - "AddHead"
  - "CList::AddHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddHead method"
  - "CList class, operations"
ms.assetid: 92b288d3-888c-4693-bc54-5ad72735e5f8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::AddHead
Adds a new element or list of elements to the head of this list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element (can be a reference).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new element.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to another <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> list. The elements in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will be added to this list.  
  
## Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
## Remarks  
 The list can be empty before the operation.  
  
## Example  
 [!code[NVC_MFCCollections#36](../vs140/codesnippet/CPP/clist--addhead_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::GetHead](../vs140/clist--gethead.md)   
 [CList::RemoveHead](../vs140/clist--removehead.md)