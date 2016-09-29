---
title: "Compiler Error C2152"
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
  - "C2152"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2152"
ms.assetid: a9ea2b0c-d55d-41c7-ba9f-dd75592ffc8a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2152
'identifier' : pointers to functions with different attributes  
  
 A pointer to a function with one calling convention (`__cdecl`, `__stdcall`, or `__fastcall`) is assigned to a pointer to a function with another calling convention.