---
title: "deque::pop_back"
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
  - "pop_back"
  - "deque/std::deque::pop_back"
  - "std.deque.pop_back"
  - "deque.pop_back"
  - "std::deque::pop_back"
  - "deque::pop_back"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop_back method, deque class"
  - "pop_back method"
ms.assetid: 2035fe7b-ac3d-4493-b8b3-56a1ec5e36e4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# deque::pop_back
Deletes the element at the end of the deque.  
  
## Syntax  
  
```  
  
void pop_back( );  
  
```  
  
## Remarks  
 The last element must not be empty. `pop_back` never throws an exception.  
  
## Example  
  
```  
// deque_pop_back.cpp  
// compile with: /EHsc  
#include <deque>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   deque <int> c1;  
  
   c1.push_back( 1 );  
   c1.push_back( 2 );  
   cout << "The first element is: " << c1.front( ) << endl;  
   cout << "The last element is: " << c1.back( ) << endl;  
  
   c1.pop_back( );  
   cout << "After deleting the element at the end of the deque, the "  
      "last element is: " << c1.back( ) << endl;  
}  
```  
  
 **The first element is: 1**  
**The last element is: 2**  
**After deleting the element at the end of the deque, the last element is: 1**   
## Requirements  
 **Header:** \<deque>  
  
 **Namespace:** std  
  
## See Also  
 [deque Class](../vs140/deque-class.md)   
 [deque::push_back and deque::pop_back](../vs140/deque--push_back-and-deque--pop_back.md)   
 [Standard Template Library](../vs140/standard-template-library.md)