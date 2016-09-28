---
title: "ostream_iterator::operator="
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
  - "std::ostream_iterator::operator="
  - "="
  - "operator="
  - "ostream_iterator.operator="
  - "std.ostream_iterator.operator="
  - "iterator/std::ostream_iterator::operator="
  - "ostream_iterator::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, iterators"
  - "operator =, iterators"
  - "= operator, with specific standard C++ library objects"
ms.assetid: a6be16e4-c6d7-4909-bcb7-373483c8aecb
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator::operator=
Assignment operator used to implement the output_iterator expression *`i` = `x` for writing to an output stream.  
  
## Syntax  
  
```  
ostream_iterator<Type, CharType, Traits>& operator=(  
   const Type& _Val  
);  
```  
  
#### Parameters  
 `_Val`  
 The value of the object of type `Type` to be inserted into the output stream.  
  
## Return Value  
 The operator inserts `_Val` into the output stream associated with the object, followed by the delimiter specified in the [ostream_iterator constructor](../vs140/ostream_iterator--ostream_iterator.md) (if any), and then returns a reference to the `ostream_iterator`.  
  
## Remarks  
 The requirements for an output iterator that the `ostream_iterator` must satisfy require only the expression *`ii` = `t` be valid and says nothing about the operator or the operator= on their own. This member operator returns `*this`.  
  
## Example  
  
```  
// ostream_iterator_op_assign.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // ostream_iterator for stream cout  
   // with new line delimiter  
   ostream_iterator<int> intOut ( cout , "\n" );  
  
   // Standard iterator interface for writing  
   // elements to the output stream  
   cout << "Elements written to output stream:" << endl;  
   *intOut = 10;  
   intOut++;      // No effect on iterator position  
   *intOut = 20;  
   *intOut = 30;  
}  
```  
  
 **Elements written to output stream:**  
**10**  
**20**  
**30**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostream_iterator Class](../vs140/ostream_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)