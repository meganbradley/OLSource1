---
title: "hash_map::difference_type"
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
  - "stdext.hash_map.difference_type"
  - "stdext::hash_map::difference_type"
  - "std::hash_map::difference_type"
  - "hash_map::difference_type"
  - "hash_map/stdext::hash_map::difference_type"
  - "hash_map.difference_type"
  - "difference_type"
  - "std.hash_map.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 1689bacd-b70d-4a17-81a4-494dbd986f90
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::difference_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A signed integer type that can be used to represent the number of elements of a hash_map in a range between elements pointed to by iterators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remark  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the type returned when subtracting or incrementing through iterators of the container. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is typically used to represent the number of elements in the range *[_First, _Last)* between the iterators *_First* and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, includes the element pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and the range of elements up to, but not including, the element pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Note that although <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random access container, such as vector.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in the hash_map hm1 is: 3.**  
**The keys of the mapped elements are: 1 2 3.**  
**The values of the mapped elements are: 10 20 20.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)