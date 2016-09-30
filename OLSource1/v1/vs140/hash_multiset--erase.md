---
title: "hash_multiset::erase"
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
  - "std.hash_multiset.erase"
  - "hash_multiset.erase"
  - "hash_multiset::erase"
  - "std::hash_multiset::erase"
  - "hash_set/stdext::hash_multiset::erase"
  - "Erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: 325dff3f-4e5d-4d07-87fa-290988c99945
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::erase
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Removes an element or a range of elements in a hash_multiset from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the element to be removed from the hash_multiset.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position of the first element removed from the hash_multiset.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Position just beyond the last element removed from the hash_multiset.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The key of the elements to be removed from the hash_multiset.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_multiset if no such element exists. For the third member function, the number of elements that have been removed from the hash_multiset.  
  
## Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_multiset::erase member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **After the 2nd element is deleted,**  
 **the hash_multiset hms1 is: 1 3 4.**  
**After the middle two elements are deleted,**  
 **the hash_multiset hms2 is: 16 4.**  
**After the element with a key of 2 is deleted,**  
 **the hash_multiset hms3 is: 0 1 3.**  
**The number of elements removed from hms3 is: 1.**  
**After another element with a key equal to that of the 2nd element**  
 **is deleted, the hash_multiset hms3 is: 0 3.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)