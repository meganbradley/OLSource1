---
title: "nothrow (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "nothrow_cpp"
  - "nothrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__declspec keyword [C++], nothrow"
  - "nothrow __declspec keyword"
ms.assetid: 0a475139-459c-4ec6-99e8-7ecd0d7f44a3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nothrow (C++)
**Microsoft Specific**  
  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> extended attribute which can be used in the declaration of functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This attribute tells the compiler that the declared function and the functions it calls never throw an exception. With the synchronous exception handling model, now the default, the compiler can eliminate the mechanics of tracking the lifetime of certain unwindable objects in such a function, and significantly reduce the code size. Given the following preprocessor directive, the three function declarations below are equivalent:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has the advantage that you can use an API definition, such as that illustrated by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement, to easily specify <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on a set of functions. The third declaration<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the syntax defined by the C++ standard.  
  
 See [Synchronous Exception Handling](assetId:///81595fae-d8ab-4c14-9670-8d6639cc0369) for more information.  
  
 **END Microsoft Specific**  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Keywords](../vs140/keywords--c---.md)