---
title: "hash_multiset::count"
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
  - "hash_set/stdext::hash_multiset::count"
  - "std::hash_multiset::count"
  - "hash_multiset::count"
  - "std.hash_multiset.count"
  - "count"
  - "hash_multiset.count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 0bb4d4df-33e2-44a4-a76a-0e376791f88b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::count
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns the number of elements in a hash_multiset whose key matches a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key of the elements to be matched from the hash_multiset.  
  
## Return Value  
 The number of elements in the hash_multiset with the parameter-specified key.  
  
## Remarks  
 The member function returns the number of elements in the following range:  
  
 [<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (_<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> ), <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (\_<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> ) ).  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_multiset::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in hms1 with a sort key of 1 is: 2.**  
**The number of elements in hms1 with a sort key of 2 is: 0.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)