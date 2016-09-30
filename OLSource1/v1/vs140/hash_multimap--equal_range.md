---
title: "hash_multimap::equal_range"
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
  - "std::hash_multimap::equal_range"
  - "hash_multimap::equal_range"
  - "equal_range"
  - "hash_multimap.equal_range"
  - "std.hash_multimap.equal_range"
  - "hash_map/stdext::hash_multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 4202b728-3932-485b-8eab-cfa72d375332
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::equal_range
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash_multimap with a key that is greater than a specified key and to the first element in the hash_multimap with a key that is equal to or greater than the key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
## Return Value  
 A pair of iterators such that the first is the [lower_bound](../vs140/hash_multimap--lower_bound.md) of the key and the second is the [upper_bound](../vs140/hash_multimap--upper_bound.md) of the key.  
  
 To access the first iterator of a pair <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.**first** and to dereference the lower bound iterator, use \*(<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.**first**). To access the second iterator of a pair <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**second** and to dereference the upper bound iterator, use \*(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.**second**).  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The lower bound of the element with a key of 2**  
 **in the hash_multimap hm1 is: 20.**  
**The upper bound of the element with a key of 2**  
 **in the hash_multimap hm1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The hash_multimap hm1 doesn't have an element with a key less than 4.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)