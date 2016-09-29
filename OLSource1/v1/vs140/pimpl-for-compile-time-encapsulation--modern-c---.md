---
title: "Pimpl For Compile-Time Encapsulation (Modern C++)"
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
ms.assetid: c3e8a90a-b328-4990-82bb-e1b147f76e07
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Pimpl For Compile-Time Encapsulation (Modern C++)
The *pimpl idiom* is a modern C++ technique to hide implementation, to minimize coupling, and to separate interfaces. Pimpl is short for "pointer to implementation." You may already be familiar with the concept but know it by other names like Cheshire Cat or Compiler Firewall idiom.  
  
## Why use pimpl?  
 Here's how the pimpl idiom can improve the software development lifecycle:  
  
-   Minimization of compilation dependencies.  
  
-   Separation of interface and implementation.  
  
-   Portability.  
  
## Pimpl header  
  
```cpp  
  
// my_class.h  
class my_class {  
   //  ... all public and protected stuff goes here ...  
private:  
   class impl; unique_ptr<impl> pimpl; // opaque type here  
};  
  
```  
  
 The pimpl idiom avoids rebuild cascades and brittle object layouts. It's well suited for (transitively) popular types.  
  
## Pimpl implementation  
 Define the `impl` class in the .cpp file.  
  
```cpp  
  
// my_class.cpp  
class my_class::impl {  // defined privately here  
  // ... all private data and functions: all of these  
  //     can now change without recompiling callers ...  
};  
my_class::my_class(): pimpl( new impl )  
{  
  // ... set impl values ...   
}  
```  
  
## Best practices  
 Consider whether to add support for non-throwing swap specialization.  
  
## See Also  
 [Welcome Back to C++](../vs140/welcome-back-to-c----modern-c---.md)   
 [C++ Language Reference](../vs140/c---language-reference.md)   
 [Standard C++ Library](../vs140/c---standard-library-reference.md)