---
title: "hash_multimap::begin"
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
  - "std.hash_multimap.begin"
  - "hash_multimap::begin"
  - "std::hash_multimap::begin"
  - "hash_map/stdext::hash_multimap::begin"
  - "hash_multimap.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: 7bd8ae66-9b95-4ec3-9593-1828d6b9c7c6
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::begin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator addressing the first element in the hash_multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bidirectional iterator addressing the first element in the hash_multimap or the location succeeding an empty hash_multimap.  
  
## Remarks  
 If the return value of **begin** is assigned to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the elements in the hash_multimap object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_multimap object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of hm1 is 0.**  
**The first element of hm1 is now 1.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)