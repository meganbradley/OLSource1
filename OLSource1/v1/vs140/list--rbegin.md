---
title: "list::rbegin"
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
  - "std::list::rbegin"
  - "list/std::list::rbegin"
  - "list.rbegin"
  - "rbegin"
  - "std.list.rbegin"
  - "list::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 4861d7f9-9bed-48f6-bfa1-4357a4f2f985
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::rbegin
Returns an iterator that addresses the first element in a reversed list.  
  
## Syntax  
  
```unstlib  
  
      const  
      _  
      reverse  
      _  
      iterator rbegin( ) const;  
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed list (or addressing what had been the last element in the unreversed list).  
  
## Remarks  
 `rbegin` is used with a reversed list just as [begin](../vs140/list--begin.md) is used with a list.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, the list object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, the list object can be modified.  
  
 `rbegin` can be used to iterate through a list backwards.  
  
## Example  
  
```  
// list_rbegin.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
   list <int>::iterator c1_Iter;  
   list <int>::reverse_iterator c1_rIter;  
  
   // If the following line replaced the line above, *c1_rIter = 40;  
   // (below) would be an error  
   //list <int>::const_reverse_iterator c1_rIter;  
  
   c1.push_back( 10 );  
   c1.push_back( 20 );  
   c1.push_back( 30 );  
   c1_rIter = c1.rbegin( );  
   cout << "The last element in the list is " << *c1_rIter << "." << endl;  
  
   cout << "The list is:";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   // rbegin can be used to start an iteration through a list in   
   // reverse order  
   cout << "The reversed list is:";  
   for ( c1_rIter = c1.rbegin( ); c1_rIter != c1.rend( ); c1_rIter++ )  
      cout << " " << *c1_rIter;  
   cout << endl;  
  
   c1_rIter = c1.rbegin( );  
   *c1_rIter = 40;  
   cout << "The last element in the list is now " << *c1_rIter << "." << endl;  
}  
```  
  
 **The last element in the list is 30.**  
**The list is: 10 20 30**  
**The reversed list is: 30 20 10**  
**The last element in the list is now 40.**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)