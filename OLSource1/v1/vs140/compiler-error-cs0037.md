---
title: "Compiler Error CS0037"
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
  - "CS0037"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0037"
ms.assetid: 1d34a71e-10a0-4fa8-9b94-343e69428c61
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0037
Cannot convert null to 'type' because it is a non-nullable value type  
  
 The compiler cannot assign null to a value type; null can only be assigned to a [reference type](../vs140/reference-types--csharp-reference-.md) or to a Nullable type. [struct](../vs140/struct--csharp-reference-.md) is a value type. For more information, see [Nullable Types (C# Programmers Reference)](../vs140/nullable-types--csharp-programming-guide-.md).  
  
 The following sample generates CS0037:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>