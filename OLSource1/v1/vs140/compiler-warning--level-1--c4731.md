---
title: "Compiler Warning (Level 1) C4731"
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
  - "C4731"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4731"
ms.assetid: 5658c24c-3e6f-4505-835b-1fb92d47cab0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (Level 1) C4731
'pointer' : frame pointer register 'register' modified by inline assembly code  
  
 A frame pointer register was modified. You must save and restore the register in your inline assembly block or frame variable (local or parameter, depending on the register modified), or your code may not work properly.  
  
 The following sample generates C4731:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 EBP is the frame pointer (FPO is disallowed) and it is being modified. When <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is later referenced, it is referenced relative to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. But <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has been overwritten by the code, so the program will not work properly and may even fault.