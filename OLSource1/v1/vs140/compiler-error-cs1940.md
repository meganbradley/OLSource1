---
title: "Compiler Error CS1940"
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
  - "CS1940"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1940"
ms.assetid: 546e9bba-725d-4ea9-826f-37ec9d832add
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1940
Multiple implementations of the query pattern were found for source type 'type'. Ambiguous call to 'method'.  
  
 This error is generated when multiple implementations of a query method are defined and the compiler cannot disambiguate which one is best to use for the query. In the following example, both versions of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> have the same signature, because they both accept one <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as an input parameter and have <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as a return value.  
  
### To correct this error  
  
1.  Provide only one implementation for each method.  
  
## Example  
 The following code generates CS1940:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Standard Query Operators Overview](../vs140/standard-query-operators-overview.md)