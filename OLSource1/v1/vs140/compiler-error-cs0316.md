---
title: "Compiler Error CS0316"
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
  - "CS0316"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0316"
ms.assetid: 8b70abbe-dd4f-473f-8dfe-f8309abef276
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0316
The parameter name 'name' conflicts with an automatically-generated parameter name.  
  
 Reserved words cannot be used as parameter names. In the example that follows, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a reserved word in the context of a default property or indexer accessor.  
  
### To correct this error  
  
1.  Change the name of the parameter.  
  
## Example  
 The following code generates CS0316:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Indexers (C# Programming Guide)](../vs140/indexers--csharp-programming-guide-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)