---
title: "Compiler Error CS0271"
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
  - "CS0271"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0271"
ms.assetid: eadc9fb5-7770-4ec4-94f6-3c7cf37eec06
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0271
The property or indexer 'property/indexer' cannot be used in this context because the get accessor is inaccessible  
  
 This error occurs when you try to access an inaccessible <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> accessor. To resolve this error, increase the accessibility of the accessor, or change the calling location. For more information, see [Accessor Accessibility](../vs140/restricting-accessor-accessibility--csharp-programming-guide-.md) and [Properties (C# Programmer's Reference)](../vs140/properties--csharp-programming-guide-.md).  
  
 The following example generates CS0271:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>