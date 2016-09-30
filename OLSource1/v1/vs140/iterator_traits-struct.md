---
title: "iterator_traits Struct"
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
  - "std::iterator_traits"
  - "xutility/std::iterator_traits"
  - "iterator_traits"
  - "std.iterator_traits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator_traits struct"
  - "iterator_traits class"
ms.assetid: 8b92c2c5-f658-402f-8ca1-e7ae301b8514
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iterator_traits Struct
A template helper struct used to specify all the critical type definitions that an iterator should have.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The template struct defines the member types  
  
-   **iterator_category**: a synonym for **Iterator::iterator_category**.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>: a synonym for **Iterator::value_type**.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>: a synonym for **Iterator::difference_type**.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>: a synonym for **Iterator::difference_type.**  
  
-   **pointer**: a synonym for **Iterator::pointer**.  
  
-   **reference**: a synonym for **Iterator::reference**.  
  
 The partial specializations determine the critical types associated with an object pointer of type **Type \*** or const **Type \***.  
  
 In this implementation you can also use several template functions that do not make use of partial specialization:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 which determine several of the same types more indirectly. You use these functions as arguments on a function call. Their sole purpose is to supply a useful template class parameter to the called function.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)