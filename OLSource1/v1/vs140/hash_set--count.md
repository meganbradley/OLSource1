---
title: "hash_set::count"
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
  - "std::hash_set::count"
  - "std.hash_set.count"
  - "hash_set.count"
  - "hash_set::count"
  - "count"
  - "hash_set/stdext::hash_set::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 93e487d7-1768-4800-a5ac-ea0f9efce744
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::count
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns the number of elements in a hash_set whose key matches a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the hash_set.  
  
## Return Value  
 1 if the hash_set contains an element whose sort key matches the parameter key.  
  
 0 if the hash_set does not contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements in the following range:  
  
 [**lower_bound** (_*Key* ), **upper_bound** (\_*Key* ) ).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_set::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in hs1 with a sort key of 1 is: 1.**  
**The number of elements in hs1 with a sort key of 2 is: 0.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)