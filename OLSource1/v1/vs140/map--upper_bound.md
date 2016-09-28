---
title: "map::upper_bound"
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
  - "map.upper_bound"
  - "map/std::map::upper_bound"
  - "upper_bound"
  - "std.map.upper_bound"
  - "std::map::upper_bound"
  - "map::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: 26418d42-e8ae-4c1b-b6d0-3309aa841e3f
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::upper_bound
Returns an iterator to the first element in a map that with a key having a value that is greater than that of a specified key.  
  
## Syntax  
  
```  
  
      iterator upper_bound(  
   const Key& _Key  
);  
const_iterator upper_bound(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The argument key value to be compared with the sort key value of an element from the map being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element in a map that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the map if no match is found for the key.  
  
 If the return value is assigned to a `const_iterator`, the map object cannot be modified. If the return value is assigned to a **iterator**, the map object can be modified.  
  
## Example  
  
```  
// map_upper_bound.cpp  
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
  
   m1_RcIter = m1.upper_bound( 2 );  
   cout << "The first element of map m1 with a key "  
        << "greater than 2 is: "  
        << m1_RcIter -> second << "." << endl;  
  
   // If no match is found for the key, end is returned  
   m1_RcIter = m1. upper_bound ( 4 );  
  
   if ( m1_RcIter == m1.end( ) )  
      cout << "The map m1 doesn't have an element "  
           << "with a key greater than 4." << endl;  
   else  
      cout << "The element of map m1 with a key > 4 is: "  
           << m1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the map can be found   
   // using a dereferenced iterator addressing the location  
   m1_AcIter = m1.begin( );  
   m1_RcIter = m1. upper_bound ( m1_AcIter -> first );  
   cout << "The 1st element of m1 with a key greater than\n"  
        << "that of the initial element of m1 is: "  
        << m1_RcIter -> second << "." << endl;  
}  
```  
  
 **The first element of map m1 with a key greater than 2 is: 30.**  
**The map m1 doesn't have an element with a key greater than 4.**  
**The 1st element of m1 with a key greater than**  
**that of the initial element of m1 is: 20.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)