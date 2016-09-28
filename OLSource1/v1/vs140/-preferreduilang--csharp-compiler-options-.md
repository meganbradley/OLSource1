---
title: "-preferreduilang (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/preferreduilang (C# Compiler Options)"
f1_keywords: 
  - "/preferreduilang"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "preferreduilang compiler option [C#]"
  - "/preferreduilang compiler option [C#]"
  - "-preferreduilang compiler option [C#]"
ms.assetid: 68b2462f-6778-48d7-8052-62805fe8e02c
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -preferreduilang (C# Compiler Options)
By using the `/preferreduilang` compiler option, you can specify the language in which the C# compiler displays output, such as error messages.  
  
## Syntax  
  
```  
/preferreduilang: language  
```  
  
## Arguments  
 `language`  
 The [language name](http://go.microsoft.com/fwlink/p/?LinkId=236992) of the language to use for compiler output.  
  
## Remarks  
 You can use the `/preferreduilang` compiler option to specify the language that you want the C# compiler to use for error messages and other command-line output. If the language pack for the language is not installed, the language setting of the operating system is used instead, and no error is reported.  
  
```c#  
csc.exe /preferreduilang:ja-JP  
```  
  
## Requirements  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)