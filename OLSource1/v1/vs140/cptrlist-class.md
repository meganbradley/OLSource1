---
title: "CPtrList Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPtrList
dev_langs: 
  - C++
helpviewer_keywords: 
  - lists, generic
  - CPtrList class
  - generic lists
ms.assetid: 4139a09c-4338-4f42-9eea-51336120b43c
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPtrList Class
Supports lists of void pointers.  
  
## Syntax  
  
```  
class CPtrList : public CObject  
```  
  
## Members  
 The member functions of `CPtrList` are similar to the member functions of class [CObList](../vs140/coblist-class.md). Because of this similarity, you can use the `CObList` reference documentation for member function specifics. Wherever you see a `CObject` pointer as a function parameter or return value, substitute a pointer to `void`.  
  
 `CObject*& CObList::GetHead() const;`  
  
 for example, translates to  
  
 `void*& CPtrList::GetHead() const;`  
  
## Remarks  
 `CPtrList` incorporates the `IMPLEMENT_DYNAMIC` macro to support run-time type access and dumping to a `CDumpContext` object. If you need a dump of individual pointer list elements, you must set the depth of the dump context to 1 or greater.  
  
 Pointer lists cannot be serialized.  
  
 When a `CPtrList` object is deleted, or when its elements are removed, only the pointers are removed, not the entities they reference.  
  
 For more information on using `CPtrList`, see the article [Collections](../vs140/collections.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 `CPtrList`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList](../vs140/coblist-class.md)