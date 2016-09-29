---
title: "set_new_handler"
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
  - "std::set_new_handler"
  - "new/std::set_new_handler"
  - "std.set_new_handler"
  - "set_new_handler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_new_handler function"
ms.assetid: d4f55f73-a0cb-4e40-b721-ce0758b4e25e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_new_handler
Installs a user function that is to be called when `operator new` fails in its attempt to allocate memory.  
  
## Syntax  
  
```  
  
      new_handler set_new_handler(  
   new_handler _Pnew  
) throw( );  
```  
  
#### Parameters  
 `_Pnew`  
 The new_handler to be installed.  
  
## Return Value  
 0 on the first call and the previous `new_handler` on subsequent calls.  
  
## Remarks  
 The function stores `_Pnew` in a static [new handler](../vs140/new_handler.md) pointer that it maintains, then returns the value previously stored in the pointer. The new handler is used by [operator new](../vs140/operator-new---new--.md)(**size_t**).  
  
## Example  
  
```  
// new_set_new_handler.cpp  
// compile with: /EHsc  
#include<new>  
#include<iostream>  
  
using namespace std;  
void __cdecl newhandler( )  
{  
   cout << "The new_handler is called:" << endl;  
   throw bad_alloc( );  
   return;  
}  
  
int main( )   
{  
   set_new_handler (newhandler);  
   try  
   {  
      while ( 1 )   
      {  
         new int[5000000];  
         cout << "Allocating 5000000 ints." << endl;  
      }  
   }  
   catch ( exception e )  
   {  
      cout << e.what( ) << endl;  
   }  
}  
```  
  
 **Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**Allocating 5000000 ints.**  
**The new_handler is called:**  
**bad allocation**   
## Requirements  
 **Header:** \<new>  
  
 **Namespace:** std