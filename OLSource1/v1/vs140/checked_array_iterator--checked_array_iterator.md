---
title: "checked_array_iterator::checked_array_iterator"
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
  - std.checked_array_iterator.checked_array_iterator
  - checked_array_iterator.checked_array_iterator
  - checked_array_iterator
  - checked_array_iterator::checked_array_iterator
  - std::checked_array_iterator::checked_array_iterator
  - iterator/checked_array_iterator::checked_array_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - checked_array_iterator class, constructor
  - checked_array_iterator function
  - checked_array_iterator class
  - checked_array_iterator method
ms.assetid: 46d89386-2f09-4535-8c11-3f74a4890eb5
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# checked_array_iterator::checked_array_iterator
Constructs a default `checked_array_iterator` or a `checked_array _iterator` from an underlying iterator.  
  
## Syntax  
  
```  
checked_array_iterator( );  
checked_array_iterator(  
   ITerator ptr,  
   size_t size,  
   size_t index = 0  
);  
```  
  
#### Parameters  
 `ptr`  
 A pointer to the array.  
  
 `size`  
 The size of the array.  
  
 `index`  
 (Optional) An element in the array, to initialize the iterator.  By default, the iterator is initialized to the first element in the array.  
  
## Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// checked_array_iterators_ctor.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <iostream>   
  
using namespace std;  
using namespace stdext;  
  
int main() {  
   int a[] = {0, 1, 2, 3, 4};  
   int b[5];  
   copy(a, a + 5, checked_array_iterator<int*>(b,5));  
  
   for (int i = 0 ; i < 5 ; i++)  
      cout << b[i] << " ";  
   cout << endl;  
  
   checked_array_iterator<int*> checked_output_iterator(b,5);  
   copy (a, a + 5, checked_output_iterator);  
   for (int i = 0 ; i < 5 ; i++)  
      cout << b[i] << " ";  
   cout << endl;  
  
   checked_array_iterator<int*> checked_output_iterator2(b,5,3);  
   cout << *checked_output_iterator2 << endl;  
}  
```  
  
 **0 1 2 3 4**   
**0 1 2 3 4**   
**3**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** stdext  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)