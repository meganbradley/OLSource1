---
title: "hash_map::begin"
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
  - "hash_map::begin"
  - "hash_map.begin"
  - "hash_map/stdext::hash_map::begin"
  - "std::hash_map::begin"
  - "std.hash_map.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: fae0f381-a028-46e6-962e-9894b181364b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::begin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the first element in the hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bidirectional iterator addressing the first element in the hash_map or the location succeeding an empty hash_map.  
  
## Remark  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the elements in the hash_map object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_map object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of hm1 is 0.**  
**The first element of hm1 is now 1.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)