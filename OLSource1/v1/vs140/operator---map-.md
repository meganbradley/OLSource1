---
title: "operator&gt; (map)"
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
  - "map/std::operator>"
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "std::>"
  - ">"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >, maps"
  - "> operator, comparing specific objects"
ms.assetid: 307f36d1-c1c1-4038-8945-946bf35776d6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (map)
Tests if the map object on the left side of the operator is greater than the map object on the right side.  
  
## Syntax  
  
```  
  
      bool operator>(  
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
 **true** if the map on the left side of the operator is greater than the map on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between map objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// map_op_gt.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   map < int, int > m1, m2, m3;  
   int i;  
   typedef pair < int, int > Int_Pair;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      m1.insert ( Int_Pair ( i, i ) );  
      m2.insert ( Int_Pair ( i, i * i ) );  
      m3.insert ( Int_Pair ( i, i - 1 ) );  
   }  
  
   if ( m1 > m2 )  
      cout << "The map m1 is greater than the map m2." << endl;  
   else  
      cout << "The map m1 is not greater than the map m2." << endl;  
  
   if ( m1 > m3 )  
      cout << "The map m1 is greater than the map m3." << endl;  
   else  
      cout << "The map m1 is not greater than the map m3." << endl;  
}  
```  
  
 **The map m1 is not greater than the map m2.**  
**The map m1 is greater than the map m3.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)