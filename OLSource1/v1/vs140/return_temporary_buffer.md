---
title: "return_temporary_buffer"
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
  - memory/std::return_temporary_buffer
  - return_temporary_buffer
  - std::return_temporary_buffer
  - std.return_temporary_buffer
dev_langs: 
  - C++
helpviewer_keywords: 
  - return_temporary_buffer function
  - return_temporary_buffer
ms.assetid: 7597218e-d152-41bb-a915-33e766788973
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# return_temporary_buffer
Deallocates the temporary memory that was allocated using the `get_temporary_buffer` template function.  
  
## Syntax  
  
```  
  
   template<class Type>  
void return_temporary_buffer(  
   Type* _Pbuf  
);  
```  
  
#### Parameters  
 *_Pbuf*  
 A pointer to the memory to be deallocated.  
  
## Remarks  
 This function should only be used for memory that is temporary.  
  
## Example  
  
```  
// memory_ret_temp_buf.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
  
using namespace std;  
  
int main( )  
{  
   // Create an array of ints  
   int intArray [ ] = { 10, 20, 30, 40, 100, 200, 300 };  
   int count = sizeof ( intArray ) / sizeof ( int );  
   cout << "The number of integers in the array is: "   
         << count << "." << endl;  
  
   pair<int *, ptrdiff_t> resultPair;  
   resultPair = get_temporary_buffer<int>( count );  
  
   cout << "The number of elements that the allocated memory\n"  
         << " could store is given by: resultPair.second = "   
         << resultPair.second << "." << endl;  
  
   int* tempBuffer = resultPair.first;  
  
   // Deallocates memory allocated with get_temporary_buffer  
   return_temporary_buffer ( tempBuffer );  
}  
```  
  
 **The number of integers in the array is: 7.**  
**The number of elements that the allocated memory**  
 **could store is given by: resultPair.second = 7.**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std