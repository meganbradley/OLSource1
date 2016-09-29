---
title: "checked_array_iterator::operator+"
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
  - "checked_array_iterator.operator+"
  - "+"
  - "operator+"
  - "std::checked_array_iterator::operator+"
  - "checked_array_iterator::operator+"
  - "iterator/checked_array_iterator::operator+"
  - "std.checked_array_iterator.operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +, iterators"
  - "+ operator, with specific standard C+ library objects"
  - "operator+, iterators"
ms.assetid: 20b78b38-2c43-49cc-bcc4-43070efff339
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# checked_array_iterator::operator+
Adds an offset to an iterator and returns the new `checked_array_iterator` addressing the inserted element at the new offset position.  
  
## Syntax  
  
```  
checked_array_iterator<_Iterator> operator+(  
   difference_type _Off  
) const;  
```  
  
#### Parameters  
 `_Off`  
 The offset to be added to the `checked_array_iterator`.  
  
## Return Value  
 A `checked_array_iterator` addressing the offset element.  
  
## Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// checked_array_iterators_op_plus.cpp  
// compile with: /EHsc  
#include <vector>  
#include <iostream>  
  
int main() {  
   using namespace stdext;  
   using namespace std;  
   int a[] = {6, 3, 77, 199, 222};  
   int b[5];  
   copy(a, a + 5, checked_array_iterator<int*>(b,5));  
  
   checked_array_iterator<int*> checked_output_iterator(b,5);  
  
   cout << *checked_output_iterator << endl;  
   checked_output_iterator = checked_output_iterator + 3;  
   cout << *checked_output_iterator << endl;  
}  
```  
  
 **6**  
**199**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** stdext  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)