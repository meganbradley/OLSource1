---
title: "hash_multiset::find"
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
  - "hash_set/stdext::hash_multiset::find"
  - "hash_multiset::find"
  - "Find"
  - "std::hash_multiset::find"
  - "hash_multiset.find"
  - "std.hash_multiset.find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: 9d6a8d3d-ff26-4c63-b67b-894b2a07281d
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::find
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_multiset that has a key equivalent to a specified key.  
  
## Syntax  
  
```  
  
      iterator find(  
   const Key& _Key  
);  
const_iterator find(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be matched by the sort key of an element from the hash_multiset being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_multiset--iterator.md) or [const_iterator](../vs140/hash_multiset--const_iterator.md) that addresses the location of an element equivalent to a specified key or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that addresses an element in the hash_multiset whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less-than comparability relation.  
  
 If the return value of **find** is assigned to a `const_iterator`, the hash_multiset object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_multiset object can be modified.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_find.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
   hash_multiset <int> :: const_iterator hms1_AcIter, hms1_RcIter;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
   hms1.insert( 30 );  
  
   hms1_RcIter = hms1.find( 20 );  
   cout << "The element of hash_multiset hms1 with a key of 20 is: "  
        << *hms1_RcIter << "." << endl;  
  
   hms1_RcIter = hms1.find( 40 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( hms1_RcIter == hms1.end( ) )  
      cout << "The hash_multiset hms1 doesn't have an element "  
           << "with a key of 40." << endl;  
   else  
      cout << "The element of hash_multiset hms1 with a key of 40 is: "  
           << *hms1_RcIter << "." << endl;  
  
   // The element at a specific location in the hash_multiset can be found   
   // by using a dereferenced iterator addressing the location  
   hms1_AcIter = hms1.end( );  
   hms1_AcIter--;  
   hms1_RcIter = hms1.find( *hms1_AcIter );  
   cout << "The element of hms1 with a key matching "  
        << "that of the last element is: "  
        << *hms1_RcIter << "." << endl;  
}  
```  
  
 **The element of hash_multiset hms1 with a key of 20 is: 20.**  
**The hash_multiset hms1 doesn't have an element with a key of 40.**  
**The element of hms1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)