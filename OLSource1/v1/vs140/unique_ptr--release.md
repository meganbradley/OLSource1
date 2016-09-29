---
title: "unique_ptr::release"
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
  - "release"
  - "std.unique_ptr.release"
  - "std::unique_ptr::release"
  - "unique_ptr.release"
  - "memory/std::unique_ptr::release"
  - "unique_ptr::release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "release method"
ms.assetid: ca050c71-da7d-4598-a8d7-3af9a602cdbc
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_ptr::release
Releases ownership of the returned stored pointer to the caller and sets the stored pointer value to `nullptr`.  
  
## Syntax  
  
```  
pointer release();  
```  
  
## Property Value/Return Value  
 Returns the stored pointer.  
  
## Remarks  
 Use `release` to take over ownership of the raw pointer stored by the `unique_ptr`. The caller is responsible for deletion of the returned pointer. The `unique-ptr` is set to the empty default-constructed state. You can assign another pointer of compatible type to the `unique_ptr` after the call to `release`.  
  
## Example  
 This example shows how the caller of release is responsible for the object returned:  
  
```cpp  
// stl_release_unique.cpp  
// Compile by using: cl /W4 /EHsc stl_release_unique.cpp  
#include <iostream>  
#include <memory>  
  
struct Sample {  
   int content_;  
   Sample(int content) : content_(content) {  
      std::cout << "Constructing Sample(" << content_ << ")" << std::endl;  
   }  
   ~Sample() {  
      std::cout << "Deleting Sample(" << content_ << ")" << std::endl;  
   }  
};  
  
void ReleaseUniquePointer() {  
   // Use make_unique function when possible.    
   auto up1 = std::make_unique<Sample>(3);  
   auto up2 = std::make_unique<Sample>(42);  
  
   // Take over ownership from the unique_ptr up2 by using release  
   auto ptr = up2.release();  
   if (up2) {  
      // This statement does not execute, because up2 is empty.  
      std::cout << "up2 is not empty." << std::endl;  
   }  
   // We are now responsible for deletion of ptr.  
   delete ptr;  
   // up1 deletes its stored pointer when it goes out of scope.     
}  
  
int main() {  
   ReleaseUniquePointer();  
}  
```  
  
 Computer output:  
  
 **Constructing Sample(3)**  
**Constructing Sample(42)**  
**Deleting Sample(42)**  
**Deleting Sample(3)**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [unique_ptr](../vs140/unique_ptr-class.md)   
 [How to: Create and Use unique_ptr Instances](../vs140/how-to--create-and-use-unique_ptr-instances.md)   
 [<memory\>](../vs140/-memory-.md)