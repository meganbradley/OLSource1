---
title: "hash_set::rend"
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
  - "std.hash_set.rend"
  - "rend"
  - "hash_set::rend"
  - "std::hash_set::rend"
  - "hash_set/stdext::hash_set::rend"
  - "hash_set.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 41c4bb2c-0401-4c33-a06d-d7025e748a52
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_set (the location that had preceded the first element in the unreversed hash_set).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed hash_set just as [end](../vs140/hash_set--end.md) is used with a hash_set.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then the hash_set object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then the hash_set object can be modified. The value returned by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> should not be dereferenced.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its hash_set.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element in the reversed hash_set is 10.**  
**The hash_set is: 10 20 30 .**  
**The reversed hash_set is: 30 20 10 .**  
**After the erasure, the last element in the reversed hash_set is 20.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)