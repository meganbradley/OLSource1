---
title: "hash_multimap::equal_range"
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
  - "std::hash_multimap::equal_range"
  - "hash_multimap::equal_range"
  - "equal_range"
  - "hash_multimap.equal_range"
  - "std.hash_multimap.equal_range"
  - "hash_map/stdext::hash_multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 4202b728-3932-485b-8eab-cfa72d375332
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::equal_range
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash_multimap with a key that is greater than a specified key and to the first element in the hash_multimap with a key that is equal to or greater than the key.  
  
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
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
## Return Value  
 A pair of iterators such that the first is the [lower_bound](../vs140/hash_multimap--lower_bound.md) of the key and the second is the [upper_bound](../vs140/hash_multimap--upper_bound.md) of the key.  
  
 To access the first iterator of a pair `pr` returned by the member function, use `pr`.**first** and to dereference the lower bound iterator, use \*(`pr`.**first**). To access the second iterator of a pair `pr` returned by the member function, use `pr`.**second** and to dereference the upper bound iterator, use \*(`pr`.**second**).  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_equal_range.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   typedef hash_multimap <int, int> IntMMap;  
   IntMMap hm1;  
   hash_multimap <int, int> :: const_iterator hm1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   pair <IntMMap::const_iterator, IntMMap::const_iterator> p1, p2;  
   p1 = hm1.equal_range( 2 );  
  
   cout << "The lower bound of the element with "  
        << "a key of 2\n in the hash_multimap hm1 is: "  
        << p1.first -> second << "." << endl;  
  
   cout << "The upper bound of the element with "  
        << "a key of 2\n in the hash_multimap hm1 is: "  
        << p1.second -> second << "." << endl;  
  
   // Compare the upper_bound called directly   
   hm1_RcIter = hm1.upper_bound( 2 );  
  
   cout << "A direct call of upper_bound( 2 ) gives "  
        << hm1_RcIter -> second << "," << endl  
        << " matching the 2nd element of the pair"  
        << " returned by equal_range( 2 )." << endl;  
  
   p2 = hm1.equal_range( 4 );  
  
   // If no match is found for the key,  
   // both elements of the pair return end( )  
   if ( ( p2.first == hm1.end( ) ) && ( p2.second == hm1.end( ) ) )  
      cout << "The hash_multimap hm1 doesn't have an element "  
           << "with a key less than 4." << endl;  
   else  
      cout << "The element of hash_multimap hm1 with a key >= 40 is: "  
           << p1.first -> first << "." << endl;  
}  
```  
  
 **The lower bound of the element with a key of 2**  
 **in the hash_multimap hm1 is: 20.**  
**The upper bound of the element with a key of 2**  
 **in the hash_multimap hm1 is: 30.**  
**A direct call of upper_bound( 2 ) gives 30,**  
 **matching the 2nd element of the pair returned by equal_range( 2 ).**  
**The hash_multimap hm1 doesn't have an element with a key less than 4.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)