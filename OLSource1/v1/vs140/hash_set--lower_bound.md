---
title: "hash_set::lower_bound"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - hash_set.lower_bound
  - hash_set::lower_bound
  - lower_bound
  - std.hash_set.lower_bound
  - std::hash_set::lower_bound
  - hash_set/stdext::hash_set::lower_bound
dev_langs: 
  - C++
helpviewer_keywords: 
  - lower_bound function
ms.assetid: a3dc2860-fd4c-492c-8aeb-8906b97218b5
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::lower_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator to the first element in a hash_set with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
```  
  
      const_iterator lower_bound(  
   const Key& _Key  
) const;  
iterator lower_bound(  
   const Key& _Key  
);  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the hash_set being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element in a hash_set that with a key that is equal to or greater than the argument key or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_lower_bound.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int> :: const_iterator hs1_AcIter, hs1_RcIter;  
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
   hs1.insert( 30 );  
  
   hs1_RcIter = hs1.lower_bound( 20 );  
   cout << "The element of hash_set hs1 with a key of 20 is: "  
        << *hs1_RcIter << "." << endl;  
  
   hs1_RcIter = hs1.lower_bound( 40 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( hs1_RcIter == hs1.end( ) )  
      cout << "The hash_set hs1 doesn't have an element "  
           << "with a key of 40." << endl;  
   else  
      cout << "The element of hash_set hs1 with a key of 40 is: "  
           << *hs1_RcIter << "." << endl;  
  
   // An element at a specific location in the hash_set can be found   
   // by using a dereferenced iterator that addresses the location  
   hs1_AcIter = hs1.end( );  
   hs1_AcIter--;  
   hs1_RcIter = hs1.lower_bound( *hs1_AcIter );  
   cout << "The element of hs1 with a key matching "  
        << "that of the last element is: "  
        << *hs1_RcIter << "." << endl;  
}  
```  
  
 **The element of hash_set hs1 with a key of 20 is: 20.**  
**The hash_set hs1 doesn't have an element with a key of 40.**  
**The element of hs1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)