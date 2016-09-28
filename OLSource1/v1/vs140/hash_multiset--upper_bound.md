---
title: "hash_multiset::upper_bound"
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
  - "hash_multiset.upper_bound"
  - "upper_bound"
  - "std.hash_multiset.upper_bound"
  - "hash_multiset::upper_bound"
  - "hash_set/stdext::hash_multiset::upper_bound"
  - "std::hash_multiset::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: ba437aed-6384-4009-a226-f723ca7f6463
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::upper_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator to the first element in a hash_multiset with a key that is greater than a specified key.  
  
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
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_multiset--iterator.md) or [const_iterator](../vs140/hash_multiset--const_iterator.md) that addresses the location of the first element in a hash_multiset with a key greater than the argument key, or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_upper_bound.cpp  
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
  
   hms1_RcIter = hms1.upper_bound( 20 );  
   cout << "The first element of hash_multiset hms1" << endl  
        << " with a key greater than 20 is: "  
        << *hms1_RcIter << "." << endl;  
  
   hms1_RcIter = hms1.upper_bound( 30 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( hms1_RcIter == hms1.end( ) )  
      cout << "The hash_multiset hms1 doesn't have an element "  
           << "\n with a key greater than 30." << endl;  
   else  
      cout << "The element of hash_multiset hms1"  
           << "with a key > 40 is: "  
           << *hms1_RcIter << "." << endl;  
  
   // An element at a specific location in the hash_multiset can be  
   // found by using a dereferenced iterator addressing the location  
   hms1_AcIter = hms1.begin( );  
   hms1_RcIter = hms1.upper_bound( *hms1_AcIter );  
   cout << "The first element of hms1\n with a key greater than "  
        << endl << "that of the initial element of hms1 is: "  
        << *hms1_RcIter << "." << endl;  
}  
```  
  
 **The first element of hash_multiset hms1**  
 **with a key greater than 20 is: 30.**  
**The hash_multiset hms1 doesn't have an element**   
 **with a key greater than 30.**  
**The first element of hms1**  
 **with a key greater than**   
**that of the initial element of hms1 is: 20.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)