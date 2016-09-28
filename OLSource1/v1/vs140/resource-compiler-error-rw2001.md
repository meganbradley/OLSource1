---
title: "Resource Compiler Error RW2001"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "RW2001"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RW2001"
ms.assetid: 963bdc7d-6ebe-4378-8bbc-47dfcf5d330c
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Compiler Error RW2001
Invalid directive in preprocessed RC file  
  
 The RC file contains a **#pragma** directive.  
  
 Use the **#ifndef** preprocessor directive with the **RC_INVOKED** constant that the Resource Compiler defines when it processes an include file. Place the **#pragma** directive inside a block of code that is not processed when the **RC_INVOKED** constant is defined. Code in the block is processed only by the C/C++ compiler and not by the Resource Compiler. The following sample code demonstrates this technique:  
  
```  
#ifndef RC_INVOKED  
#pragma pack(2)  // C/C++ only, ignored by Resource Compiler  
#endif  
```  
  
 The **#pragma** preprocessor directive has no meaning in an .RC file. The **#include** preprocessor directive is used frequently in an .RC file to include a header file (either a project-based custom header file or a standard header file provided by Microsoft with one of its products). Some of these include files contain the **#pragma** directive. Because a header file can include one or more other header files, the file that contains the offending **#pragma** directive may not be immediately obvious.  
  
 The **#ifndef RC_INVOKED** technique can control including header files in project-based header files.