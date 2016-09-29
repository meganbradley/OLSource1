---
title: "operator== (set)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "set/std::operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, set or multiset objects"
  - "operator==, set or multiset objects"
  - "== operator, with specific standard C++ objects"
ms.assetid: b7d07738-3c5a-433e-87c2-d818b1d2b1a9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (set)
Tests if the set object on the left side of the operator is equal to the set object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!==(  
   const set <Key, Traits, Allocator>& _Left,  
   const set <Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **set**.  
  
 `_Right`  
 An object of type **set**.  
  
## Return Value  
 **true** if the set on the left side of the operator is equal to the set on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between set objects is based on a pairwise comparison of their elements. Two sets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// set_op_eq.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1, s2, s3;  
   int i;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      s1.insert ( i );  
      s2.insert ( i * i );  
      s3.insert ( i );  
   }  
  
   if ( s1 == s2 )  
      cout << "The sets s1 and s2 are equal." << endl;  
   else  
      cout << "The sets s1 and s2 are not equal." << endl;  
  
   if ( s1 == s3 )  
      cout << "The sets s1 and s3 are equal." << endl;  
   else  
      cout << "The sets s1 and s3 are not equal." << endl;  
}  
```  
  
 **The sets s1 and s2 are not equal.**  
**The sets s1 and s3 are equal.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)