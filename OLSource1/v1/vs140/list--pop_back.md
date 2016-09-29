---
title: "list::pop_back"
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
  - "list.pop_back"
  - "pop_back"
  - "std.list.pop_back"
  - "list/std::list::pop_back"
  - "list::pop_back"
  - "std::list::pop_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop_back method, list class"
ms.assetid: 441a4b8a-68e6-4b46-a112-fab7e8a56efd
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::pop_back
Deletes the element at the end of a list.  
  
## Syntax  
  
```unstlib  
  
void pop  
_  
back( );  
  
```  
  
## Remarks  
 The last element must not be empty. `pop_back` never throws an exception.  
  
## Example  
  
```  
// list_pop_back.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
  
   c1.push_back( 1 );  
   c1.push_back( 2 );  
   cout << "The first element is: " << c1.front( ) << endl;  
   cout << "The last element is: " << c1.back( ) << endl;  
  
   c1.pop_back( );  
   cout << "After deleting the element at the end of the list, "  
           "the last element is: " << c1.back( ) << endl;  
}  
```  
  
 **The first element is: 1**  
**The last element is: 2**  
**After deleting the element at the end of the list, the last element is: 1**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)