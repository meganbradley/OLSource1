---
title: "checked_array_iterator::base"
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
  - "iterator/checked_array_iterator::base"
  - "checked_array_iterator::base"
  - "checked_array_iterator.base"
  - "base"
  - "std.checked_array_iterator.base"
  - "std::checked_array_iterator::base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "base method"
  - "base function"
ms.assetid: 35a44212-eac3-4fc8-9c37-e4da8784754f
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# checked_array_iterator::base
Recovers the underlying iterator from its `checked_array_iterator`.  
  
## Syntax  
  
```  
_Iterator base() const;  
```  
  
## Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// checked_array_iterators_base.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main() {  
   using namespace std;  
  
   int V1[10];  
  
   for (int i = 0; i < 10 ; i++)  
      V1[i] = i;  
  
   int* bpos;  
  
   stdext::checked_array_iterator<int*> rpos(V1, 10);  
   rpos++;  
  
   bpos = rpos.base ( );  
   cout << "The iterator underlying rpos is bpos & it points to: "   
        << *bpos << "." << endl;  
}  
```  
  
 **The iterator underlying rpos is bpos & it points to: 1.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** stdext  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)