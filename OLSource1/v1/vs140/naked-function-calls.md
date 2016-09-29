---
title: "Naked Function Calls"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "virtual device drivers"
  - "VXD virtual device drivers"
  - "virtual device drivers, naked function calls"
  - "naked functions"
  - "prolog code"
  - "epilog code"
  - "naked keyword [C++]"
  - "naked keyword [C++], storage-class attribute"
ms.assetid: 2a66847a-a43f-4541-a7be-c9f5f29b5fdb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Naked Function Calls
## Microsoft Specific  
 Functions declared with the `naked` attribute are emitted without prolog or epilog code, enabling you to write your own custom prolog/epilog sequences using the [inline assembler](../vs140/inline-assembler.md). Naked functions are provided as an advanced feature. They enable you to declare a function that is being called from a context other than C/C++, and thus make different assumptions about where parameters are, or which registers are preserved. Examples include routines such as interrupt handlers. This feature is particularly useful for writers of virtual device drivers (VxDs).  
  
## What do you want to know more about?  
  
-   [naked](../vs140/naked--c---.md)  
  
-   [Rules and Limitations for Naked Functions](../vs140/rules-and-limitations-for-naked-functions.md)  
  
-   [Considerations for Writing Prolog/Epilog Code](../vs140/considerations-for-writing-prolog-epilog-code.md)  
  
### END Microsoft Specific  
  
## See Also  
 [Calling Conventions](../vs140/calling-conventions.md)