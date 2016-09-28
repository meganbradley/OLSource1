---
title: "Setting Linker Options"
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
helpviewer_keywords: 
  - "files [C++], LINK"
  - "input files [C++], linker"
  - "linker [C++], ways to set options"
  - "linker [C++], switches"
  - "input files [C++]"
  - "object/library modules"
ms.assetid: e08fb487-0f2e-4f24-87db-232dbc8bd2e2
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting Linker Options
Linker options can be set inside or outside of the development environment. The topic for each linker option discusses how it can be set in the development environment. See [Linker Options](../vs140/linker-options.md) for a complete list.  
  
 When you run LINK outside the development environment, you can specify input in one or more ways:  
  
-   On the [command line](../vs140/linker-command-line-syntax.md)  
  
-   Using [command files](../vs140/link-command-files.md)  
  
-   In [environment variables](../vs140/link-environment-variables.md)  
  
 LINK first processes options specified in the LINK environment variable, followed by options in the order they are specified on the command line and in command files. If an option is repeated with different arguments, the last one processed takes precedence.  
  
 Options apply to the entire build; no options can be applied to specific input files.  
  
## See Also  
 [C/C++ Building Reference](../vs140/c-c---building-reference.md)   
 [Linker Options](../vs140/linker-options.md)