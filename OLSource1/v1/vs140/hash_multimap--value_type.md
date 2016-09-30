---
title: "hash_multimap::value_type"
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
  - "hash_multimap.value_type"
  - "hash_map/stdext::hash_multimap::value_type"
  - "hash_multimap::value_type"
  - "std::hash_multimap::value_type"
  - "std.hash_multimap.value_type"
  - "stdext::hash_multimap::value_type"
  - "stdext.hash_multimap.value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: b8d5643e-df6f-4c24-b857-36800ecdc257
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::value_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 A type that represents the type of object stored in a hash_multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is declared to be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> *\<***const** [key_type](../vs140/hash_multimap--key_type.md), [mapped_type](../vs140/hash_multimap--mapped_type.md)> and not <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> *<*<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>*,* <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>*>* because the keys of an associative container may not be changed using a nonconstant iterator or reference.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The key of first element in the hash_multimap is 1.**  
**The data value of first element in the hash_multimap is 10.**  
**The keys of the mapped elements are: 1 2.**  
**The values of the mapped elements are: 10 20.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)