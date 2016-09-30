---
title: "Compiler Warning (level 1) C4715"
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
  - "C4715"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4715"
ms.assetid: 1c819bf7-0d8b-4f5e-b338-9cc292870439
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4715
'function' : not all control paths return a value  
  
 The specified function can potentially not return a value.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To prevent this warning, modify the code so that all paths assign a return value to the function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 It is possible that your code may contain a call to a function that never returns, as in the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This code also generates a warning, because the compiler does not know that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> never returns. To prevent this code from generating an error message, declare <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> using [__declspec(noreturn)](../vs140/noreturn.md).