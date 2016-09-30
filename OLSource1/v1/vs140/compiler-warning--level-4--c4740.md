---
title: "Compiler Warning (Level 4) C4740"
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
  - "C4740"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4740"
ms.assetid: 85528969-966a-44b4-8a2f-971704c64477
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 4) C4740
flow in or out of inline asm code suppresses global optimization  
  
 When there is a jump in to or out of an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block, global optimizations are disabled for that function.  
  
 The following sample generates C4740:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>