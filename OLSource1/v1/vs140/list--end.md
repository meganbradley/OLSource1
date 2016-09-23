---
title: "list::end"
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
  - end
  - std.list.end
  - list.end
  - list::end
  - list/std::list::end
  - std::list::end
dev_langs: 
  - C++
helpviewer_keywords: 
  - end method
ms.assetid: 49414c45-de0c-4738-8dad-8363732a3c0e
caps.latest.revision: 17
translation.priority.mt: 
  - de-de
  - ja-jp
---
# list::end
Returns an iterator that addresses the location succeeding the last element in a list.  
  
## Syntax  
  
```  
  
      const  
      _  
      iterator end( ) const;  
iterator end( );  
```  
  
## Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a list. If the list is empty, then `list::end == list::begin`.  
  
## Remarks  
 **end** is used to test whether an iterator has reached the end of its list.  
  
## Example  
  
```  
// list_end.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
   list <int>::iterator c1_Iter;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
  
   c1_Iter = c1.end( );  
   c1_Iter--;  
   cout << "The last integer of c1 is " << *c1_Iter << endl;  
  
   c1_Iter--;  
   *c1_Iter = 400;  
   cout << "The new next-to-last integer of c1 is "  
        << *c1_Iter << endl;  
  
   // If a const iterator had been declared instead with the line:  
   // list <int>::const_iterator c1_Iter;  
   // an error would have resulted when inserting the 400  
  
   cout << "The list is now:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
}  
```  
  
 **The last integer of c1 is 30**  
**The new next-to-last integer of c1 is 400**  
**The list is now: 10 400 30**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)