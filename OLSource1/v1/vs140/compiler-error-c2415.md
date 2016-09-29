---
title: "Compiler Error C2415"
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
  - "C2415"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2415"
ms.assetid: f225c913-2bea-46b1-b096-3d358ac94a15
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2415
improper operand type  
  
 The opcode does not use operands of this type.  
  
### To fix by checking the following possible causes  
  
1.  The opcode does not support the number of operands used. Check an assembly-language reference manual to determine the correct number of operands.  
  
2.  A newer processor supports the instruction with additional types. Adjust the [/arch](../vs140/-arch--minimum-cpu-architecture-.md) option to use the later processor.