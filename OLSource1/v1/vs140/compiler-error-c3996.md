---
title: "Compiler Error C3996"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
dev_langs: 
  - "C++"
ms.assetid: 3ae574ed-aba2-4054-8a44-b82a187b5d9e
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3996
annotations that pertain to the value returned by a function should appear at (or near) the start of the declaration  
  
### To correct this error  
  
-   In the declaration, put the SAL annotation that corresponds to the return value either directly before the function identifier or before `auto`.  
  
## Example  
 The following sample generates C3996.  
  
```cpp  
// compile with /analyze  
  
#include <cstdlib>  
  
auto array_alloc(_In_ size_t size) -> _Ret_maybenull_ void *  
{  
  return malloc(size);  
}  
```  
  
## Example  
 The next sample corrects the error.  
  
```cpp  
// compile with /analyze  
  
#include <cstdlib>  
  
auto _Ret_maybenull_ array_alloc(_In_ size_t size) -> void *  
{  
  return malloc(size);  
}  
```