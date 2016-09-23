---
title: "multiset::rbegin"
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
  - std.multiset.rbegin
  - set/std::multiset::rbegin
  - rbegin
  - std::multiset::rbegin
  - multiset::rbegin
  - multiset.rbegin
dev_langs: 
  - C++
helpviewer_keywords: 
  - rbegin method
ms.assetid: 83d9cdbf-169d-4b73-b8a1-6acf30e84f0e
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::rbegin
Returns an iterator addressing the first element in a reversed multiset.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed multiset or addressing what had been the last element in the unreversed multiset.  
  
## Remarks  
 `rbegin` is used with a reversed multiset just as [rbegin](#vclrfmultisetrbegin) is used with a multiset.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, then the multiset object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, then the multiset object can be modified.  
  
 `rbegin` can be used to iterate through a multiset backwards.  
  
## Example  
  
```  
// multiset_rbegin.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multiset <int> ms1;  
   multiset <int>::iterator ms1_Iter;  
   multiset <int>::reverse_iterator ms1_rIter;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
   ms1.insert( 30 );  
  
   ms1_rIter = ms1.rbegin( );  
   cout << "The first element in the reversed multiset is "  
        << *ms1_rIter << "." << endl;  
  
   // begin can be used to start an interation   
   // throught a multiset in a forward order  
   cout << "The multiset is:";  
   for ( ms1_Iter = ms1.begin( ) ; ms1_Iter != ms1.end( ); ms1_Iter++ )  
      cout << " " << *ms1_Iter;  
   cout << endl;  
  
   // rbegin can be used to start an interation   
   // throught a multiset in a reverse order  
   cout << "The reversed multiset is:";  
   for ( ms1_rIter = ms1.rbegin( ) ; ms1_rIter != ms1.rend( ); ms1_rIter++ )  
      cout << " " << *ms1_rIter;  
   cout << endl;  
  
   // A multiset element can be erased by dereferencing to its key   
   ms1_rIter = ms1.rbegin( );  
   ms1.erase ( *ms1_rIter );  
  
   ms1_rIter = ms1.rbegin( );  
   cout << "After the erasure, the first element "  
        << "in the reversed multiset is "<< *ms1_rIter << "."   
        << endl;  
}  
```  
  
 **The first element in the reversed multiset is 30.**  
**The multiset is: 10 20 30**  
**The reversed multiset is: 30 20 10**  
**After the erasure, the first element in the reversed multiset is 20.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)