---
title: "operator!= (&lt;stack&gt;)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::!=
  - !=
  - std::operator!=
  - std.operator!=
  - std.!=
  - operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - != operator
  - operator!=, stack objects
  - operator !=, stack objects
ms.assetid: 9a4624e4-9b9e-4b34-9464-f71c37df256d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator!= (&lt;stack&gt;)
Tests if the stack object on the left side of the operator is not equal to stack object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   const stack <Type, Container>& _Left,  
   const stack <Type, Container>& _Right,  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **stack**.  
  
 `_Right`  
 An object of type **stack**.  
  
## Return Value  
 **true** if the stacks or stacks are not equal; **false** if stacks or stacks are equal.  
  
## Remarks  
 The comparison between stacks objects is based on a pairwise comparison of their elements. Two stacks are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// stack_op_me.cpp  
// compile with: /EHsc  
#include <stack>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares stacks with vector base containers  
   stack <int, vector<int> > s1, s2, s3;  
  
   // The following would have cause an error because stacks with  
   // different base containers are not equality comparable  
   // stack <int, list<int> >  s3;  
  
   s1.push( 1 );  
   s2.push( 2 );  
   s3.push( 1 );  
  
   if ( s1 != s2 )  
      cout << "The stacks s1 and s2 are not equal." << endl;  
   else  
      cout << "The stacks s1 and s2 are equal." << endl;  
  
   if ( s1 != s3 )  
      cout << "The stacks s1 and s3 are not equal." << endl;  
   else  
      cout << "The stacks s1 and s3 are equal." << endl;  
}  
```  
  
 **The stacks s1 and s2 are not equal.**  
**The stacks s1 and s3 are equal.**   
## Requirements  
 **Header:** <stack\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)