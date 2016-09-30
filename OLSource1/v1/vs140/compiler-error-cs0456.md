---
title: "Compiler Error CS0456"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0456"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0456"
ms.assetid: d714ec06-a7f4-405e-bf32-423696848319
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0456
Type parameter 'Type Parameter Name 1' has the 'struct' constraint so 'Type Parameter Name 1' cannot be used as a constraint for 'Type Parameter Name 2'  
  
 Value type constraints are implicitly sealed so those constraints cannot be used as constraints on a second type parameter. This is because value types cannot be overridden. To resolve this error, put a value type constraint directly on the second type parameter, instead of doing so indirectly by means of the first type parameter.  
  
## Example  
 The following sample generates CS0456.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>