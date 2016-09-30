---
title: "operator&lt;= (multimap)"
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
  - "map/std::operator<="
  - "operator<="
  - "std.<="
  - "std::operator<="
  - "<="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator<="
  - "<= operator"
ms.assetid: f1bbf15d-4ff0-4215-ae9f-590aa715f140
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (multimap)
Tests if the multimap object on the left side of the operator is less than or equal to the multimap object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<=(  
   const multimap <Key, Type, Traits, Allocator>& _Left,  
   const multimap <Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `multimap`.  
  
 `_Right`  
 An object of type `multimap`.  
  
## Return Value  
 **true** if the multimap on the left side of the operator is less than or equal to the multimap on the right side of the operator; otherwise **false**.  
  
## Remark  
 The comparison between multimap objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// multimap_op_le.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap <int, int> m1, m2, m3, m4;  
   int i;  
   typedef pair <int, int> Int_Pair;  
  
   for ( i = 1 ; i < 3 ; i++ )  
   {  
      m1.insert ( Int_Pair ( i, i ) );  
      m2.insert ( Int_Pair ( i, i * i ) );  
      m3.insert ( Int_Pair ( i, i - 1 ) );  
      m4.insert ( Int_Pair ( i, i ) );  
   }  
  
   if ( m1 <= m2 )  
      cout << "m1 is less than or equal to m2" << endl;  
   else  
      cout << "m1 is greater than m2" << endl;  
  
   if ( m1 <= m3 )  
      cout << "m1 is less than or equal to m3" << endl;  
   else  
      cout << "m1 is greater than m3" << endl;  
  
   if ( m1 <= m4 )  
      cout << "m1 is less than or equal to m4" << endl;  
   else  
      cout << "m1 is greater than m4" << endl;  
}  
```  
  
 **m1 is less than or equal to m2**  
**m1 is greater than m3**  
**m1 is less than or equal to m4**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)