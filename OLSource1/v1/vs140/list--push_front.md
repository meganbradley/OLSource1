---
title: "list::push_front"
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
  - "std::list::push_front"
  - "std.list.push_front"
  - "list::push_front"
  - "push_front"
  - "list.push_front"
  - "list/std::list::push_front"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_front method"
ms.assetid: 33a0126c-3b7b-4e30-abbc-a4e79259ddb6
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# list::push_front
Adds an element to the beginning of a list.  
  
## Syntax  
  
```  
  
      void push  
      _  
      front(  
   const Type& _Val  
);  
void push_front(  
   Type&& _Val  
);   
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the beginning of the list.|  
  
## Remarks  
 If an exception is thrown, the list is left unaltered and the exception is rethrown.  
  
## Example  
  
```  
// list_push_front.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
  
   c1.push_front( 1 );  
   if ( c1.size( ) != 0 )  
      cout << "First element: " << c1.front( ) << endl;  
  
   c1.push_front( 2 );  
   if ( c1.size( ) != 0 )  
      cout << "New first element: " << c1.front( ) << endl;  
  
// move initialize a list of strings  
   list <string> c2;  
   string str("a");  
  
   c2.push_front( move( str ) );  
   cout << "Moved first element: " << c2.front( ) << endl;  
}  
```  
  
 **First element: 1**  
**New first element: 2**  
**Moved first element: a**   
## Requirements  
 **Header:** <list\>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)