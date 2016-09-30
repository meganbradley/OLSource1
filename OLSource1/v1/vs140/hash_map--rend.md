---
title: "hash_map::rend"
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
  - "hash_map/stdext::hash_map::rend"
  - "hash_map::rend"
  - "hash_map.rend"
  - "std::hash_map::rend"
  - "std.hash_map.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 08c371bc-a9a0-4447-8454-b26bddaca071
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_map (the location that had preceded the first element in the unreversed hash_map).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed hash_map just as [end](../vs140/hash_map--end.md) is used with a hash_map.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a [const_reverse_iterator](../vs140/hash_map--const_reverse_iterator.md), then the hash_map object cannot be modified. If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a [reverse_iterator](../vs140/hash_map--reverse_iterator.md), then the hash_map object can be modified.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_map.  
  
 The value returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element of the reversed hash_map hm1 is 1.**  
**The hash_map is: 1 2 3 .**  
**The reversed hash_map is: 3 2 1 .**  
**After the erasure, the last element in the reversed hash_map is 2.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)