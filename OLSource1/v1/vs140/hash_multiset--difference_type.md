---
title: "hash_multiset::difference_type"
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
  - "hash_multiset::difference_type"
  - "hash_set/stdext::hash_multiset::difference_type"
  - "std::hash_multiset::difference_type"
  - "difference_type"
  - "stdext.hash_multiset.difference_type"
  - "stdext::hash_multiset::difference_type"
  - "std.hash_multiset.difference_type"
  - "hash_multiset.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 2aa2e301-8e79-462d-b54f-1c1a5603838d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::difference_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 A signed integer type that provides the difference between two iterators that address elements within the same hash_multiset.  
  
## Syntax  
  
```  
typedef list<typename _Traits::value_type, typename _Traits::allocator_type>::difference_type difference_type;  
```  
  
## Remarks  
 The `difference_type` is the type returned when subtracting or incrementing through iterators of the container. The `difference_type` is typically used to represent the number of elements in the range [`_First`, `_Last`) between the iterators `_First` and `_Last`, includes the element pointed to by `_First` and the range of elements up to, but not including, the element pointed to by `_Last`.  
  
 Note that although `difference_type` is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set. Subtraction between iterators is only supported by random-access iterators provided by a random-access container such as vector or deque.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_diff_type.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <hash_set>  
#include <algorithm>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   hash_multiset <int> hms1;  
   hash_multiset <int>::iterator hms1_Iter, hms1_bIter, hms1_eIter;  
  
   hms1.insert( 20 );  
   hms1.insert( 10 );  
  
   // hash_multiset elements need not be unique  
   hms1.insert( 20 );  
  
   hms1_bIter = hms1.begin( );  
   hms1_eIter = hms1.end( );  
  
   hash_multiset <int>::difference_type   df_typ5, df_typ10,  
        df_typ20;  
  
   df_typ5 = count( hms1_bIter, hms1_eIter, 5 );  
   df_typ10 = count( hms1_bIter, hms1_eIter, 10 );  
   df_typ20 = count( hms1_bIter, hms1_eIter, 20 );  
  
   // The keys & hence the elements of a hash_multiset  
   // need not be unique and may occur multiple times  
   cout << "The number '5' occurs " << df_typ5  
        << " times in hash_multiset hms1.\n";  
   cout << "The number '10' occurs " << df_typ10  
        << " times in hash_multiset hms1.\n";  
   cout << "The number '20' occurs " << df_typ20  
        << " times in hash_multiset hms1.\n";  
  
   // Count the number of elements in a hash_multiset  
   hash_multiset <int>::difference_type  df_count = 0;  
   hms1_Iter = hms1.begin( );  
   while ( hms1_Iter != hms1_eIter)  
   {  
      df_count++;  
      hms1_Iter++;  
   }  
  
   cout << "The number of elements in the hash_multiset hms1 is "   
        << df_count << "." << endl;  
}  
```  
  
 **The number '5' occurs 0 times in hash_multiset hms1.**  
**The number '10' occurs 1 times in hash_multiset hms1.**  
**The number '20' occurs 2 times in hash_multiset hms1.**  
**The number of elements in the hash_multiset hms1 is 3.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)