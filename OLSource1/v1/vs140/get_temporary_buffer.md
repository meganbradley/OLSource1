---
title: "get_temporary_buffer"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::get_temporary_buffer
  - std.get_temporary_buffer
  - memory/std::get_temporary_buffer
  - get_temporary_buffer
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_temporary_buffer function
  - get_temporary_buffer
ms.assetid: e068ecd1-67b3-4e40-8b44-76ed8ed93c09
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# get_temporary_buffer
Allocates temporary storage for a sequence of elements that does not exceed a specified number of elements.  
  
## Syntax  
  
```  
  
   template<class Type>  
pair<Type *, ptrdiff_t>  
   get_temporary_buffer(  
      ptrdiff_t _Count  
   );  
```  
  
#### Parameters  
 `_Count`  
 The maximum number of elements requested for which memory is to be allocated.  
  
## Return Value  
 A `pair` whose first component is a pointer to the memory that was allocated, and whose second component gives the size of the buffer, indicating the largest number of elements that it could store.  
  
## Remarks  
 The function makes a request for memory and it may not succeed. If no buffer is allocated, then the function returns a pair, with the second component equal to zero and the first component equal to the null pointer.  
  
 This function should only be used for memory that is temporary.  
  
## Example  
  
```  
// memory_get_temp_buf.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
  
using namespace std;  
  
int main( )  
{  
   // Create an array of ints  
   int intArray [ ] = { 10, 20, 30, 40, 100, 200, 300, 1000, 2000 };  
   int count = sizeof ( intArray ) / sizeof ( int );  
   cout << "The number of integers in the array is: "   
      << count << "." << endl;  
  
   pair<int *, ptrdiff_t> resultPair;  
   resultPair = get_temporary_buffer<int>( count );  
  
   cout << "The number of elements that the allocated memory\n"  
        << "could store is given by: resultPair.second = "   
        << resultPair.second << "." << endl;  
}  
```  
  
 **The number of integers in the array is: 9.**  
**The number of elements that the allocated memory**  
**could store is given by: resultPair.second = 9.**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std