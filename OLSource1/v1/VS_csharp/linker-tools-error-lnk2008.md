---
title: "Linker Tools Error LNK2008"
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
  - "LNK2008"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK2008"
ms.assetid: bbcd83c5-c8ae-439e-a033-63643a5bb373
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK2008
Fixup target is not aligned 'symbol_name'  
  
 LINK found a fixup target in your object file that was not aligned properly.  
  
 This error can be caused by custom secton alignment (for example, #pragma [pack](../VS_csharp/pack.md)), [align](../VS_csharp/align--c---.md) modifier, or by using assembly language code that modifies secton alignment.  
  
 If your code does not use any of the above, this may be caused by the compiler.