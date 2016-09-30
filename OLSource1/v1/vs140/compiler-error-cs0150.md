---
title: "Compiler Error CS0150"
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
  - "CS0150"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0150"
ms.assetid: 1fd08ca5-e1a9-42f5-93de-2916a3bdcad1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0150
A constant value is expected  
  
 A variable was found where a constant was expected. For more information, see [switch (C# Programmers Reference)](../vs140/switch--csharp-reference-.md).  
  
 The following sample generates CS0150:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error is also produced when an array size is specified with a variable value and initialized with an array initializer. To remove the error, initialize the array in a separate statement or statements.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>