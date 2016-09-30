---
title: "multiset::upper_bound"
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
  - "multiset::upper_bound"
  - "std::multiset::upper_bound"
  - "upper_bound"
  - "std.multiset.upper_bound"
  - "multiset.upper_bound"
  - "set/std::multiset::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: 091b1d52-5e26-4be1-9e1f-6165eaa945da
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::upper_bound
Returns an iterator to the first element in a multiset with a key that is greater than a specified key.  
  
## Syntax  
  
```  
  
      const_iterator upper_bound(  
   const Key& _Key  
) const;  
iterator upper_bound(  
   const Key& _Key  
);  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element in a multiset with a key that is greater than the argument key, or that addresses the location succeeding the last element in the multiset if no match is found for the key.  
  
## Example  
  
```  
// multiset_upper_bound.cpp  
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
  
   ms1_RcIter = ms1.upper_bound( 20 );  
   cout << "The first element of multiset ms1 with a key greater "  
           << "than 20 is: " << *ms1_RcIter << "." << endl;  
  
   ms1_RcIter = ms1.upper_bound( 30 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( ms1_RcIter == ms1.end( ) )  
      cout << "The multiset ms1 doesn't have an element "  
              << "with a key greater than 30." << endl;  
   else  
      cout << "The element of multiset ms1 with a key > 40 is: "  
           << *ms1_RcIter << "." << endl;  
  
   // The element at a specific location in the multiset can be   
   // found using a dereferenced iterator addressing the location  
   ms1_AcIter = ms1.begin( );  
   ms1_RcIter = ms1.upper_bound( *ms1_AcIter );  
   cout << "The first element of ms1 with a key greater than"  
        << endl << "that of the initial element of ms1 is: "  
        << *ms1_RcIter << "." << endl;  
}  
```  
  
 **The first element of multiset ms1 with a key greater than 20 is: 30.**  
**The multiset ms1 doesn't have an element with a key greater than 30.**  
**The first element of ms1 with a key greater than**  
**that of the initial element of ms1 is: 20.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)