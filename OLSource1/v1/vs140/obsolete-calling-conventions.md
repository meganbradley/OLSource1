---
title: "Obsolete Calling Conventions"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - __fortran
  - __pascal
  - __syscall
dev_langs: 
  - C++
helpviewer_keywords: 
  - WINAPI
  - __syscall keyword [C++]
  - __pascal keyword [C++]
  - __fortran keyword [C++]
  - calling conventions, obsolete
ms.assetid: a91fc665-034a-48ce-b6bd-d27125f308a7
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Obsolete Calling Conventions
## Microsoft Specific  
 The **__pascal**, **__fortran**, and **__syscall** calling conventions are no longer supported. You can emulate their functionality by using one of the supported calling conventions and appropriate linker options.  
  
 WINDOWS.H now supports the **WINAPI** macro, which translates to the appropriate calling convention for the target. Use **WINAPI** where you previously used **PASCAL** or **__far \__pascal**.  
  
## END Microsoft Specific  
  
## See Also  
 [Argument Passing and Naming Conventions](../vs140/argument-passing-and-naming-conventions.md)