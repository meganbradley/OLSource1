---
title: "operator&lt;= (map)"
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
  - "operator <=, maps"
  - "<= operator, with specific objects"
  - "<= operator"
  - "operator<=, maps"
ms.assetid: 14a8e9eb-b809-4d45-b728-799ea14389ea
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator&lt;= (map)
Tests if the map object on the left side of the operator is less than or equal to the map object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<=(  
   const map <Key, Type, Traits, Allocator>& _Left,  
   const map <Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type **map**.  
  
 `_Right`  
 An object of type **map**.  
  
## Return Value  
 **true** if the map on the left side of the operator is less than or equal to the map on the right side of the operator; otherwise **false**.  
  
## Remark  
 The comparison between map objects is based on a pairwise comparison of their elements. The less than or equal to relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// map_op_le.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   map <int, int> m1, m2, m3, m4;  
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
      cout << "The map m1 is less than or equal to the map m2." << endl;  
   else  
      cout << "The map m1 is greater than the map m2." << endl;  
  
   if ( m1 <= m3 )  
      cout << "The map m1 is less than or equal to the map m3." << endl;  
   else  
      cout << "The map m1 is greater than the map m3." << endl;  
  
   if ( m1 <= m4 )  
      cout << "The map m1 is less than or equal to the map m4." << endl;  
   else  
      cout << "The map m1 is greater than the map m4." << endl;  
}  
```  
  
 **The map m1 is less than or equal to the map m2.**  
**The map m1 is greater than the map m3.**  
**The map m1 is less than or equal to the map m4.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)