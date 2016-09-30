---
title: "hash_set::find"
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
  - "Find"
  - "hash_set::find"
  - "std::hash_set::find"
  - "hash_set/stdext::hash_set::find"
  - "std.hash_set.find"
  - "hash_set.find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: e9bfe931-b4e0-4369-9e7c-56628f92308a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::find
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_set that has a key equivalent to a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be matched by the sort key of an element from the hash_set being searched.  
  
## Return Value  
 An **iterator** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element equivalent to a specified key or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that addresses an element in the hash_set whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less-than comparability relation.  
  
 If the return value of **find** is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the hash_set object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_set object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The element of hash_set hs1 with a key of 20 is: 20.**  
**The hash_set hs1 doesn't have an element with a key of 40.**  
**The element of hs1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)