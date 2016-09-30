---
title: "Compiler Warning (level 1) C4794"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4794"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4794"
ms.assetid: badc9c36-fa1a-4fec-929b-7bfda7a7b79f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4794
segment of thread local storage variable 'variable' changed from 'section name' to '.tls$'  
  
 You used [#pragma data_seg](../vs140/data_seg.md) to put a tls variable in a section not starting with .tls$.  
  
 The .tls$*x* section will exist in the object file where [__declspec(thread)](../vs140/thread.md) variables are defined. A .tls section in the EXE or DLL will result from these sections.  
  
## Example  
 The following sample generates C4794:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>