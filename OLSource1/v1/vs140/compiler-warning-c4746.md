---
title: "Compiler Warning C4746"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
dev_langs: 
  - C++
ms.assetid: 5e79ab46-6031-499a-a986-716c866b6c0e
caps.latest.revision: 6
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning C4746
volatile access of '<expression\>' is subject to /volatile:[iso&#124;ms] setting; consider using __iso_volatile_load/store intrinsic functions.  
  
 C4746 is emitted whenever a volatile variable is accessed directly. It is intended to help developers identify code locations that are affected by the specific volatile model currently specified (which can be controlled with the [/volatile](../vs140/-volatile--volatile-keyword-interpretation-.md) compiler option). In particular, it can be useful in locating compiler-generated hardware memory barriers when /volatile:ms is used.  
  
 The __iso_volatile_load/store intrinsics can be used to explicitly access volatile memory without being affected by the volatile model. Using these intrinsics will not trigger C4746.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.