---
title: "hash_set::swap"
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
  - "std.hash_set.swap"
  - "stdext::hash_set::swap"
  - "hash_set.swap"
  - "hash_set/stdext::hash_set::swap"
  - "stdext.hash_set.swap"
  - "std::hash_set::swap"
  - "swap"
  - "hash_set::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 35a37bbc-f98d-44fb-aa70-218f8cd381a5
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::swap
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Exchanges the elements of two hash_sets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument hash_set providing the elements to be swapped with the target hash_set.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_sets whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original hash_set hs1 is: 10 20 30.**  
**After swapping with hs2, list hs1 is: 200 100.**  
**After swapping with hs3, list hs1 is: 300.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)