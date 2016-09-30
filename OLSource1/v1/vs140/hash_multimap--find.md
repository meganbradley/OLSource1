---
title: "hash_multimap::find"
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
  - "find"
  - "hash_multimap.find"
  - "std.hash_multimap.find"
  - "hash_map/stdext::hash_multimap::find"
  - "std::hash_multimap::find"
  - "hash_multimap::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: c7dc9a3b-36de-4053-a54f-06db81e9e982
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::find
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator addressing the first location of an element in a hash_multimap that has a key equivalent to a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key to be matched by the sort key of an element from the hash_multimap being searched.  
  
## Return Value  
 An iterator that addresses the first location of an element with a specified key, or the location succeeding the last element in the hash_multimap if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that addresses an element in the hash_multimap whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the hash_multimap object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_multimap object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The element of hash_multimap hm1 with a key of 2 is: 20.**  
**The first element of hash_multimap hm1 with a key of 3 is: 20.**  
**The hash_multimap hm1 doesn't have an element with a key of 4.**  
**The first element of hm1 with a key matching**  
**that of the last element is: 20.**  
**This is not the last element of hash_multimap hm1.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)