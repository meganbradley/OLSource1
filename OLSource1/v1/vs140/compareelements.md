---
title: "CompareElements"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CompareElements
  - AFXTEMPL/CompareElements
dev_langs: 
  - C++
helpviewer_keywords: 
  - CompareElements function
ms.assetid: 3329d822-84a4-49b2-ba82-d4e3c6005e49
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CompareElements
Called directly by [CList::Find](../vs140/clist--find.md) and indirectly by [CMap::Lookup](../vs140/cmap--lookup.md) and [CMap::operator &#91;&#93;](../vs140/cmap--operator.md).  
  
## Syntax  
  
```  
  
      template<class TYPE, class ARG_TYPE>   
BOOL AFXAPI CompareElements(  
   const TYPE* pElement1,  
   const ARG_TYPE* pElement2   
);  
```  
  
#### Parameters  
 *TYPE*  
 The type of the first element to be compared.  
  
 `pElement1`  
 Pointer to the first element to be compared.  
  
 `ARG_TYPE`  
 The type of the second element to be compared.  
  
 `pElement2`  
 Pointer to the second element to be compared.  
  
## Return Value  
 Nonzero if the object pointed to by `pElement1` is equal to the object pointed to by `pElement2`; otherwise 0.  
  
## Remarks  
 The `CMap` calls use the `CMap` template parameters *KEY* and `ARG_KEY`.  
  
 The default implementation returns the result of the comparison of *\*pElement1* and *\*pElement2*. Override this function so that it compares the elements in a way that is appropriate for your application.  
  
 The C++ language defines the comparison operator (`==`) for simple types (`char`, `int`, **float**, and so on) but does not define a comparison operator for classes and structures. If you want to use `CompareElements` or to instantiate one of the collection classes that uses it, you must either define the comparison operator or overload `CompareElements` with a version that returns appropriate values.  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CList Class](../vs140/clist-class.md)   
 [CMap Class](../vs140/cmap-class.md)