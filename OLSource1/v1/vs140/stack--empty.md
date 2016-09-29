---
title: "stack::empty"
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
  - "std.stack.empty"
  - "stack::empty"
  - "std::stack::empty"
  - "stack.empty"
  - "Empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: c6c79cba-4228-45e4-a88f-da478a987052
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stack::empty
Tests if a stack is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the stack is empty; **false** if the stack is nonempty.  
  
## Example  
  
```  
// stack_empty.cpp  
// compile with: /EHsc  
#include <stack>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   // Declares stacks with default deque base container  
   stack <int> s1, s2;  
  
   s1.push( 1 );  
  
   if ( s1.empty( ) )  
      cout << "The stack s1 is empty." << endl;  
   else  
      cout << "The stack s1 is not empty." << endl;  
  
   if ( s2.empty( ) )  
      cout << "The stack s2 is empty." << endl;  
   else  
      cout << "The stack s2 is not empty." << endl;  
}  
```  
  
 **The stack s1 is not empty.**  
**The stack s2 is empty.**   
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
## See Also  
 [stack Class](../vs140/stack-class.md)   
 [stack::top and stack::empty](../vs140/stack--top-and-stack--empty.md)   
 [Standard Template Library](../vs140/standard-template-library.md)