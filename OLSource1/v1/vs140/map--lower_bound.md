---
title: "map::lower_bound"
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
  - "std.map.lower_bound"
  - "std::map::lower_bound"
  - "lower_bound"
  - "map.lower_bound"
  - "map/std::map::lower_bound"
  - "map::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: 8336b17c-36c2-4382-883b-3fb1db0f99a3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::lower_bound
Returns an iterator to the first element in a map with a key value that is equal to or greater than that of a specified key.  
  
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
 The argument key value to be compared with the sort key of an element from the map being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element in a map that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the map if no match is found for the key.  
  
 If the return value of `lower_bound` is assigned to a `const_iterator`, the map object cannot be modified. If the return value of `lower_bound` is assigned to an **iterator**, the map object can be modified.  
  
## Example  
  
```  
// map_lower_bound.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   map <int, int> m1;  
   map <int, int> :: const_iterator m1_AcIter, m1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_RcIter = m1.lower_bound( 2 );  
   cout << "The first element of map m1 with a key of 2 is: "  
        << m1_RcIter -> second << "." << endl;  
  
   // If no match is found for this key, end( ) is returned  
   m1_RcIter = m1. lower_bound ( 4 );  
  
   if ( m1_RcIter == m1.end( ) )  
      cout << "The map m1 doesn't have an element "  
           << "with a key of 4." << endl;  
   else  
      cout << "The element of map m1 with a key of 4 is: "  
           << m1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the map can be found   
   // using a dereferenced iterator addressing the location  
   m1_AcIter = m1.end( );  
   m1_AcIter--;  
   m1_RcIter = m1. lower_bound ( m1_AcIter -> first );  
   cout << "The element of m1 with a key matching "  
        << "that of the last element is: "  
        << m1_RcIter -> second << "." << endl;  
}  
```  
  
 **The first element of map m1 with a key of 2 is: 20.**  
**The map m1 doesn't have an element with a key of 4.**  
**The element of m1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)