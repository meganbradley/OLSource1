---
title: "atomic_compare_exchange Function"
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
  - "amp/Concurrency::atomic_compare_exchange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atomic_compare_exchange function"
ms.assetid: 3349f83f-ff21-48ee-8c91-09207877e98c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic_compare_exchange Function
Atomically compares the value stored at a memory location specified in the first argument for equality with the value of the second specified argument, and if the values are the same, the value at the memory location is changed to that of the third specified argument.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The location from which one of the values to be compared is read, and to which the new value, if any, is to be stored.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The location from which the second value to be compared is read.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to be stored to the memory location specified in by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the operation is successful; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)