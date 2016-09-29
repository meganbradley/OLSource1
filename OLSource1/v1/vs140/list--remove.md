---
title: "list::remove"
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
  - "std::list::remove"
  - "remove"
  - "std.list.remove"
  - "list/std::list::remove"
  - "list::remove"
  - "list.remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove method"
ms.assetid: a12297b0-ce4b-4138-9f26-a948e29eb4de
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::remove
Erases elements in a list that match a specified value.  
  
## Syntax  
  
```unstlib  
  
      void remove(  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_Val`  
 The value which, if held by an element, will result in that element's removal from the list.  
  
## Remarks  
 The order of the elements remaining is not affected.  
  
## Example  
  
```  
// list_remove.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
   list <int>::iterator c1_Iter, c2_Iter;  
  
   c1.push_back( 5 );  
   c1.push_back( 100 );  
   c1.push_back( 5 );  
   c1.push_back( 200 );  
   c1.push_back( 5 );  
   c1.push_back( 300 );  
  
   cout << "The initial list is c1 =";  
   for ( c1_Iter = c1.begin( ); c1_Iter != c1.end( ); c1_Iter++ )  
      cout << " " << *c1_Iter;  
   cout << endl;  
  
   list <int> c2 = c1;  
   c2.remove( 5 );  
   cout << "After removing elements with value 5, the list becomes c2 =";  
   for ( c2_Iter = c2.begin( ); c2_Iter != c2.end( ); c2_Iter++ )  
      cout << " " << *c2_Iter;  
   cout << endl;  
}  
```  
  
 **The initial list is c1 = 5 100 5 200 5 300**  
**After removing elements with value 5, the list becomes c2 = 100 200 300**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)