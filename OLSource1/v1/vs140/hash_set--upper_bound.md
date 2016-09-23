---
title: "hash_set::upper_bound"
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
  - hash_set.upper_bound
  - hash_set::upper_bound
  - std.hash_set.upper_bound
  - upper_bound
  - std::hash_set::upper_bound
  - hash_set/stdext::hash_set::upper_bound
dev_langs: 
  - C++
helpviewer_keywords: 
  - upper_bound method
ms.assetid: 355bd408-5748-49d9-a086-debd5e2f5897
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::upper_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator to the first element in a hash_set that with a key that is greater than a specified key.  
  
## Syntax  
  
```  
  
      const_iterator upper_bound(  
   const Key& _Key  
) const;  
iterator upper_bound(  
   const Key& _Key  
);  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the hash_set being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element in a hash_set that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_upper_bound.cpp  
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
  
   hs1_RcIter = hs1.upper_bound( 20 );  
   cout << "The first element of hash_set hs1 with a key greater "  
        << "than 20 is: " << *hs1_RcIter << "." << endl;  
  
   hs1_RcIter = hs1.upper_bound( 30 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( hs1_RcIter == hs1.end( ) )  
      cout << "The hash_set hs1 doesn't have an element "  
           << "with a key greater than 30." << endl;  
   else  
      cout << "The element of hash_set hs1 with a key > 40 is: "  
           << *hs1_RcIter << "." << endl;  
  
   // An element at a specific location in the hash_set can be found  
   // by using a dereferenced iterator addressing the location  
   hs1_AcIter = hs1.begin( );  
   hs1_RcIter = hs1.upper_bound( *hs1_AcIter );  
   cout << "The first element of hs1 with a key greater than "  
        << endl << "that of the initial element of hs1 is: "  
        << *hs1_RcIter << "." << endl;  
}  
```  
  
 **The first element of hash_set hs1 with a key greater than 20 is: 30.**  
**The hash_set hs1 doesn't have an element with a key greater than 30.**  
**The first element of hs1 with a key greater than**   
**that of the initial element of hs1 is: 20.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)