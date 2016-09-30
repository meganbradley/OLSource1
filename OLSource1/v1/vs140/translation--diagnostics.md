---
title: "Translation: Diagnostics"
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
  - "C"
ms.assetid: 3730ca7c-0147-452d-bd4a-6a1e97e9793e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Translation: Diagnostics
**ANSI 2.1.1.3** How a diagnostic is identified  
  
 Microsoft C produces error messages in the form:  
  
```  
  
filename( line-number ) : diagnostic Cnumbermessage  
```  
  
 where *filename* is the name of the source file in which the error was encountered; *line-number* is the line number at which the compiler detected the error; `diagnostic` is either "error" or "warning"; `number` is a unique four-digit number (preceded by a **C**, as noted in the syntax) that identifies the error or warning; `message` is an explanatory message.  
  
## See Also  
 [Implementation-Defined Behavior](../vs140/implementation-defined-behavior.md)