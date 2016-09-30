---
title: "Compiler Error CS0840"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0840"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0840"
ms.assetid: f307083f-8d86-4142-a9fd-b735910687b2
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0840
'Property name' must declare a body because it is not marked abstract or extern. Automatically implemented properties must define both get and set accessors.  
  
 Unless a regular property is marked as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or is a member of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type, it must supply a body. Auto-implemented properties do not provide accessor bodies, but they must specify both accessors. To create a read-only auto-implemented property, make the set accessor <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
1.  Supply the missing body or accessor or else use the [abstract](../vs140/abstract--csharp-reference-.md), [extern](../vs140/extern--csharp-reference-.md), or [partial](../vs140/partial--type---csharp-reference-.md) modifiers on it and/or its enclosing type.  
  
## Example  
 The following example generates CS0840:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Auto-Implemented Properties (C# Programming Guide)](../vs140/auto-implemented-properties--csharp-programming-guide-.md)