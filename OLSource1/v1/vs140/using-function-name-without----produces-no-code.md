---
title: "Using Function Name Without () Produces No Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "functions [C++], without parentheses"
ms.assetid: edf4a177-a160-44aa-8436-e077b5b27809
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Function Name Without () Produces No Code
When a function name declared in your program is used without parentheses, the compiler does not produce code. This occurs regardless of whether or not the function takes parameters because the compiler calculates the function address; however, because the function call operator "()" is not present, no call is made. This result is similar to the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In Visual C++, even using warning level 4 generates no diagnostic output. No warning is issued; no code is produced.  
  
 The sample code below compiles (with a warning) and links correctly without errors but produces no code in reference to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. For this to work correctly, add the function call operator "()".  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Optimizing Your Code](../vs140/optimizing-your-code.md)