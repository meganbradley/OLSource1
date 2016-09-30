---
title: "CTypedPtrList::AddTail"
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
  - "CTypedPtrList::AddTail"
  - "CTypedPtrList.AddTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTypedPtrList class, operations"
  - "AddTail method"
ms.assetid: 0289b7cf-ec7b-4b77-8123-5ed04d9d5467
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::AddTail
This member function calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>**::AddTail**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *TYPE*  
 Type of the elements stored in the base-class list.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object pointer to be added to this list. A **NULL** value is allowed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Base class of the typed pointer list class; must be a pointer list class ([CObList](../vs140/coblist-class.md) or [CPtrList](../vs140/cptrlist-class.md)).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to another [CTypedPtrList](../vs140/ctypedptrlist-class.md) object. The elements in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will be added to this list.  
  
## Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
## Remarks  
 The first version adds a new element after the tail of the list. The second version adds another list of elements after the tail of the list.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)