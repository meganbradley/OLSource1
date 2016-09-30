---
title: "checked_array_iterator::operator!="
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
  - "std::checked_array_iterator::operator!="
  - "checked_array_iterator.operator!="
  - "std.checked_array_iterator.operator!="
  - "checked_array_iterator::operator!="
  - "!="
  - "iterator/checked_array_iterator::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator !=, iterators"
  - "operator!=, iterators"
  - "!= operator, with specific standard C!= library objects"
ms.assetid: 6a4fff83-f49e-461e-b7a2-a64d8dded7e9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# checked_array_iterator::operator!=
Tests two `checked_array_iterator`s for inequality.  
  
## Syntax  
  
```  
bool operator!=(  
   const checked_array_iterator<_Iterator>& _Right  
) const;  
```  
  
#### Parameters  
 `_Right`  
 The `checked_array_iterator` against which to check for inequality.  
  
## Remarks  
 For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
## Example  
  
```  
// checked_array_iterators_opneq.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <iostream>   
  
using namespace std;  
using namespace stdext;  
  
int main() {  
   int a[] = {0, 1, 2, 3, 4};  
   int b[5];  
   copy(a, a + 5, checked_array_iterator<int*>(b,5));  
   copy(a, a + 5, checked_array_iterator<int*>(b,5));  
  
   checked_array_iterator<int*> checked_output_iterator(b,5);  
   checked_array_iterator<int*> checked_output_iterator2(b,5);  
  
   if (checked_output_iterator2 != checked_output_iterator)  
      cout << "checked_array_iterators are not equal" << endl;  
   else  
      cout << "checked_array_iterators are equal" << endl;  
  
   copy (a, a + 5, checked_output_iterator);  
   checked_output_iterator++;  
  
   if (checked_output_iterator2 != checked_output_iterator)  
      cout << "checked_array_iterators are not equal" << endl;  
   else  
      cout << "checked_array_iterators are equal" << endl;  
}  
```  
  
 **checked_array_iterators are equal**  
**checked_array_iterators are not equal**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** stdext  
  
## See Also  
 [checked_array_iterator Class](../vs140/checked_array_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)