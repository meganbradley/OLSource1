---
title: "hash_multimap::crbegin"
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
  - "std.hash_multimap.crbegin"
  - "hash_multimap.crbegin"
  - "hash_multimap::crbegin"
  - "std::hash_multimap::crbegin"
  - "hash_map/stdext::hash_multimap::crbegin"
  - "crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method, hash_multimap class"
  - "crbegin method"
ms.assetid: a9ab949a-00f2-4259-ba98-11a963375a98
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_multimap](../vs140/hash_multimap-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed hash_multimap just as [begin](../vs140/hash_multimap--begin.md) is used with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of the reversed hash_multimap hm1 is 3.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)