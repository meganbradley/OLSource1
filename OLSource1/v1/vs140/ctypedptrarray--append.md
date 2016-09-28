---
title: "CTypedPtrArray::Append"
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
  - "CTypedPtrArray.Append"
  - "CTypedPtrArray::Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTypedPtrArray class, operations"
  - "Append method"
ms.assetid: 34d04532-7d36-44a6-b7bd-1efd0ce2ef89
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTypedPtrArray::Append
This member function calls `BASE_CLASS`**::Append**.  
  
## Syntax  
  
```  
  
      INT_PTR Append(   
   const CTypedPtrArray< BASE_CLASS, TYPE >& src    
);  
```  
  
#### Parameters  
 `BASE_CLASS`  
 Base class of the typed pointer array class; must be an array class ([CObArray](../vs140/cobarray-class.md) or [CPtrArray](../vs140/cptrarray-class.md)).  
  
 *TYPE*  
 Type of the elements stored in the base-class array.  
  
 *src*  
 Source of the elements to be appended to an array.  
  
## Return Value  
 The index of the first appended element.  
  
## Remarks  
 For more detailed remarks, see [CObArray::Append](../vs140/cobarray--append.md).  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CTypedPtrArray Class](../vs140/ctypedptrarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)