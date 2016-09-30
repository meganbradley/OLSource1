---
title: "hash_set::erase"
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
  - "std.hash_set.erase"
  - "erase"
  - "hash_set::erase"
  - "std::hash_set::erase"
  - "hash_set.erase"
  - "hash_set/stdext::hash_set::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: a576f2fe-a8cc-4cf3-9121-b212523bca90
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::erase
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Removes an element or a range of elements in a hash_set from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the element to be removed from the hash_set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the first element removed from the hash_set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the hash_set.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The key of the elements to be removed from the hash_set.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_set if no such element exists. For the third member function, the number of elements that have been removed from the hash_set.  
  
## Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_set::erase member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **After the 2nd element is deleted, the hash_set hs1 is: 1 3 4.**  
**After the middle two elements are deleted, the hash_set hs2 is: 16 4.**  
**After the element with a key of 2 is deleted, the hash_set hs3 is: 0 1 3.**  
**The number of elements removed from hs3 is: 1.**  
**After another element (unique for hash_set) with a key**   
**equal to that of the 2nd element is deleted, the hash_set hs3 is: 0 3.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)