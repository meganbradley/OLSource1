---
title: "&lt;cfenv&gt;"
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
ms.assetid: 6a17ad51-2182-4e91-8108-65997382acd3
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;cfenv&gt;
Includes the Standard C library header <fenv.h> and adds the associated names to the `std` namespace.  
  
## Syntax  
  
```  
#include <cfenv>  
  
```  
  
## Remarks  
 Including this header ensures that the names declared using external linkage in the Standard C library header are declared in the `std` namespace.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Standard C++ Library Overview](../vs140/c---standard-library-overview.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)