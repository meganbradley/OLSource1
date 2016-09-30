---
title: "hash_set::key_compare"
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
  - "key_compare"
  - "hash_set/stdext::hash_set::key_compare"
  - "hash_set::key_compare"
  - "std::hash_set::key_compare"
  - "hash_set.key_compare"
  - "std.hash_set.key_compare"
  - "stdext::hash_set::key_compare"
  - "stdext.hash_set.key_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_compare method"
  - "key_compare typedef"
ms.assetid: af649b12-5dc8-4efe-aa08-130a7e8708d2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::key_compare
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A type that provides a function object that can compare two sort keys to determine the relative order of two elements in the hash_set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
 Note that both <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and [value_compare](../vs140/hash_set--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 See the example for [key_comp](../vs140/hash_set--key_comp.md) for an example of how to declare and use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)