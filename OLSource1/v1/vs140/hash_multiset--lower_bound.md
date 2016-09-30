---
title: "hash_multiset::lower_bound"
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
  - "std::hash_multiset::lower_bound"
  - "hash_set/stdext::hash_multiset::lower_bound"
  - "lower_bound"
  - "std.hash_multiset.lower_bound"
  - "hash_multiset.lower_bound"
  - "hash_multiset::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: 2b80e1be-03b4-4088-aa41-ae7f9d268448
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::lower_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator to the first element in a hash_multiset with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_multiset--iterator.md) or [const_iterator](../vs140/hash_multiset--const_iterator.md) that addresses the location of the first element in a hash_multiset with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)