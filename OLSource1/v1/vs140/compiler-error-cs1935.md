---
title: "Compiler Error CS1935"
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
  - "CS1935"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1935"
ms.assetid: d5dda801-fbf3-4340-bfe1-f9409f2d344d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1935
Could not find an implementation of the query pattern for source type 'type'. 'method' not found. Are you missing a reference to 'System.Core.dll' or a using directive for 'System.Linq'?  
  
 The source type in a query must be <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or a derived type, or a type for which you or someone else has implemented the standard query operators. If the source type is an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you must add a reference to system.core.dll and a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive for the System.Linq namespace in order to bring the standard query operator extension methods into scope. Custom implementations of the standard query operators must be brought into scope in the same way, with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive and, if necessary, a reference to the assembly.  
  
### To correct this error  
  
1.  Add the required using directives and references to the project.  
  
## Example  
 The following code generates CS1935 because the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive for System.Linq is commented out:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Standard Query Operators Overview](../vs140/standard-query-operators-overview.md)