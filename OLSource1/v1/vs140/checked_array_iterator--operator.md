---
title: "checked_array_iterator::operator"
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
  - std.checked_array_iterator.operator[]
  - checked_array_iterator.operator[]
  - []
  - operator[]
  - std::checked_array_iterator::operator[]
  - checked_array_iterator::operator[]
  - iterator/checked_array_iterator::operator[]
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator [], iterators
  - [] operator, with specific standard C[] library objects
  - operator[], iterators
ms.assetid: ef9bf60c-c639-4194-b763-b75b6e166eb7
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# checked_array_iterator::operator
Returns a reference to an element offset from the element addressed by a `checked_array_iterator` by a specified number of positions.  
  
## Syntax  
  
```  
reference operator[](difference_type_Off) const;  
```  
  
#### Parameters  
 `_Off`  
 The offset from the `checked_array_iterator` address.  
  
## Return Value  
 The reference to the element offset.  
  
## Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// checked_array_iterators_op_diff.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main() {  
   using namespace std;     
   int V1[10];  
  
   for (int i = 0; i < 10 ; i++)  
      V1[i] = i;  
  
   // Declare a difference type for a parameter  
   stdext::checked_array_iterator<int*>::difference_type diff = 2;  
  
   stdext::checked_array_iterator<int*> VChkIter(V1, 10);  
  
   stdext::checked_array_iterator<int*>::reference refrpos = VChkIter [diff];  
  
   cout << refrpos + 1 << endl;  
}  
```  
  
 **3**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** stdext  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)