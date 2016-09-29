---
title: "&lt;stdexcept&gt;"
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
  - "std.<stdexcept>"
  - "std::<stdexcept>"
  - "<stdexcept>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stdexcept header"
ms.assetid: 495c10b1-1e60-4514-9f8f-7fda11a2f522
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;stdexcept&gt;
Defines several standard classes used for reporting exceptions. The classes form a derivation hierarchy all derived from class [exception](../vs140/exception-class.md) and include two general types of exceptions: logical errors and run-time errors. The logical errors are caused programmer mistakes. They derive from the base class logic_error and include:  
  
-   `domain_error`  
  
-   `invalid_argument`  
  
-   `length_error`  
  
-   `out_of_range`  
  
 The run-time errors occur because of mistakes in either the library functions or in the run-time system. They derive from the base class runtime_error and include:  
  
-   `overflow_error`  
  
-   `range_error`  
  
-   `underflow_error`  
  
### Classes  
  
|||  
|-|-|  
|[domain_error Class](../vs140/domain_error-class.md)|The class serves as the base class for all exceptions thrown to report a domain error.|  
|[invalid_argument Class](../vs140/invalid_argument-class.md)|The class serves as the base class for all exceptions thrown to report an invalid argument.|  
|[length_error Class](../vs140/length_error-class.md)|The class serves as the base class for all exceptions thrown to report an attempt to generate an object too long to be specified.|  
|[logic_error Class](../vs140/logic_error-class.md)|The class serves as the base class for all exceptions thrown to report errors presumably detectable before the program executes, such as violations of logical preconditions.|  
|[out_of_range Class](../vs140/out_of_range-class.md)|The class serves as the base class for all exceptions thrown to report an argument that is out of its valid range.|  
|[overflow_error Class](../vs140/overflow_error-class.md)|The class serves as the base class for all exceptions thrown to report an arithmetic overflow.|  
|[range_error Class](../vs140/range_error-class.md)|The class serves as the base class for all exceptions thrown to report a range error.|  
|[runtime_error Class](../vs140/runtime_error-class.md)|The class serves as the base class for all exceptions thrown to report errors presumably detectable only when the program executes.|  
|[underflow_error Class](../vs140/underflow_error-class.md)|The class serves as the base class for all exceptions thrown to report an arithmetic underflow.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)