---
title: "Diagnostic Printed by the assert Function"
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
ms.assetid: 78b64200-520d-40da-9a61-71553f411d4f
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Diagnostic Printed by the assert Function
**ANSI 4.2** The diagnostic printed by and the termination behavior of the **assert** function  
  
 The **assert** function prints a diagnostic message and calls the **abort** routine if the expression is false (0). The diagnostic message has the form  
  
 **Assertion failed**: *expression***, file** *filename***, line** *linenumber*  
  
 where filename is the name of the source file and linenumber is the line number of the assertion that failed in the source file. No action is taken if expression is true (nonzero).  
  
## See Also  
 [Library Functions](../vs140/library-functions.md)