---
title: "operator== (unordered_multimap)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: b3d6308b-3842-450a-99a6-a48e67258719
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (unordered_multimap)
Tests whether the [unordered_multimap](../vs140/unordered_multimap-class.md) object on the left side of the operator is equal to the unordered_multimap object on the right side.  
  
## Syntax  
  
```  
  
      bool operator==(  
   const unordered_multimap <Key, Type, Hash, Pred, Allocator>& _Left,  
   const unordered_multimap <Key, Type, Hash, Pred, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `unordered_multimap`.  
  
 `_Right`  
 An object of type `unordered_multimap`.  
  
## Return Value  
 `true` if the unordered_multimaps are equal; `false` if they are not equal.  
  
## Remarks  
 The comparison between unordered_multimap objects is not affected by the arbitrary order in which they store their elements. Two unordered_multimaps are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
## Example  
  
```cpp  
  
// unordered_multimap_op_eq.cpp  
// compile by using: cl.exe /EHsc /nologo /W4 /MTd  
#include <unordered_map>  
#include <iostream>  
#include <ios>  
  
int main( )  
{  
   using namespace std;  
   unordered_multimap<int, int> um1, um2, um3;  
  
   for ( int i = 0 ; i < 3 ; ++i ) {  
      um1.insert( make_pair( i, i ) );  
      um1.insert( make_pair( i, i ) );  
  
      um2.insert( make_pair( i, i ) );  
      um2.insert( make_pair( i, i ) );  
      um2.insert( make_pair( i, i ) );  
  
      um3.insert( make_pair( i, i ) );  
      um3.insert( make_pair( i, i ) );  
   }  
  
   cout << boolalpha;  
   cout << "um1 == um2: " << (um1 == um2) << endl;   
   cout << "um1 == um3: " << (um1 == um3) << endl;   
   cout << "um2 == um3: " << (um2 == um3) << endl;   
}  
  
```  
  
 **Output:**  
  
 `um1 == um2: false`  
  
 `um1 == um3: true`  
  
 `um2 == um3: false`  
  
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)