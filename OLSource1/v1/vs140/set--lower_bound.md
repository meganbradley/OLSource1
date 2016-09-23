---
title: "set::lower_bound"
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
  - std::set::lower_bound
  - set::lower_bound
  - lower_bound
  - set.lower_bound
  - std.set.lower_bound
  - set/std::set::lower_bound
dev_langs: 
  - C++
helpviewer_keywords: 
  - lower_bound function
ms.assetid: 82f714f6-0fad-468c-a018-f8b15352edc4
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# set::lower_bound
Returns an iterator to the first element in a set with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
```  
  
      const_iterator lower_bound(  
   const Key& _Key  
) const;  
iterator lower_bound(  
   const Key& _Key  
);  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the set being searched.  
  
## Return Value  
 An iterator or `const_iterator` that addresses the location of an element in a set that with a key that is equal to or greater than the argument key or that addresses the location succeeding the last element in the set if no match is found for the key.  
  
## Example  
  
```  
// set_lower_bound.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1;  
   set <int> :: const_iterator s1_AcIter, s1_RcIter;  
  
   s1.insert( 10 );  
   s1.insert( 20 );  
   s1.insert( 30 );  
  
   s1_RcIter = s1.lower_bound( 20 );  
   cout << "The element of set s1 with a key of 20 is: "  
        << *s1_RcIter << "." << endl;  
  
   s1_RcIter = s1.lower_bound( 40 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( s1_RcIter == s1.end( ) )  
      cout << "The set s1 doesn't have an element "  
           << "with a key of 40." << endl;  
   else  
      cout << "The element of set s1 with a key of 40 is: "  
           << *s1_RcIter << "." << endl;  
  
   // The element at a specific location in the set can be found   
   // by using a dereferenced iterator that addresses the location  
   s1_AcIter = s1.end( );  
   s1_AcIter--;  
   s1_RcIter = s1.lower_bound( *s1_AcIter );  
   cout << "The element of s1 with a key matching "  
        << "that of the last element is: "  
        << *s1_RcIter << "." << endl;  
}  
```  
  
 **The element of set s1 with a key of 20 is: 20.**  
**The set s1 doesn't have an element with a key of 40.**  
**The element of s1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::lower_bound, set::upper_bound, and set::equal_range](../vs140/set--lower_bound--set--upper_bound--and-set--equal_range.md)   
 [Standard Template Library](../vs140/standard-template-library.md)