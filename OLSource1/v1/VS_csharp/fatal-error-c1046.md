---
title: "Fatal Error C1046"
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
  - "C1046"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1046"
ms.assetid: 822ec5f5-b0b0-4711-99e1-fc237b619af6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1046
compiler limit : structure nested too deeply  
  
 The structure, union, or class exceeded the nesting limit, which is 15 levels. Rewrite the definition to reduce the nesting level. Split the structure, union, or class into two or more parts by using `typedef` to define one or more of the nested structures.