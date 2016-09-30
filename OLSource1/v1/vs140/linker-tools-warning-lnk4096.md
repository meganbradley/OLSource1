---
title: "Linker Tools Warning LNK4096"
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
  - "LNK4096"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4096"
ms.assetid: ef6fba38-59a1-4d86-bcac-cadf44d87a36
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4096
/BASE value "number" is invalid for Windows 95 and Windows 98; image may not run  
  
 The base address you specified is invalid. Windows 95 and Windows 98 executable files must have a base address greater than 0x400000. For more information on base addresses, see the [/BASE](../vs140/-base--base-address-.md) linker option.