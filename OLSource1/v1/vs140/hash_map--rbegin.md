---
title: "hash_map::rbegin"
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
  - "std.hash_map.rbegin"
  - "hash_map::rbegin"
  - "hash_map.rbegin"
  - "hash_map/stdext::hash_map::rbegin"
  - "rbegin"
  - "std::hash_map::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 5f24cf2d-500f-4a09-bacc-34eb0133fbee
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::rbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_map or addressing what had been the last element in the unreversed hash_map.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed hash_map just as [begin](../vs140/hash_map--begin.md) is used with a hash_map.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a [const_reverse_iterator](../vs140/hash_map--const_reverse_iterator.md), then the hash_map object cannot be modified. If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a [reverse_iterator](../vs140/hash_map--reverse_iterator.md), then the hash_map object can be modified.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can be used to iterate through a hash_map backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of the reversed hash_map hm1 is 3.**  
**The hash_map is: 1 2 3 .**  
**The reversed hash_map is: 3 2 1 .**  
**After the erasure, the first element in the reversed hash_map is 2.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)