---
title: "operator== (unordered_set)"
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
ms.assetid: 99ddaba1-e995-4167-ac22-3ec2e282fc15
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (unordered_set)
Tests whether the [unordered_set](../vs140/unordered_set-class.md) object on the left side of the operator is equal to the unordered_set object on the right side.  
  
## Syntax  
  
```  
  
      bool operator==(  
   const unordered_set <Key, Hash, Pred, Allocator>& _Left,  
   const unordered_set <Key, Hash, Pred, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `unordered_set`.  
  
 `_Right`  
 An object of type `unordered_set`.  
  
## Return Value  
 `true` if the unordered_sets are equal; `false` if they are not equal.  
  
## Remarks  
 The comparison between unordered_set objects is not affected by the arbitrary order in which they store their elements. Two unordered_sets are equal if they have the same number of elements and the elements in one container are a permutation of the elements in the other container. Otherwise, they are unequal.  
  
## Example  
  
```cpp  
  
// unordered_set_eq.cpp   
// compile by using: cl.exe /EHsc /nologo /W4 /MTd   
#include <unordered_set>   
#include <iostream>   
#include <ios>  
  
int main()   
{   
    using namespace std;  
  
    unordered_set<char> c1, c2, c3;  
  
    c1.insert('a');   
    c1.insert('b');   
    c1.insert('c');   
  
    c2.insert('c');   
    c2.insert('a');   
    c2.insert('d');   
  
    c3.insert('c');   
    c3.insert('a');   
    c3.insert('b');   
  
   cout << boolalpha;  
   cout << "c1 == c2: " << (c1 == c2) << endl;   
   cout << "c1 == c3: " << (c1 == c3) << endl;   
   cout << "c2 == c3: " << (c2 == c3) << endl;   
  
    return (0);   
}  
  
```  
  
 **Output:**  
  
 `c1 == c2: false`  
  
 `c1 == c3: true`  
  
 `c2 == c3: false`  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)