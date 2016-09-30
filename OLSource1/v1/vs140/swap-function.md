---
title: "swap Function"
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
  - "concurrent_vector/concurrency::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: 1d6508df-4435-4acf-9fe6-eaa70c5dfd17
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap Function
Exchanges the elements of two <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The allocator type of the concurrent vectors.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The concurrent vector whose elements are to be exchanged with those of the concurrent vector <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The concurrent vector providing the elements to be swapped, or the vector whose elements are to be exchanged with those of the concurrent vector <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The template function is an algorithm specialized on the container class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to execute the member function <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.[concurrent_vector::swap](../vs140/concurrent_vector--swap-method.md)(<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>). These are instances of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 This method is not concurrency-safe. You must ensure that no other threads are performing operations on either of the concurrent vectors when you call this method.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)