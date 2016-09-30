---
title: "concurrent_vector::resize Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: 7338d31b-ee0b-46b7-a9f4-2c6c255f29e3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::resize Method
Changes the size of the concurrent vector to the requested size, deleting or adding elements as necessary. This method is not concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new size of the concurrent_vector.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value of new elements added to the vector if the new size is larger than the original size. If the value is omitted, the new objects are assigned the default value for their type.  
  
## Remarks  
 If the size of the container is less than the requested size, elements are added to the vector until it reaches the requested size. If the size of the container is larger than the requested size, the elements closest to the end of the container are deleted until the container reaches the size <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If the present size of the container is the same as the requested size, no action is taken.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not concurrency safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)