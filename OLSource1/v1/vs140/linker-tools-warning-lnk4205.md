---
title: "Linker Tools Warning LNK4205"
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
  - LNK4205
dev_langs: 
  - C++
helpviewer_keywords: 
  - LNK4205
ms.assetid: d63b9d18-ef3c-4081-9d8d-93077dad13c2
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Tools Warning LNK4205
'filename' is missing current debugging information for referencing module; linking object as if no debug info  
  
 The .pdb file has out-of-date information. The linker will continue to link object without debug information. You may want to recompile the object file using the [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md) option.