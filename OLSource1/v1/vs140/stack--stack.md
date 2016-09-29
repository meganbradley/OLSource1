---
title: "stack::stack"
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
  - "stack::stack"
  - "std.stack.stack"
  - "std::stack::stack"
  - "stack"
  - "stack.stack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stack class, constructor"
  - "stack method"
  - "stack, stack method"
ms.assetid: 464567dd-7fbb-430a-b692-87dde40328d0
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::stack
Constructs a stack that is empty or that is a copy of a base container class.  
  
## Syntax  
  
```  
  
      stack( );   
explicit stack(  
   const container_type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The container of which the constructed stack is to be a copy.  
  
## Example  
  
```  
// stack_stack.cpp  
// compile with: /EHsc  
#include <stack>  
#include <vector>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares stack with default deque base container  
   stack <char> dsc1;  
  
   //Explicitly declares a stack with deque base container  
   stack <char, deque<char> > dsc2;  
  
   // Declares a stack with vector base containers  
   stack <int, vector<int> > vsi1;  
  
   // Declares a stack with list base container  
   stack <int, list<int> > lsi;  
  
   // The second member function copies elements from a container  
   vector<int> v1;  
   v1.push_back( 1 );  
   stack <int, vector<int> > vsi2( v1 );  
   cout << "The element at the top of stack vsi2 is "  
        << vsi2.top( ) << "." << endl;  
}  
```  
  
 **The element at the top of stack vsi2 is 1.**   
## Requirements  
 **Header:** <stack\>  
  
 **Namespace:** std  
  
## See Also  
 [stack Class](../vs140/stack-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)