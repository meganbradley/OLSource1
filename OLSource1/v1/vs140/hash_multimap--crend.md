---
title: "hash_multimap::crend"
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
  - "hash_map/stdext::hash_multimap::crend"
  - "std.hash_multimap.crend"
  - "std::hash_multimap::crend"
  - "crend"
  - "hash_multimap.crend"
  - "hash_multimap::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method, hash_multimap class"
  - "crend method"
ms.assetid: a67c0c09-5903-4d7a-8161-c3035eaa270c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::crend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_multimap](../vs140/hash_multimap-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [end](../vs140/hash_multimap--end.md) is used with a hash_multimap.  
  
 With the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_multimap.  
  
 The value returned by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element of the reversed hash_multimap hm1 is 3.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)