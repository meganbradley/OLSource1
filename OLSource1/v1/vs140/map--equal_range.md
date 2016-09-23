---
title: "map::equal_range"
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
  - map.equal_range
  - equal_range
  - std.map.equal_range
  - map::equal_range
  - map/std::map::equal_range
  - std::map::equal_range
dev_langs: 
  - C++
helpviewer_keywords: 
  - equal_range method
ms.assetid: 815ef7ac-3b84-4ec1-8b35-1d9f99e854a0
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# map::equal_range
Returns a pair of iterators that represent the [lower_bound](../vs140/map--lower_bound.md) of the key and the [upper_bound](../vs140/map--upper_bound.md) of the key.  
  
## Syntax  
  
```  
  
      pair <const_iterator, const_iterator> equal_range (  
   const Key& _Key  
) const;  
pair <iterator, iterator> equal_range (  
   const Key& _Key  
);  
```  
  
#### Parameters  
 `_Key`  
 The argument key value to be compared with the sort key of an element from the map being searched.  
  
## Return Value  
 To access the first iterator of a pair `pr` returned by the member function, use `pr`.**first**, and to dereference the lower bound iterator, use \*(`pr`.**first**). To access the second iterator of a pair `pr` returned by the member function, use `pr`.**second**, and to dereference the upper bound iterator, use \*(`pr`.**second**).  
  
## Example  
  
```  
// map_equal_range.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;   
   typedef map <int, int, less<int> > IntMap;  
   IntMap m1;  
   map <int, int> :: const_iterator m1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   pair <IntMap::const_iterator, IntMap::const_iterator> p1, p2;  
   p1 = m1.equal_range( 2 );  
  
   cout << "The lower bound of the element with "  
        << "a key of 2 in the map m1 is: "  
        << p1.first -> second << "." << endl;  
  
   cout << "The upper bound of the element with "  
        << "a key of 2 in the map m1 is: "  
        << p1.second -> second << "." << endl;  
  
   // Compare the upper_bound called directly   
   m1_RcIter = m1.upper_bound( 2 );  
  
   cout << "A direct call of upper_bound( 2 ) gives "  
        << m1_RcIter -> second << "," << endl  
        << " matching the 2nd element of the pair"  
        << " returned by equal_range( 2 )." << endl;  
  
   p2 = m1.equal_range( 4 );  
  
   // If no match is found for the key,  
   // both elements of the pair return end( )  
   if ( ( p2.first == m1.end( ) ) && ( p2.second == m1.end( ) ) )  
      cout << "The map m1 doesn't have an element "  
           << "with a key less than 40." << endl;  
   else  
      cout << "The element of map m1 with a key >= 40 is: "  
           << p2.first -> first << "." << endl;  
}  
```  
  
 **The lower bound of the element with a key of 2 in the map m1 is: 20.**  
**The upper bound of the element with a key of 2 in the map m1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The map m1 doesn't have an element with a key less than 40.**   
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)