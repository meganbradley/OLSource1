---
title: "hash_multimap::swap"
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
  - "hash_map/stdext::hash_multimap::swap"
  - "stdext.hash_multimap.swap"
  - "hash_multimap::swap"
  - "std.hash_multimap.swap"
  - "hash_multimap.swap"
  - "swap"
  - "std::hash_multimap::swap"
  - "stdext::hash_multimap::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 22b18178-49a7-4fb5-8f2a-220b21eafe32
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::swap
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Exchanges the elements of two hash_multimaps.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The hash_multimap providing the elements to be swapped or the hash_multimap whose elements are to be exchanged with those of the hash_multimap.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_multimaps whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original hash_multimap hm1 is: 10 20 30.**  
**After swapping with hm2, hash_multimap hm1 is: 100 200.**  
**After swapping with hm3, hash_multimap hm1 is: 300.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)