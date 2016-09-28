---
title: "Compiler Warning (level 1) C4652"
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
  - "C4652"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4652"
ms.assetid: 2cf2c666-8cdd-4dd9-bda0-662921498b03
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4652
compiler option 'option' inconsistent with precompiled header; current command-line option will override that defined in the precompiled header  
  
 The given command-line option differed from that given when the precompiled header (.pch) was created. The option specified in the current command line was used.  
  
 This warning can be avoided by regenerating the precompiled header with the given command-line option.