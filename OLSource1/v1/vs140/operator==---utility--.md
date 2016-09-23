---
title: "operator== (&lt;utility&gt;)"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.==
  - utility/std::operator==
  - std::==
  - operator==
  - std.operator==
  - std::operator==
  - ==
dev_langs: 
  - C++
helpviewer_keywords: 
  - == operator, with specific standard C++ objects
  - operator==, pair objects
  - operator ==, pair objects
ms.assetid: b36c75a9-8f53-4c98-8534-c09f169febec
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.mt: 
  - de-de
  - ja-jp
---
# operator== (&lt;utility&gt;)
Tests if the pair object on the left side of the operator is equal to the pair object on the right side.  
  
## Syntax  
  
```  
  
      template<class Type1, class Type2>  
   constexpr bool operator==(  
      const pair<Type1, Type2>& _Left,  
      const pair<Type1, Type2>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **pair.**  
  
 `_Right`  
 An object of type `pair`.  
  
## Return Value  
 **true** if the pairs are equal; **false** if the `pair`s are not equal.  
  
## Remarks  
 One pair is equal to another pair if each of their respective elements is equal. The function returns `_Left`.**first** == `_Right`.**first** && `_Left`.**second** == `_Right`.**second**. Two pairs are unequal if either the first or the second element of one is not equal to the corresponding element of the other pair.  
  
## Example  
  
```  
// utility_op_eq.cpp  
// compile with: /EHsc  
#include <utility>  
#include <iomanip>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   pair <int, double> p1, p2, p3;  
  
   p1 = make_pair ( 10, 1.11e-1 );  
   p2 = make_pair ( 1000, 1.11e-3 );  
   p3 = make_pair ( 10, 1.11e-1 );  
  
   cout.precision ( 3 );  
   cout << "The pair p1 is: ( " << p1.first << ", "   
        << p1.second << " )." << endl;  
   cout << "The pair p2 is: ( " << p2.first << ", "   
        << p2.second << " )." << endl;  
   cout << "The pair p3 is: ( " << p3.first << ", "   
        << p3.second << " )." << endl << endl;  
  
   if ( p1 == p2 )  
      cout << "The pairs p1 and p2 are equal." << endl;  
   else  
      cout << "The pairs p1 and p2 are not equal." << endl;  
  
   if ( p1 == p3 )  
      cout << "The pairs p1 and p3 are equal." << endl;  
   else  
      cout << "The pairs p1 and p3 are not equal." << endl;  
}  
```  
  
## Output  
  
```  
The pair p1 is: ( 10, 0.111 ).  
The pair p2 is: ( 1000, 0.00111 ).  
The pair p3 is: ( 10, 0.111 ).  
  
The pairs p1 and p2 are not equal.  
The pairs p1 and p3 are equal.  
```  
  
## Requirements  
 **Header:** <utility\>  
  
 **Namespace:** std