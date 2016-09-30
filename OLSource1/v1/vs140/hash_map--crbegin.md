---
title: "hash_map::crbegin"
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
  - "hash_map::crbegin"
  - "std.hash_map.crbegin"
  - "hash_map/stdext::hash_map::crbegin"
  - "hash_map.crbegin"
  - "std::hash_map::crbegin"
  - "crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method, hash_map class"
  - "crbegin method"
ms.assetid: 69ecb96b-8b3c-4360-aaed-da92363f9586
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_map](../vs140/hash_map-class.md) or addressing what had been the last element in the unreversed <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed hash_map just as [begin](../vs140/hash_map--begin.md) is used with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 With the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object cannot be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to iterate through a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of the reversed hash_map hm1 is 3.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)