---
title: "CList::InsertAfter"
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
  - "CList.InsertAfter"
  - "CList::InsertAfter"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CList class, insertion"
  - "InsertAfter method"
ms.assetid: f8484253-20ca-45ec-9c70-10390f29e218
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CList::InsertAfter
Adds an element to this list after the element at the specified position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *position*  
 A **POSITION** value returned by a previous <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or **Find** member function call.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Template parameter specifying the type of the list element.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The element to be added to this list.  
  
## Return Value  
 A **POSITION** value that can be used for iteration or list element retrieval.  
  
## Example  
 [!code[NVC_MFCCollections#48](../vs140/codesnippet/CPP/clist--insertafter_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CList Class](../vs140/clist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CList::Find](../vs140/clist--find.md)   
 [CList::InsertBefore](../vs140/clist--insertbefore.md)