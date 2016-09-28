---
title: "Compiler Error C2708"
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
  - "C2708"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2708"
ms.assetid: d52d3088-1141-42f4-829c-74755a7fcc3a
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2708
'identifier' : actual parameters length in bytes differs from previous call or reference  
  
 A [__stdcall](../vs140/__stdcall.md) function must be preceded by a prototype. Otherwise, the compiler interprets the first call to the function as a prototype and this error occurs when the compiler encounters a call that does not match.  
  
 To fix this error add a function prototype.