---
title: "multiset::lower_bound"
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
  - "set/std::multiset::lower_bound"
  - "multiset::lower_bound"
  - "lower_bound"
  - "std::multiset::lower_bound"
  - "multiset.lower_bound"
  - "std.multiset.lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: d48dabb8-dea3-4275-8957-eec465dd9fd4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::lower_bound
Returns an iterator to the first element in a multiset with a key that is equal to or greater than a specified key.  
  
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
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element in a multiset that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the multiset if no match is found for the key.  
  
## Example  
  
```  
// multiset_lower_bound.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multiset <int> ms1;  
   multiset <int> :: const_iterator ms1_AcIter, ms1_RcIter;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
   ms1.insert( 30 );  
  
   ms1_RcIter = ms1.lower_bound( 20 );  
   cout << "The element of multiset ms1 with a key of 20 is: "  
        << *ms1_RcIter << "." << endl;  
  
   ms1_RcIter = ms1.lower_bound( 40 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( ms1_RcIter == ms1.end( ) )  
      cout << "The multiset ms1 doesn't have an element "  
           << "with a key of 40." << endl;  
   else  
      cout << "The element of multiset ms1 with a key of 40 is: "  
           << *ms1_RcIter << "." << endl;  
  
   // The element at a specific location in the multiset can be   
   // found using a derefenced iterator addressing the location  
   ms1_AcIter = ms1.end( );  
   ms1_AcIter--;  
   ms1_RcIter = ms1.lower_bound( *ms1_AcIter );  
   cout << "The element of ms1 with a key matching "  
        << "that of the last element is: "  
        << *ms1_RcIter << "." << endl;  
}  
```  
  
 **The element of multiset ms1 with a key of 20 is: 20.**  
**The multiset ms1 doesn't have an element with a key of 40.**  
**The element of ms1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)