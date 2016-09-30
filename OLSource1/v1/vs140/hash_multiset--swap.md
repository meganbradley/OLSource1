---
title: "hash_multiset::swap"
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
  - "stdext.hash_multiset.swap"
  - "std.hash_multiset.swap"
  - "hash_multiset.swap"
  - "hash_set/stdext::hash_multiset::swap"
  - "hash_multiset::swap"
  - "swap"
  - "std::hash_multiset::swap"
  - "stdext::hash_multiset::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 28f3c5f0-7260-4383-a032-3c8e8a22944d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::swap
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Exchanges the elements of two hash_multisets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument hash_multiset providing the elements to be swapped with the target hash_multiset.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_multisets whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original hash_multiset hms1 is: 10 20 30.**  
**After swapping with hms2, list hms1 is: 200 100.**  
**After swapping with hms3, list hms1 is: 300.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)