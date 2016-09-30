---
title: "chrono literals"
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
ms.assetid: 1a9e23b1-256f-4570-8226-5fa7364fb032
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# chrono literals
(C++14) The \<chrono> header defines 12 [user-defined literals](../vs140/user-defined-literals---c---.md) to facilitate using literals that represent hours, minutes, seconds, milliseconds, microseconds, and nanoseconds. Each user-defined literal has an integral and a floating-point overload. The literals are defined in the literals::chrono_literals inline namespace which is brought into scope automatically when std::chrono is in scope.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 The literals that take a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> argument return a value or the corresponding type. The literals that take a floating point argument return a [duration](../vs140/duration-class.md).  
  
## Remarks  
  
## Example  
 The following examples sow how to use the chrono literals.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header**: \<chrono>  
  
 **Namespace**: std::literals::chrono_literals  
  
## See Also  
 [\<chrono>](../vs140/-chrono-.md)