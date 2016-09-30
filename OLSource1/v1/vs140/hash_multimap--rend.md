---
title: "hash_multimap::rend"
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
  - "rend"
  - "hash_map/stdext::hash_multimap::rend"
  - "hash_multimap.rend"
  - "hash_multimap::rend"
  - "std.hash_multimap.rend"
  - "std::hash_multimap::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 57fae7e3-4d0b-4d2e-9043-fb36680576c7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_multimap (the location that had preceded the first element in the unreversed hash_multimap).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [end](../vs140/hash_multimap--end.md) is used with a hash_multimap.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a [const_reverse_iterator](../vs140/hash_multimap--const_reverse_iterator.md), then the hash_multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a [reverse_iterator](../vs140/hash_multimap--reverse_iterator.md), then the hash_multimap object can be modified.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_multimap.  
  
 The value returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element of the reversed hash_multimap hm1 is 1.**  
**The hash_multimap is: 1 2 3 .**  
**The reversed hash_multimap is: 3 2 1 .**  
**After the erasure, the last element in the reversed hash_multimap is 2.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)