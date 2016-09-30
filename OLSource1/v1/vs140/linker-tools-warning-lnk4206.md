---
title: "Linker Tools Warning LNK4206"
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
  - "LNK4206"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4206"
ms.assetid: 6c108e33-00cf-4c5a-830d-d65d470930a7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4206
precompiled type information not found; 'filename' not linked or overwritten; linking object as if no debug info  
  
 The given object file, compiled with [/Yc](../vs140/-yc--create-precompiled-header-file-.md), was either not specified in the LINK command or was overwritten.  
  
 A common scenario for this warning is when the .obj that was compiled with /Yc is in a library, and where there are no symbol references to that .obj from your code.  In that case, the linker will not use (or even see) the .obj file.  In this situation, you should recompile your code and use [/Yl](../vs140/-yl--inject-pch-reference-for-debug-library-.md) for the remaining objects (the objects that are not compiled with /Yc).