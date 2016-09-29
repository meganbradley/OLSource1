---
title: "multiset::equal_range"
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
  - "multiset::equal_range"
  - "multiset.equal_range"
  - "equal_range"
  - "std::multiset::equal_range"
  - "set/std::multiset::equal_range"
  - "std.multiset.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 95872d19-20d4-4707-b34c-d757e9b1dae5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::equal_range
Returns a pair of iterators respectively to the first element in a multiset with a key that is greater than a specified key and to the first element in the multiset with a key that is equal to or greater than the key.  
  
## Syntax  
  
```  
  
      pair <const_iterator, const_iterator>   
   equal_range (  
      const Key& _Key  
   ) const;  
  
pair <iterator, iterator>   
   equal_range (  
      const Key& _Key  
   );  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
## Return Value  
 A pair of iterators such that the first is the [lower_bound](../vs140/multiset--lower_bound.md) of the key and the second is the [upper_bound](../vs140/multiset--upper_bound.md) of the key.  
  
 To access the first iterator of a pair `pr` returned by the member function, use `pr`.**first**, and to dereference the lower bound iterator, use \*(`pr`.**first**). To access the second iterator of a pair `pr` returned by the member function, use `pr`.**second**, and to dereference the upper bound iterator, use \*(`pr`.**second**).  
  
## Example  
  
```  
// multiset_equal_range.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;      
   typedef multiset<int, less<int> > IntSet;  
   IntSet ms1;  
   multiset <int> :: const_iterator ms1_RcIter;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
   ms1.insert( 30 );  
  
   pair <IntSet::const_iterator, IntSet::const_iterator> p1, p2;  
   p1 = ms1.equal_range( 20 );  
  
   cout << "The upper bound of the element with "  
        << "a key of 20 in the multiset ms1 is: "  
        << *( p1.second ) << "." << endl;  
  
   cout << "The lower bound of the element with "  
        << "a key of 20 in the multiset ms1 is: "  
        << *( p1.first ) << "." << endl;  
  
   // Compare the upper_bound called directly   
   ms1_RcIter = ms1.upper_bound( 20 );  
   cout << "A direct call of upper_bound( 20 ) gives "  
        << *ms1_RcIter << "," << endl  
        << "matching the 2nd element of the pair"  
        << " returned by equal_range( 20 )." << endl;  
  
   p2 = ms1.equal_range( 40 );  
  
   // If no match is found for the key,  
   // both elements of the pair return end( )  
   if ( ( p2.first == ms1.end( ) ) && ( p2.second == ms1.end( ) ) )  
      cout << "The multiset ms1 doesn't have an element "  
              << "with a key less than 40." << endl;  
   else  
      cout << "The element of multiset ms1 with a key >= 40 is: "  
                << *( p1.first ) << "." << endl;  
}  
```  
  
 **The upper bound of the element with a key of 20 in the multiset ms1 is: 30.**  
**The lower bound of the element with a key of 20 in the multiset ms1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The multiset ms1 doesn't have an element with a key less than 40.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)