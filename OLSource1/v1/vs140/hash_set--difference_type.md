---
title: "hash_set::difference_type"
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
  - hash_set.difference_type
  - stdext::hash_set::difference_type
  - std::hash_set::difference_type
  - std.hash_set.difference_type
  - stdext.hash_set.difference_type
  - difference_type
  - hash_set::difference_type
  - hash_set/stdext::hash_set::difference_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - difference_type typedef
ms.assetid: 7874d4dc-783a-49c8-8990-7a6e8f83481c
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::difference_type
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 A signed integer type that can be used to represent the number of elements of a hash_set in a range between elements pointed to by iterators.  
  
## Syntax  
  
```  
typedef list<typename Traits::value_type, typename Traits::allocator_type>::difference_type difference_type;  
```  
  
## Remarks  
 The `difference_type` is the type returned when subtracting or incrementing through iterators of the container. The `difference_type` is typically used to represent the number of elements in the range [`_First`, `_Last`) between the iterators `_First` and `_Last`, includes the element pointed to by `_First` and the range of elements up to, but not including, the element pointed to by `_Last`.  
  
 Note that although `difference_type` is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random-access iterators provided by a random access container, such as vector or deque.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_diff_type.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <hash_set>  
#include <algorithm>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   hash_set <int> hs1;  
   hash_set <int>::iterator hs1_Iter, hs1_bIter, hs1_eIter;  
  
   hs1.insert( 20 );  
   hs1.insert( 10 );  
   hs1.insert( 20 );   // Won't insert as hash_set elements are unique  
  
   hs1_bIter = hs1.begin( );  
   hs1_eIter = hs1.end( );  
  
   hash_set <int>::difference_type   df_typ5, df_typ10, df_typ20;  
  
   df_typ5 = count( hs1_bIter, hs1_eIter, 5 );  
   df_typ10 = count( hs1_bIter, hs1_eIter, 10 );  
   df_typ20 = count( hs1_bIter, hs1_eIter, 20 );  
  
   // The keys, and hence the elements, of a hash_set are unique,  
   // so there is at most one of a given value  
   cout << "The number '5' occurs " << df_typ5  
        << " times in hash_set hs1.\n";  
   cout << "The number '10' occurs " << df_typ10  
        << " times in hash_set hs1.\n";  
   cout << "The number '20' occurs " << df_typ20  
        << " times in hash_set hs1.\n";  
  
   // Count the number of elements in a hash_set  
   hash_set <int>::difference_type  df_count = 0;  
   hs1_Iter = hs1.begin( );  
   while ( hs1_Iter != hs1_eIter)  
   {  
      df_count++;  
      hs1_Iter++;  
   }  
  
   cout << "The number of elements in the hash_set hs1 is: "   
        << df_count << "." << endl;  
}  
```  
  
 **The number '5' occurs 0 times in hash_set hs1.**  
**The number '10' occurs 1 times in hash_set hs1.**  
**The number '20' occurs 1 times in hash_set hs1.**  
**The number of elements in the hash_set hs1 is: 2.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)