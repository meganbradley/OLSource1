---
title: "multimap::lower_bound"
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
  - "multimap::lower_bound"
  - "std.multimap.lower_bound"
  - "map/std::multimap::lower_bound"
  - "lower_bound"
  - "std::multimap::lower_bound"
  - "multimap.lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: a60a3bea-a891-47d6-8f15-3ea63ffaad1a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::lower_bound
Returns an iterator to the first element in a multimap that with a key that is equal to or greater than a specified key.  
  
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
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
## Return Value  
 An iterator or `const_iterator` that addresses the location of an element in a multimap that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the multimap if no match is found for the key.  
  
 If the return value of `lower_bound` is assigned to a `const_iterator`, the multimap object cannot be modified. If the return value of `lower_bound` is assigned to an **iterator**, the multimap object can be modified.  
  
## Example  
  
```  
// multimap_lower_bound.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1;  
   multimap <int, int> :: const_iterator m1_AcIter, m1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_RcIter = m1.lower_bound( 2 );  
   cout << "The element of multimap m1 with a key of 2 is: "  
        << m1_RcIter -> second << "." << endl;  
  
   m1_RcIter = m1.lower_bound( 3 );  
   cout << "The first element of multimap m1 with a key of 3 is: "  
        << m1_RcIter -> second << "." << endl;  
  
   // If no match is found for the key, end( ) is returned  
   m1_RcIter = m1.lower_bound( 4 );  
  
   if ( m1_RcIter == m1.end( ) )  
      cout << "The multimap m1 doesn't have an element "  
              << "with a key of 4." << endl;  
   else  
      cout << "The element of multimap m1 with a key of 4 is: "  
                << m1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the multimap can be  
   // found using a dereferenced iterator addressing the location  
   m1_AcIter = m1.end( );  
   m1_AcIter--;  
   m1_RcIter = m1.lower_bound( m1_AcIter -> first );  
   cout << "The first element of m1 with a key matching\n"  
        << "that of the last element is: "  
        << m1_RcIter -> second << "." << endl;  
  
   // Note that the first element with a key equal to  
   // the key of the last element is not the last element  
   if ( m1_RcIter == --m1.end( ) )  
      cout << "This is the last element of multimap m1."  
           << endl;  
   else  
      cout << "This is not the last element of multimap m1."  
           << endl;  
}  
```  
  
 **The element of multimap m1 with a key of 2 is: 20.**  
**The first element of multimap m1 with a key of 3 is: 20.**  
**The multimap m1 doesn't have an element with a key of 4.**  
**The first element of m1 with a key matching**  
**that of the last element is: 20.**  
**This is not the last element of multimap m1.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)