---
title: "set::rbegin"
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
  - "std::set::rbegin"
  - "set/std::set::rbegin"
  - "set::rbegin"
  - "std.set.rbegin"
  - "rbegin"
  - "set.rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: c741f387-ae1c-4aac-b7b5-fe227769b3aa
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::rbegin
Returns an iterator addressing the first element in a reversed set.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed set or addressing what had been the last element in the unreversed set.  
  
## Remarks  
 `rbegin` is used with a reversed set just as [begin](../vs140/set--begin.md) is used with a set.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, then the set object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, then the set object can be modified.  
  
 `rbegin` can be used to iterate through a set backwards.  
  
## Example  
  
```  
// set_rbegin.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   set <int> s1;  
   set <int>::iterator s1_Iter;  
   set <int>::reverse_iterator s1_rIter;  
  
   s1.insert( 10 );  
   s1.insert( 20 );  
   s1.insert( 30 );  
  
   s1_rIter = s1.rbegin( );  
   cout << "The first element in the reversed set is "  
        << *s1_rIter << "." << endl;  
  
   // begin can be used to start an iteration   
   // throught a set in a forward order  
   cout << "The set is:";  
   for ( s1_Iter = s1.begin( ) ; s1_Iter != s1.end( ); s1_Iter++ )  
      cout << " " << *s1_Iter;  
   cout << endl;  
  
   // rbegin can be used to start an iteration   
   // throught a set in a reverse order  
   cout << "The reversed set is:";  
   for ( s1_rIter = s1.rbegin( ) ; s1_rIter != s1.rend( ); s1_rIter++ )  
      cout << " " << *s1_rIter;  
   cout << endl;  
  
   // A set element can be erased by dereferencing to its key   
   s1_rIter = s1.rbegin( );  
   s1.erase ( *s1_rIter );  
  
   s1_rIter = s1.rbegin( );  
   cout << "After the erasure, the first element "  
        << "in the reversed set is "<< *s1_rIter << "." << endl;  
}  
```  
  
 **The first element in the reversed set is 30.**  
**The set is: 10 20 30**  
**The reversed set is: 30 20 10**  
**After the erasure, the first element in the reversed set is 20.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::rbegin and set::rend](../vs140/set--rbegin-and-set--rend.md)   
 [Standard Template Library](../vs140/standard-template-library.md)