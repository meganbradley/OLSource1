---
title: "map::crbegin"
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
  - "std::map::crbegin"
  - "map.crbegin"
  - "std.map.crbegin"
  - "map::crbegin"
  - "map/std::map::crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 78fffdc8-c437-4644-8528-3bfe81e3ef45
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::crbegin
Returns a const iterator addressing the first element in a reversed map.  
  
## Syntax  
  
```  
  
const_reverse_iterator crbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [map](../vs140/map-class.md) or addressing what had been the last element in the unreversed `map`.  
  
## Remarks  
 `crbegin` is used with a reversed `map` just as [begin](../vs140/map--begin.md) is used with a `map`.  
  
 With the return value of `crbegin`, the `map` object cannot be modified  
  
 `crbegin` can be used to iterate through a `map` backwards.  
  
## Example  
  
```  
// map_crbegin.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   map <int, int> m1;  
  
   map <int, int> :: const_reverse_iterator m1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   m1.insert ( Int_Pair ( 1, 10 ) );  
   m1.insert ( Int_Pair ( 2, 20 ) );  
   m1.insert ( Int_Pair ( 3, 30 ) );  
  
   m1_crIter = m1.crbegin( );  
   cout << "The first element of the reversed map m1 is "  
        << m1_crIter -> first << "." << endl;  
}  
```  
  
 **The first element of the reversed map m1 is 3.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)