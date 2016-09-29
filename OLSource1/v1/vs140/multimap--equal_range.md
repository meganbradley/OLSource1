---
title: "multimap::equal_range"
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
  - "multimap::equal_range"
  - "map/std::multimap::equal_range"
  - "multimap.equal_range"
  - "equal_range"
  - "std.multimap.equal_range"
  - "std::multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 8868e0e8-7b90-439a-98e2-4d4016303b3c
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# multimap::equal_range
Finds the range of elements where the key of the element matches a specified value.  
  
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
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
## Return Value  
 A pair of iterators such that the first is the [lower_bound](../vs140/multimap--lower_bound.md) of the key and the second is the [upper_bound](../vs140/multimap--upper_bound.md) of the key.  
  
 To access the first iterator of a pair `pr` returned by the member function, use `pr`.**first** and to dereference the lower bound iterator, use \*(`pr`.**first**). To access the second iterator of a pair `pr` returned by the member function, use `pr`.**second** and to dereference the upper bound iterator, use \*(`pr`.**second**).  
  
## Example  
  
```  
// multimap_equal_range.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   typedef multimap <int, int, less<int> > IntMMap;  
   IntMMap m1;  
   multimap <int, int> :: const_iterator m1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   pair <IntMMap::const_iterator, IntMMap::const_iterator> p1, p2;  
   p1 = m1.equal_range( 2 );  
  
   cout << "The lower bound of the element with "  
        << "a key of 2 in the multimap m1 is: "  
        << p1.first -> second << "." << endl;  
  
   cout << "The upper bound of the element with "  
        << "a key of 2 in the multimap m1 is: "  
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
      cout << "The multimap m1 doesn't have an element "  
           << "with a key less than 4." << endl;  
   else  
      cout << "The element of multimap m1 with a key >= 40 is: "  
           << p1.first -> first << "." << endl;  
}  
```  
  
 **The lower bound of the element with a key of 2 in the multimap m1 is: 20.**  
**The upper bound of the element with a key of 2 in the multimap m1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The multimap m1 doesn't have an element with a key less than 4.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)