---
title: "NMAKE Fatal Error U1099"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - U1099
dev_langs: 
  - C++
helpviewer_keywords: 
  - U1099
ms.assetid: 6688a805-43e6-4247-a2d0-14be082f0b13
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# NMAKE Fatal Error U1099
stack overflow  
  
 The makefile being processed was too complex for the current stack allocation in NMAKE. NMAKE has an allocation of 0x3000 (12K).  
  
 To increase NMAKE's stack allocation, run the [editbin /stack](../vs140/-stack.md) utility with a larger stack option:  
  
 **editbin /STACK:reserve NMAKE.EXE**  
  
 where *reserve* is a number greater than the current stack allocation in NMAKE.