---
title: "list::reverse"
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
  - "list/std::list::reverse"
  - "std.list.reverse"
  - "reverse"
  - "list.reverse"
  - "std::list::reverse"
  - "list::reverse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse method"
ms.assetid: e5b78533-cc8f-42a8-b9ff-b74467b45276
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::reverse
Reverses the order in which the elements occur in a list.  
  
## Syntax  
  
```unstlib  
  
void reverse( );  
  
```  
  
## Example  
  
```  
// list_reverse.cpp  
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
  
   cout << "c1 =";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   c1.reverse( );  
   cout << "Reversed c1 =";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
}  
```  
  
 **c1 = 10 20 30**  
**Reversed c1 = 30 20 10**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)