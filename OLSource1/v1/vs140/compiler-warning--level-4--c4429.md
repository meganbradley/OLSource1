---
title: "Compiler Warning (level 4) C4429"
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
  - "C4429"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4429"
ms.assetid: a3e4cf1f-a869-4e47-834a-850c21eb5297
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4429
possible incomplete or improperly formed universal-character-name  
  
 The compiler detected a character sequence that may be a badly formed universal character name. A universal character name is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> followed by four hex digits, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> followed by eight hex digits.  
  
 The following sample generates C4429:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>