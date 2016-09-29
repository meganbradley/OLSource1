---
title: "stack::push"
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
  - "stack::push"
  - "push"
  - "std::stack::push"
  - "std.stack.push"
  - "stack.push"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "push method"
ms.assetid: 98cfb5f3-b016-4f99-b9e1-0932c9126195
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::push
Adds an element to the top end of the stack.  
  
## Syntax  
  
```  
  
      void push(  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_Val`  
 The element added to the top of the stack.  
  
## Remarks  
 The top of the stack is the position occupied by the most recently added element and is the last element at the end of the container.  
  
## Example  
  
```  
// stack_push.cpp  
// compile with: /EHsc  
#include <stack>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   stack <int> s1;  
  
   s1.push( 10 );  
   s1.push( 20 );  
   s1.push( 30 );  
  
   stack <int>::size_type i;  
   i = s1.size( );  
   cout << "The stack length is " << i << "." << endl;  
  
   i = s1.top( );  
   cout << "The element at the top of the stack is "  
        << i << "." << endl;  
}  
```  
  
 **The stack length is 3.**  
**The element at the top of the stack is 30.**   
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
## See Also  
 [stack Class](../vs140/stack-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)