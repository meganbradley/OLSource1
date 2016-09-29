---
title: "Compiler Warning (level 4) C4092"
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
  - "C4092"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4092"
ms.assetid: 396ae826-a892-4327-bd66-f4762376d72b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4092
sizeof returns 'unsigned long'  
  
 The operand of the `sizeof` operator was very large, so `sizeof` returned an unsigned **long**. This warning occurs under the Microsoft extensions ([/Ze](../vs140/-za---ze--disable-language-extensions-.md)). Under ANSI compatibility (/Za), the result is truncated instead.