---
title: "hash_map::iterator"
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
  - "hash_map.iterator"
  - "iterator"
  - "std.hash_map.iterator"
  - "stdext.hash_map.iterator"
  - "std::hash_map::iterator"
  - "hash_map::iterator"
  - "stdext::hash_map::iterator"
  - "hash_map/stdext::hash_map::iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iterator method"
  - "iterator typedef"
ms.assetid: b8e9262d-d13b-40fa-8629-57e101a234ea
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::iterator
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 A type that provides a bidirectional iterator that can read or modify any element in a hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **iterator** defined by hash_map points to elements that are objects of [value_type](../vs140/hash_map--value_type.md), that is of type **pair\<const Key, Type>,** whose first member is the key to the element and whose second member is the mapped datum held by the element.  
  
 To dereference an **iterator** <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointing to an element in a multimap, use the **->** operator.  
  
 To access the value of the key for the element, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> -> **first**, which is equivalent to (\*<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).**first**. To access the value of the mapped datum for the element, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> -> **second**, which is equivalent to (\*<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).**second**.  
  
 A type **iterator** can be used to modify the value of an element.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See example for [begin](../vs140/hash_map--begin.md) for an example of how to declare and use the **iterator**.  
  
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)