---
title: "operator&gt;= (&lt;utility&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "operator>="
  - "std::>="
  - "utility/std::operator>="
  - "std.operator>="
  - ">="
  - "std.>="
  - "std::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>=, pair objects"
  - ">= operator, comparing specific objects"
  - "operator >=, pair objects"
ms.assetid: 32cce5fd-3a90-4b11-8fc2-f1859b9339d8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= (&lt;utility&gt;)
Tests if the pair object on the left side of the operator is greater than or equal to the pair object on the right side.  
  
## Syntax  
  
```  
  
      template<Class Type>  
   constexpr bool operator>=(  
      const Type& _Left,   
      const Type& _Right  
);  
  
template<class Type1, class Type2>  
   constexpr bool operator>=(  
      const pair<Type1, Type2>& _Left,  
      const pair<Type1, Type2>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `pair` on the left side of the operator.  
  
 `_Right`  
 An object of type `pair` on the right side of the operator.  
  
## Return Value  
 **true** if the `pair` on the left side of the operator is greater than or equal to the `pair` on the right side of the operator; otherwise **false**.  
  
## Remarks  
 In a comparison of pairs, the values' first elements of the two pairs have the highest priority. If they differ, then the result of their comparison is taken as the result of the comparison of the pair. If the values of the first elements are not different, then the values of the second elements are compared and the result of their comparison is taken as the result of the comparison of the pair.  
  
## Example  
  
```  
// utility_op_ge.cpp  
// compile with: /EHsc  
#include <utility>  
#include <iomanip>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   pair <int, double> p1, p2, p3, p4;  
  
   p1 = make_pair ( 10, 2.22e-1 );  
   p2 = make_pair ( 100, 1.11e-1 );  
   p3 = make_pair ( 10, 1.11e-1 );  
   p4 = make_pair ( 10, 2.22e-1 );  
  
   cout.precision ( 3 );  
   cout << "The pair p1 is: ( " << p1.first << ", "   
        << p1.second << " )." << endl;  
   cout << "The pair p2 is: ( " << p2.first << ", "   
        << p2.second << " )." << endl;  
   cout << "The pair p3 is: ( " << p3.first << ", "   
        << p3.second << " )." << endl;  
   cout << "The pair p4 is: ( " << p4.first << ", "   
        << p4.second << " )." << endl << endl;  
  
   if ( p1 >= p2 )  
      cout << "Pair p1 is greater than or equal to pair p2." << endl;  
   else  
      cout << "The pair p1 is less than the pair p2." << endl;  
  
   if ( p1 >= p3 )  
      cout << "Pair p1 is greater than or equal to pair p3." << endl;  
   else  
      cout << "The pair p1 is less than the pair p3." << endl;  
  
   if ( p1 >= p4 )  
      cout << "Pair p1 is greater than or equal to pair p4." << endl;  
   else  
      cout << "The pair p1 is less than the pair p4." << endl;  
}  
```  
  
 **The pair p1 is: ( 10, 0.222 ).**  
**The pair p2 is: ( 100, 0.111 ).**  
**The pair p3 is: ( 10, 0.111 ).**  
**The pair p4 is: ( 10, 0.222 ).**  
**The pair p1 is less than the pair p2.**  
**Pair p1 is greater than or equal to pair p3.**  
**Pair p1 is greater than or equal to pair p4.**   
## Requirements  
 **Header:** <utility\>  
  
 **Namespace:** std