---
title: "multiset::difference_type"
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
  - "std.multiset.difference_type"
  - "std::multiset::difference_type"
  - "multiset::difference_type"
  - "set/std::multiset::difference_type"
  - "difference_type"
  - "multiset.difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 525d6b39-7ca0-40a9-80c0-da5942720eb1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::difference_type
A signed integer type that can be used to represent the number of elements of a multiset in a range between elements pointed to by iterators.  
  
## Syntax  
  
```  
typedef typename allocator_type::difference_type difference_type;  
```  
  
## Remarks  
 The `difference_type` is the type returned when subtracting or incrementing through iterators of the container. The `difference_type` is typically used to represent the number of elements in the range [`_First`, `_Last`) between the iterators `_First` and `_Last`, includes the element pointed to by `_First` and the range of elements up to, but not including, the element pointed to by `_Last`.  
  
 Note that although `difference_type` is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers like set, subtraction between iterators is only supported by random-access iterators provided by a random-access container like vector.  
  
## Example  
  
```  
// multiset_diff_type.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <set>  
#include <algorithm>  
  
int main( )  
{  
   using namespace std;  
  
   multiset <int> ms1;  
   multiset <int>::iterator ms1_Iter, ms1_bIter, ms1_eIter;  
  
   ms1.insert( 20 );  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
  
   ms1_bIter = ms1.begin( );  
   ms1_eIter = ms1.end( );  
  
   multiset <int>::difference_type   df_typ5, df_typ10, df_typ20;  
  
   df_typ5 = count( ms1_bIter, ms1_eIter, 5 );  
   df_typ10 = count( ms1_bIter, ms1_eIter, 10 );  
   df_typ20 = count( ms1_bIter, ms1_eIter, 20 );  
  
   // The keys, and hence the elements, of a multiset are not unique  
   cout << "The number '5' occurs " << df_typ5  
        << " times in multiset ms1.\n";  
   cout << "The number '10' occurs " << df_typ10  
        << " times in multiset ms1.\n";  
   cout << "The number '20' occurs " << df_typ20  
        << " times in multiset ms1.\n";  
  
   // Count the number of elements in a multiset   
   multiset <int>::difference_type  df_count = 0;  
   ms1_Iter = ms1.begin( );  
   while ( ms1_Iter != ms1_eIter)  
   {  
      df_count++;  
      ms1_Iter++;  
   }  
  
   cout << "The number of elements in the multiset ms1 is: "   
        << df_count << "." << endl;  
}  
```  
  
 **The number '5' occurs 0 times in multiset ms1.**  
**The number '10' occurs 1 times in multiset ms1.**  
**The number '20' occurs 2 times in multiset ms1.**  
**The number of elements in the multiset ms1 is: 3.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)