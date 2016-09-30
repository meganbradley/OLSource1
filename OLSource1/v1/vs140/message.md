---
title: "message"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "message_CPP"
  - "vc-pragma.message"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "message pragma"
  - "pragmas, message"
ms.assetid: 67414f25-ed47-4079-a5dc-21d9d1a39754
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message
Sends a string literal to the standard output without terminating the compilation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A typical use of the **message** pragma is to display informational messages at compile time.  
  
 The *messagestring* parameter can be a macro that expands to a string literal, and you can concatenate such macros with string literals in any combination.  
  
 If you use a predefined macro in the **message** pragma, the macro should return a string, else you will have to convert the output of the macro to a string.  
  
 The following code fragment uses the **message** pragma to display messages during compilation:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)