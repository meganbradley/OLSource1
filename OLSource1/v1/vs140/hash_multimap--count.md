---
title: "hash_multimap::count"
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
  - "hash_multimap.count"
  - "std::hash_multimap::count"
  - "hash_multimap::count"
  - "hash_map/stdext::hash_multimap::count"
  - "Count"
  - "std.hash_multimap.count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 80f06d15-31ce-4eae-b5b3-6c53170b9d95
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::count
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns the number of elements in a hash_multimap whose key matches a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the hash_multimap.  
  
## Return Value  
 1 if the hash_multimap contains an element whose sort key matches the parameter key; 0 if the hash_multimap doesn't contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements in the range  
  
 **[lower_bound (** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  **), upper_bound (** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  **) )**  
  
 which have a key value <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_multimap::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in hm1 with a sort key of 1 is: 2.**  
**The number of elements in hm1 with a sort key of 2 is: 2.**  
**The number of elements in hm1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)