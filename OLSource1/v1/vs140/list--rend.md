---
title: "list::rend"
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
  - "list::rend"
  - "list.rend"
  - "std.list.rend"
  - "std::list::rend"
  - "list/std::list::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: c88ed87d-5e06-4bbf-99dd-096f74387bdc
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::rend
Returns an iterator that addresses the location that follows the last element in a reversed list.  
  
## Syntax  
  
```unstlib  
  
      const  
      _  
      reverse  
      _  
      iterator rend( ) const;  
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed list (the location that had preceded the first element in the unreversed list).  
  
## Remarks  
 `rend` is used with a reversed list just as [end](../vs140/list--end.md) is used with a list.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, the list object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, the list object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its list.  
  
 The value returned by `rend` should not be dereferenced.  
  
## Example  
  
```  
// list_rend.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
   list <int>::iterator c1_Iter;  
   list <int>::reverse_iterator c1_rIter;  
  
   // If the following line had replaced the line above, an error would   
   // have resulted in the line modifying an element (commented below)  
   // because the iterator would have been const  
   // list <int>::const_reverse_iterator c1_rIter;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   c1_rIter = c1.rend( );  
   c1_rIter --;  // Decrementing a reverse iterator moves it forward in   
                 // the list (to point to the first element here)  
   cout << "The first element in the list is: " << *c1_rIter << endl;  
  
   cout << "The list is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   // rend can be used to test if an iteration is through all of the   
   // elements of a reversed list  
   cout << "The reversed list is:";  
   for ( c1_rIter = c1.rbegin( ); c1_rIter != c1.rend( ); c1_rIter++ )  
      cout << " " << *c1_rIter;  
   cout << endl;  
  
   c1_rIter = c1.rend( );  
   c1_rIter--;  // Decrementing the reverse iterator moves it backward   
                // in the reversed list (to the last element here)  
  
   *c1_rIter = 40;  // This modification of the last element would have   
                    // caused an error if a const_reverse iterator had   
                    // been declared (as noted above)  
  
   cout << "The modified reversed list is:";  
   for ( c1_rIter = c1.rbegin( ); c1_rIter != c1.rend( ); c1_rIter++ )  
      cout << " " << *c1_rIter;  
   cout << endl;  
}  
```  
  
 **The first element in the list is: 10**  
**The list is: 10 20 30**  
**The reversed list is: 30 20 10**  
**The modified reversed list is: 30 20 40**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)