---
title: "hash_multimap::lower_bound"
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
  - std.hash_multimap.lower_bound
  - std::hash_multimap::lower_bound
  - lower_bound
  - hash_map/stdext::hash_multimap::lower_bound
  - hash_multimap.lower_bound
  - hash_multimap::lower_bound
dev_langs: 
  - C++
helpviewer_keywords: 
  - lower_bound function
ms.assetid: 7bd27ca7-7575-4026-9e1d-e4671b74930b
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_multimap::lower_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator to the first element in a hash_multimap with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
```  
  
      iterator lower_bound(  
   const Key& _Key  
);  
const_iterator lower_bound(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_multimap--iterator.md) or [const_iterator](../vs140/hash_multimap--const_iterator.md) that addresses the location of an element in a hash_multimap with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_multimap if no match is found for the key.  
  
 If the return value of `lower_bound` is assigned to a `const_iterator`, the hash_multimap object cannot be modified. If the return value of `lower_bound` is assigned to an **iterator**, the hash_multimap object can be modified.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_lower_bound.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
   hash_multimap <int, int> :: const_iterator hm1_AcIter,   
      hm1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_RcIter = hm1.lower_bound( 2 );  
   cout << "The element of hash_multimap hm1 with a key of 2 is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   hm1_RcIter = hm1.lower_bound( 3 );  
   cout << "The first element of hash_multimap hm1 with a key of 3 is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   // If no match is found for the key, end( ) is returned  
   hm1_RcIter = hm1.lower_bound( 4 );  
  
   if ( hm1_RcIter == hm1.end( ) )  
      cout << "The hash_multimap hm1 doesn't have an element "  
           << "with a key of 4." << endl;  
   else  
      cout << "The element of hash_multimap hm1 with a key of 4 is: "  
           << hm1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the hash_multimap can be  
   // found using a dereferenced iterator addressing the location  
   hm1_AcIter = hm1.end( );  
   hm1_AcIter--;  
   hm1_RcIter = hm1.lower_bound( hm1_AcIter -> first );  
   cout << "The first element of hm1 with a key matching"  
        << endl << " that of the last element is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   // Note that the first element with a key equal to  
   // the key of the last element is not the last element  
   if ( hm1_RcIter == --hm1.end( ) )  
      cout << "This is the last element of hash_multimap hm1."  
           << endl;  
   else  
      cout << "This is not the last element of hash_multimap hm1."  
           << endl;  
}  
```  
  
 **The element of hash_multimap hm1 with a key of 2 is: 20.**  
**The first element of hash_multimap hm1 with a key of 3 is: 20.**  
**The hash_multimap hm1 doesn't have an element with a key of 4.**  
**The first element of hm1 with a key matching**  
 **that of the last element is: 20.**  
**This is not the last element of hash_multimap hm1.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)