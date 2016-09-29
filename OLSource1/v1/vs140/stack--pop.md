---
title: "stack::pop"
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
  - "pop"
  - "std.stack.pop"
  - "std::stack::pop"
  - "stack::pop"
  - "stack.pop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pop method"
ms.assetid: 689ea260-392b-410e-8f84-b6fc83915ce0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::pop
Removes the element from the top of the stack.  
  
## Syntax  
  
```  
  
void pop( );  
  
```  
  
## Remarks  
 The stack must be nonempty to apply the member function. The top of the stack is the position occupied by the most recently added element and is the last element at the end of the container.  
  
## Example  
  
```  
// stack_pop.cpp  
// compile with: /EHsc  
#include <stack>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   stack <int> s1, s2;  
  
   s1.push( 10 );  
   s1.push( 20 );  
   s1.push( 30 );  
  
   stack <int>::size_type i;  
   i = s1.size( );  
   cout << "The stack length is " << i << "." << endl;  
  
   i = s1.top( );  
   cout << "The element at the top of the stack is "  
        << i << "." << endl;  
  
   s1.pop( );  
  
   i = s1.size( );  
   cout << "After a pop, the stack length is "   
        << i << "." << endl;  
  
   i = s1.top( );  
   cout << "After a pop, the element at the top of the stack is "  
        << i << "." << endl;  
}  
```  
  
 **The stack length is 3.**  
**The element at the top of the stack is 30.**  
**After a pop, the stack length is 2.**  
**After a pop, the element at the top of the stack is 20.**   
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
## See Also  
 [stack Class](../vs140/stack-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)