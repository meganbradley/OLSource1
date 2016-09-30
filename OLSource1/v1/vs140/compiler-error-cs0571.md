---
title: "Compiler Error CS0571"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0571"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0571"
ms.assetid: 72a97e9c-3c78-47de-b477-dbd2c953d95d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0571
'function' : cannot explicitly call operator or accessor  
  
 Certain operators have internal names. For example, **op_Increment** is the internal name of the ++ operator. You should not use or explicitly call such method names.  
  
 The following sample generates CS0571:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>