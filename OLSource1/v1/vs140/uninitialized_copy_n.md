---
title: "uninitialized_copy_n"
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
  - "std.uninitialized_copy_n"
  - "uninitialized_copy_n"
  - "memory/std::uninitialized_copy_n"
  - "std::uninitialized_copy_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "uninitialized_copy_n"
  - "uninitialized_copy_n function"
ms.assetid: 3d443d83-9cb7-47a6-a3a5-ec6c373a239e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# uninitialized_copy_n
Creates a copy of a specified number of elements from an input iterator. The copies are put in a forward iterator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An input iterator that refers to the object to copy.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A signed or unsigned integer type specifying the number of times to copy the object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator that refers to where the new copies go.  
  
## Return Value  
 A forward iterator that addresses the first position beyond the destination. If the source range was empty, the iterator addresses <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>*.*  
  
## Remarks  
 The template function effectively executes the following:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 unless the code throws an exception. In that case, all constructed objects are destroyed and the exception is rethrown.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [\<memory>](../vs140/-memory-.md)