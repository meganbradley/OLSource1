---
title: "hash_map::crend"
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
  - "hash_map/stdext::hash_map::crend"
  - "std::hash_map::crend"
  - "crend"
  - "hash_map.crend"
  - "std.hash_map.crend"
  - "hash_map::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method, hash_map class"
  - "crend method"
ms.assetid: d1f137b4-9174-4f94-a0f8-b27a93aaa293
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::crend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a reversed hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed [hash_map](../vs140/hash_map-class.md) (the location that had preceded the first element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> just as [end](../vs140/hash_map--end.md) is used with a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The value returned by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element of the reversed hash_map hm1 is 3.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)