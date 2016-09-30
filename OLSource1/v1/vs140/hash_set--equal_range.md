---
title: "hash_set::equal_range"
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
  - "std::hash_set::equal_range"
  - "equal_range"
  - "hash_set/stdext::hash_set::equal_range"
  - "hash_set::equal_range"
  - "hash_set.equal_range"
  - "std.hash_set.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: ae6f1f55-2371-45a0-9ca6-a15e37cf738a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::equal_range
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash set with a key that is equal to a specified key and to the first element in the hash set with a key that is greater than the key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the hash_set being searched.  
  
## Return Value  
 A pair of iterators where the first is the [lower_bound](../vs140/set--lower_bound.md) of the key and the second is the [upper_bound](../vs140/set--upper_bound.md) of the key.  
  
 To access the first iterator of a pair pr returned by the member function, use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.**first**, and to dereference the lower bound iterator, use \*(<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.**first**). To access the second iterator of a pair <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> returned by the member function, use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.**second**, and to dereference the upper bound iterator, use \*(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**second**).  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The upper bound of the element with a key of 20 in the hash_set hs1 is: 30.**  
**The lower bound of the element with a key of 20 in the hash_set hs1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The hash_set hs1 doesn't have an element with a key greater than or equal to 40.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)