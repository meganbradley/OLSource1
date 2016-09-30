---
title: "concurrent_vector::grow_by Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "concurrent_vector/concurrency::concurrent_vector::grow_by"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "grow_by method"
ms.assetid: 3aef8f98-e5a8-40a6-8db8-91315f41dadc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::grow_by Method
Grows this concurrent vector by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> elements. This method is concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of elements to append to the object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to initialize the new elements with.  
  
## Return Value  
 An iterator to first item appended.  
  
## Remarks  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not specified, the new elements are default constructed.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)