---
title: "operator!= (multiset)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "set/std::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!="
ms.assetid: 7aff0aba-de0f-4fd8-aae1-654714d47458
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (multiset)
Tests if the multiset object on the left side of the operator is not equal to the multiset object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
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
 **true** if the sets or multisets are not equal; **false** if sets or multisets are equal.  
  
## Remarks  
 The comparison between multiset objects is based on a pairwise comparison between their elements. Two sets or multisets are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
## Example  
  
```  
// multiset_op_ne.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multiset <int> s1, s2, s3;  
   int i;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      s1.insert ( i );  
      s2.insert ( i * i );  
      s3.insert ( i );  
   }  
  
   if ( s1 != s2 )  
      cout << "The multisets s1 and s2 are not equal." << endl;  
   else  
      cout << "The multisets s1 and s2 are equal." << endl;  
  
   if ( s1 != s3 )  
      cout << "The multisets s1 and s3 are not equal." << endl;  
   else  
      cout << "The multisets s1 and s3 are equal." << endl;  
}  
```  
  
 **The multisets s1 and s2 are not equal.**  
**The multisets s1 and s3 are equal.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)