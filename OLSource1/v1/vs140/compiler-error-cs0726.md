---
title: "Compiler Error CS0726"
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
  - "CS0726"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0726"
ms.assetid: 9ea5f004-cf25-4e6e-b9e5-6b53e4a7e1ab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0726
'format specifier' is not a valid format specifier  
  
 This error occurs in the debugger. When you type a variable name into one of the debugger windows, you can follow it with a comma, and then a format specifier. Examples are: `myInt, h` or `myString,nq`. This error arises when the compiler does not recognize the [format specifier](../vs140/format-specifiers-in-csharp.md).