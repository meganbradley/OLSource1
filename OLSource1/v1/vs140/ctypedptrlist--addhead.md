---
title: "CTypedPtrList::AddHead"
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
  - "CTypedPtrList.AddHead"
  - "CTypedPtrList::AddHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddHead method"
  - "CTypedPtrList class, operations"
ms.assetid: 03b5d612-71eb-4779-a62a-204fd74503dc
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrList::AddHead
This member function calls `BASE_CLASS`**::AddHead**.  
  
## Syntax  
  
```  
  
      POSITION AddHead(  
   TYPE newElement   
);  
void AddHead(  
   CTypedPtrList<BASE_CLASS,  
   TYPE> *pNewList   
);  
```  
  
#### Parameters  
 *TYPE*  
 Type of the elements stored in the base-class list.  
  
 `newElement`  
 The object pointer to be added to this list. A **NULL** value is allowed.  
  
 `BASE_CLASS`  
 Base class of the typed pointer list class; must be a pointer list class ([CObList](../vs140/coblist-class.md) or [CPtrList](../vs140/cptrlist-class.md)).  
  
 `pNewList`  
 A pointer to another [CTypedPtrList](../vs140/ctypedptrlist-class.md) object. The elements in `pNewList` will be added to this list.  
  
## Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
## Remarks  
 The first version adds a new element before the head of the list. The second version adds another list of elements before the head.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrList Class](../vs140/ctypedptrlist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)