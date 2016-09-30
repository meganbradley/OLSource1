---
title: "list::push_back"
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
  - "list/std::list::push_back"
  - "std::list::push_back"
  - "std.list.push_back"
  - "list.push_back"
  - "list::push_back"
  - "push_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push_back method"
ms.assetid: 50322b7d-a27c-4795-8dcc-89980745293f
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# list::push_back
Adds an element to the end of a list.  
  
## Syntax  
  
```  
  
      void push  
      _  
      back(  
  
void push_back(  
   Type&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The element added to the end of the list.|  
  
## Remarks  
 If an exception is thrown, the list is left unaltered and the exception is rethrown.  
  
## Example  
  
```  
// list_push_back.cpp  
// compile with: /EHsc  
#include <list>  
#include <iostream>  
#include <string>  
  
int main( )   
{  
   using namespace std;  
   list <int> c1;  
  
   c1.push_back( 1 );  
   if ( c1.size( ) != 0 )  
      cout << "Last element: " << c1.back( ) << endl;  
  
   c1.push_back( 2 );  
   if ( c1.size( ) != 0 )  
      cout << "New last element: " << c1.back( ) << endl;  
  
// move initialize a list of strings  
   list <string> c2;  
   string str("a");  
  
   c2.push_back( move( str ) );  
   cout << "Moved first element: " << c2.back( ) << endl;  
}  
```  
  
 **Last element: 1**  
**New last element: 2**  
**Moved first element: a**   
## Requirements  
 **Header:** \<list>  
  
 **Namespace:** std  
  
## See Also  
 [list Class](../vs140/list-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)