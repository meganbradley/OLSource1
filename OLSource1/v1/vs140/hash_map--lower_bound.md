---
title: "hash_map::lower_bound"
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
  - "hash_map/stdext::hash_map::lower_bound"
  - "lower_bound"
  - "hash_map.lower_bound"
  - "std.hash_map.lower_bound"
  - "hash_map::lower_bound"
  - "std::hash_map::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: 1161c745-7e93-4d5f-9da8-124e124d1710
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::lower_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator to the first element in a hash_map with a key value that is equal to or greater than that of a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key of an element from the hash_map being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_map--iterator.md) or [const_iterator](../vs140/hash_map--const_iterator.md) that addresses the location of an element in a hash_map that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_map if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the hash_map object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a **iterator**, the hash_map object can be modified.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of hash_map hm1 with a key of 2 is: 20.**  
**The hash_map hm1 doesn't have an element with a key of 4.**  
**The element of hm1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)