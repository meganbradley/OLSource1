---
title: "Command-Line Error D8027"
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
  - "D8027"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "D8027"
ms.assetid: f228220f-0c7f-49a6-a6e0-1f7bd4745aa6
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Command-Line Error D8027
cannot execute 'component'  
  
 The compiler could not run the given compiler component or linker.  
  
### To fix by checking the following possible causes  
  
1.  Not enough memory to load the component. If NMAKE invoked the compiler, run the compiler outside of the makefile.  
  
2.  The current operating system could not run the component. Make sure the path points to the executable files appropriate to your operating system.  
  
3.  The component was corrupted. Recopy the component from the distribution disks, using the SETUP program.  
  
4.  An option was specified incorrectly. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>