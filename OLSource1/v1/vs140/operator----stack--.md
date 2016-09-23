---
title: "operator&lt; (&lt;stack&gt;)"
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
  - std::operator<
  - operator<
  - std.<
  - <
  - std.operator<
  - std::<
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator<, stack class
  - < operator, comparing specific objects
  - < operator
  - operator <, stack class
ms.assetid: c444c3fd-97c2-41a7-9480-4b94f77342e3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&lt; (&lt;stack&gt;)
Tests if the stack object on the left side of the operator is less than the stack object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<(  
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
 **true** if the stack on the left side of the operator is less than and not equal to the stack on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between stack objects is based on a pairwise comparison of their elements. The less-than relationship between two stack objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// stack_op_lt.cpp  
// compile with: /EHsc  
#include <stack>  
#include <list>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Declares stacks with list base container  
   stack <int, list<int> > s1, s2, s3;  
  
   s1.push( 2 );  
   s1.push( 4 );  
   s1.push( 6 );  
   s1.push( 8 );  
   s2.push( 5 );  
   s2.push( 10 );  
   s3.push( 2 );  
   s3.push( 4 );  
   s3.push( 6 );  
   s3.push( 8 );  
  
   if ( s1 >= s2 )  
      cout << "The stack s1 is greater than or equal to "  
           << "the stack s2." << endl;  
   else  
      cout << "The stack s1 is less than "  
           << "the stack s2." << endl;  
  
   if ( s1>= s3 )  
      cout << "The stack s1 is greater than or equal to "  
           << "the stack s3." << endl;  
   else  
      cout << "The stack s1 is less than "  
           << "the stack s3." << endl;  
  
   // to print out the stack s1 ( by unstacking the elements):  
   stack <int>::size_type i_size_s1 = s1.size( );  
   cout << "The stack s1 from the top down is: ( ";  
   unsigned int i;  
   for ( i = 1 ; i <= i_size_s1 ; i++ )  
   {  
      cout << s1.top( ) << " ";  
      s1.pop( );  
   }  
   cout << ")." << endl;  
}  
```  
  
 **The stack s1 is less than the stack s2.**  
**The stack s1 is greater than or equal to the stack s3.**  
**The stack s1 from the top down is: ( 8 6 4 2 ).**   
## Requirements  
 **Header:** <stack\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)