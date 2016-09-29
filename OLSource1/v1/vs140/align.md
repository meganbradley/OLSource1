---
title: "align"
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
ms.assetid: 302b5954-9ed5-4b7a-888a-eb04f69414ba
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# align
Fits storage of the given size—aligned by the given alignment specification—into the first possible address of the given storage.  
  
## Syntax  
  
```cpp  
void* align(  
    size_t Alignment, // input  
    size_t Size,      // input  
    void*& Ptr        // input/output  
    size_t& Space     // input/output  
);  
```  
  
#### Parameters  
 `Alignment`  
 The alignment bound to attempt.  
  
 `Size`  
 The size in bytes for the aligned storage.  
  
 `Ptr`  
 The starting address of the available contiguous storage pool to use. This parameter is also an output parameter, and will contain the new starting address if the alignment is successful.  
  
 If `align()` is unsuccessful, this parameter is not modified.  
  
 `Space`  
 The total space available to `align()` to use in creating the aligned storage. This parameter is also an output parameter, and contains the adjusted space left in the storage buffer after the aligned storage and any associated overhead is subtracted.  
  
 If `align()` is unsuccessful, this parameter is not modified.  
  
## Return Value  
 A null pointer if the requested aligned buffer would not fit into the available space; otherwise, the new value of `Ptr`.  
  
## Remarks  
 The modified `Ptr` and `Space` parameters enable you to call `align()` repeatedly on the same buffer, possibly with different values for `Alignment` and `Size`. The following code snippet shows one use of `align()`.  
  
```cpp  
  
#include <type_traits> // std::alignment_of()  
#include <memory>  
//...  
char buffer[256]; // for simplicity  
size_t alignment = std::alignment_of<int>::value;  
void * ptr = buffer;  
std::size_t space = sizeof(buffer); // Be sure this results in the true size of your buffer  
  
while (alignment, sizeof(MyObj), ptr, space)) {  
    // You now have storage the size of MyObj, starting at ptr, aligned on   
    // int boundary. Use it here if you like, or save off the starting address  
    // contained in ptr for later use.  
    // ...  
    // Last, move starting pointer and decrease available space before  
    // the while loop restarts.  
    ptr = reinterpret_cast<char*>(ptr) + sizeof(MyObj);  
    space -= sizeof(MyObj);  
}  
// At this point, align() has returned a null pointer, signaling it is not  
// possible to allow more aligned storage in this buffer.  
  
```  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)