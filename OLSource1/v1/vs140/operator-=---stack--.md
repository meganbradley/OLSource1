---
title: "operator&lt;= (&lt;stack&gt;)"
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
  - "std::<="
  - "std.operator<="
  - "operator<="
  - "std.<="
  - "std::operator<="
  - "<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "<= operator, with specific objects"
  - "operator <=, stack"
  - "<= operator"
  - "operator<=, stack"
ms.assetid: 83e33293-c955-467c-a820-843a8807dce2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (&lt;stack&gt;)
Tests if the stack object on the left side of the operator is less than or equal to the stack object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<=(  
   const stack <Type, Container>& _Left,  
   const stack <Type, Container>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **stack**.  
  
 `_Right`  
 An object of type **stack**.  
  
## Return Value  
 **true** if the stack on the left side of the operator is less than or equal to the stack on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// stack_op_le.cpp  
// compile with: /EHsc  
#include <stack>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares stacks with default deque base container  
   stack <int> s1, s2, s3;  
  
   s1.push( 5 );  
   s1.push( 10 );  
   s2.push( 1 );  
   s2.push( 2 );  
   s3.push( 5 );  
   s3.push( 10 );  
  
   if ( s1 <= s2 )  
      cout << "The stack s1 is less than or equal to "  
           << "the stack s2." << endl;  
   else  
      cout << "The stack s1 is greater than "  
           << "the stack s2." << endl;  
  
   if ( s1 <= s3 )  
      cout << "The stack s1 is less than or equal to "  
           << "the stack s3." << endl;  
   else  
      cout << "The stack s1 is greater than "  
           << "the stack s3." << endl;  
}  
```  
  
 **The stack s1 is greater than the stack s2.**  
**The stack s1 is less than or equal to the stack s3.**   
## Requirements  
 **Header:** \<stack>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)