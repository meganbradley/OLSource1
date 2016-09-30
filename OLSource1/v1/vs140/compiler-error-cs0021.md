---
title: "Compiler Error CS0021"
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
  - "CS0021"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0021"
ms.assetid: 4eb5fa24-8261-4962-b36a-224be5074217
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0021
Cannot apply indexing with [] to an expression of type 'type'  
  
 An attempt was made to access a value through an indexer on a data type that does not support [Indexers](../vs140/indexers--csharp-programming-guide-.md).  
  
 You may get CS0021 when trying to use an indexer in a C++ assembly. In this case, decorate the C++ class with the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute so the C# compiler knows which indexer is the default. The following sample generates CS0021.  
  
## Example  
 This file compiles to a .dll file—with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute commented out—in order to generate the error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following is the C# file that calls the .dll file. This file attempts to access the class via an indexer, but because no member was declared as the default indexer to be used, the error is generated.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>