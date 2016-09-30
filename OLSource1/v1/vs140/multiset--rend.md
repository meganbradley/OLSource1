---
title: "multiset::rend"
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
  - "rend"
  - "multiset::rend"
  - "set/std::multiset::rend"
  - "std::multiset::rend"
  - "multiset.rend"
  - "std.multiset.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 61fb207b-0251-4f0e-8d7a-1f9911714b7a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::rend
Returns an iterator that addresses the location succeeding the last element in a reversed multiset.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multiset (the location that had preceded the first element in the unreversed multiset).  
  
## Remarks  
 `rend` is used with a reversed multiset just as [end](../vs140/multiset--end.md) is used with a multiset.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, then the multiset object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, then the multiset object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its multiset.  
  
 The value returned by `rend` should not be dereferenced.  
  
## Example  
  
```  
// multiset_rend.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main() {  
   using namespace std;     
   multiset <int> ms1;  
   multiset <int>::iterator ms1_Iter;  
   multiset <int>::reverse_iterator ms1_rIter;  
   multiset <int>::const_reverse_iterator ms1_crIter;  
  
   ms1.insert( 10 );  
   ms1.insert( 20 );  
   ms1.insert( 30 );  
  
   ms1_rIter = ms1.rend( ) ;  
   ms1_rIter--;  
   cout << "The last element in the reversed multiset is "  
        << *ms1_rIter << "." << endl;  
  
   // end can be used to terminate an interation   
   // throught a multiset in a forward order  
   cout << "The multiset is: ";  
   for ( ms1_Iter = ms1.begin( ) ; ms1_Iter != ms1.end( ); ms1_Iter++ )  
      cout << *ms1_Iter << " ";  
   cout << "." << endl;  
  
   // rend can be used to terminate an interation   
   // throught a multiset in a reverse order  
   cout << "The reversed multiset is: ";  
   for ( ms1_rIter = ms1.rbegin( ) ; ms1_rIter != ms1.rend( ); ms1_rIter++ )  
      cout << *ms1_rIter << " ";  
   cout << "." << endl;  
  
   ms1_rIter = ms1.rend( );  
   ms1_rIter--;  
   ms1.erase ( *ms1_rIter );  
  
   ms1_rIter = ms1.rend( );  
   --ms1_rIter;  
   cout << "After the erasure, the last element in the "  
        << "reversed multiset is " << *ms1_rIter << "." << endl;  
}  
```  
  
## Output  
  
```  
The last element in the reversed multiset is 10.  
The multiset is: 10 20 30 .  
The reversed multiset is: 30 20 10 .  
After the erasure, the last element in the reversed multiset is 20.  
```  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)