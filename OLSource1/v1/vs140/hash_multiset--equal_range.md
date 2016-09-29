---
title: "hash_multiset::equal_range"
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
  - "hash_multiset.equal_range"
  - "equal_range"
  - "std::hash_multiset::equal_range"
  - "hash_multiset::equal_range"
  - "hash_set/stdext::hash_multiset::equal_range"
  - "std.hash_multiset.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 2aaea00b-ab8f-413c-934c-81d8d2ff51ee
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::equal_range
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns a pair of iterators respectively to the first element in a hash_multiset with a key that is greater than a specified key and to the first element in the hash_multiset with a key that is equal to or greater than the key.  
  
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
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
## Return Value  
 A pair of iterators where the first is the [lower_bound](../vs140/hash_multiset--lower_bound.md) of the key and the second is the [upper_bound](../vs140/hash_multiset--upper_bound.md) of the key.  
  
 To access the first iterator of a pair `pr` returned by the member function, use `pr`.**first** and to dereference the lower bound iterator, use \*(`pr`.**first**). To access the second iterator of a pair `pr` returned by the member function, use `pr`.**second** and to dereference the upper bound iterator, use \*(`pr`.**second**).  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_equal_range.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   typedef hash_multiset<int> IntHSet;  
   IntHSet hms1;  
   hash_multiset <int> :: const_iterator hms1_RcIter;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
   hms1.insert( 30 );  
  
   pair <IntHSet::const_iterator, IntHSet::const_iterator> p1, p2;  
   p1 = hms1.equal_range( 20 );  
  
   cout << "The upper bound of the element with "  
        << "a key of 20\nin the hash_multiset hms1 is: "  
        << *(p1.second) << "." << endl;  
  
   cout << "The lower bound of the element with "  
        << "a key of 20\nin the hash_multiset hms1 is: "  
        << *(p1.first) << "." << endl;  
  
   // Compare the upper_bound called directly   
   hms1_RcIter = hms1.upper_bound( 20 );  
   cout << "A direct call of upper_bound( 20 ) gives "  
        << *hms1_RcIter << "," << endl  
        << "matching the 2nd element of the pair"  
        << " returned by equal_range( 20 )." << endl;  
  
   p2 = hms1.equal_range( 40 );  
  
   // If no match is found for the key,  
   // both elements of the pair return end( )  
   if ( ( p2.first == hms1.end( ) )   
      && ( p2.second == hms1.end( ) ) )  
      cout << "The hash_multiset hms1 doesn't have an element "  
           << "with a key less than 40." << endl;  
   else  
      cout << "The element of hash_multiset hms1"  
           << "with a key >= 40 is: "  
           << *(p1.first) << "." << endl;  
}  
```  
  
 **The upper bound of the element with a key of 20**  
**in the hash_multiset hms1 is: 30.**  
**The lower bound of the element with a key of 20**  
**in the hash_multiset hms1 is: 20.**  
**A direct call of upper_bound( 20 ) gives 30,**  
**matching the 2nd element of the pair returned by equal_range( 20 ).**  
**The hash_multiset hms1 doesn't have an element with a key less than 40.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)