---
title: "map::difference_type"
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
  - "std.map.difference_type"
  - "map/std::map::difference_type"
  - "map.difference_type"
  - "difference_type"
  - "std::map::difference_type"
  - "map::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: 96e65c8f-07c3-4277-bc98-b234d16ad8e4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::difference_type
A signed integer type that can be used to represent the number of elements of a map in a range between elements pointed to by iterators.  
  
## Syntax  
  
```  
typedef allocator_type::difference_type difference_type;  
```  
  
## Remarks  
 The `difference_type` is the type returned when subtracting or incrementing through iterators of the container. The `difference_type` is typically used to represent the number of elements in the range *[_First, _Last)* between the iterators `_First` and `_Last`, includes the element pointed to by `_First` and the range of elements up to, but not including, the element pointed to by `_Last`.  
  
 Note that although `difference_type` is available for all iterators that satisfy the requirements of an input iterator, which includes the class of bidirectional iterators supported by reversible containers such as set, subtraction between iterators is only supported by random access iterators provided by a random access container such as vector.  
  
## Example  
  
```  
// map_diff_type.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <map>  
#include <algorithm>  
  
int main( )  
{  
   using namespace std;  
   map <int, int> m1;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 3, 20 ) );  
   m1.insert ( Int_Pair ( 2, 30 ) );  
  
   map <int, int>::iterator m1_Iter, m1_bIter, m1_eIter;  
   m1_bIter = m1.begin( );  
   m1_eIter = m1.end( );  
  
   // Count the number of elements in a map  
   map <int, int>::difference_type  df_count = 1;  
   m1_Iter = m1.begin( );  
   while ( m1_Iter != m1_eIter)  
   {  
      df_count++;  
      m1_Iter++;  
   }  
  
   cout << "The number of elements in the map m1 is: "   
        << df_count << "." << endl;  
}  
```  
  
 **The number of elements in the map m1 is: 4.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)