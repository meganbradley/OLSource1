---
title: "operator&gt;= (multiset)"
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
  - operator>=
  - std::>=
  - std.operator>=
  - >=
  - set/std::operator>=
  - std.>=
  - std::operator>=
dev_langs: 
  - C++
helpviewer_keywords: 
  - >= operator
  - operator>=
ms.assetid: 5de6be94-3d48-4bb6-aa96-d07999f3d58f
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&gt;= (multiset)
Tests if the multiset object on the left side of the operator is greater than or equal to the multiset object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!>=(  
   const multiset <Key, Traits, Allocator>& _Left,  
   const multiset <Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `multiset`.  
  
 `_Right`  
 An object of type `multiset`.  
  
## Return Value  
 **true** if the multiset on the left side of the operator is greater than or equal to the multiset on the right side of the list; otherwise **false**.  
  
## Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The greater than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// multiset_op_ge.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multiset <int> s1, s2, s3, s4;  
   int i;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      s1.insert ( i );  
      s2.insert ( i * i );  
      s3.insert ( i - 1 );  
      s4.insert ( i );  
   }  
  
   if ( s1 >= s2 )  
      cout << "The multiset s1 is greater than "  
           << "or equal to the multiset s2." << endl;  
   else  
      cout << "The multiset s1 is less than "  
           << "the multiset s2." << endl;  
  
   if ( s1 >= s3 )  
      cout << "The multiset s1 is greater than "  
           << "or equal to the multiset s3." << endl;  
   else  
      cout << "The multiset s1 is less than "  
           << "the multiset s3." << endl;  
  
   if ( s1 >= s4 )  
      cout << "The multiset s1 is greater than "  
           << "or equal to the multiset s4." << endl;  
   else  
      cout << "The multiset s1 is less than "  
           << "the multiset s4." << endl;  
}  
```  
  
 **The multiset s1 is less than the multiset s2.**  
**The multiset s1 is greater than or equal to the multiset s3.**  
**The multiset s1 is greater than or equal to the multiset s4.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)