---
title: "Compiler Error CS1507"
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
  - "CS1507"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1507"
ms.assetid: e1be3aba-81dc-4f65-87a4-d3f90b82dc7d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1507
Cannot link resource file 'file' when building a module  
  
 [/linkresource](../vs140/-linkresource--csharp-compiler-options-.md) was used in the same compilation with [/target:module](../vs140/-target-module--csharp-compiler-options-.md), which is not allowed. For example, the following options would generate CS1507:  
  
```  
csc /linkresource:rf.resource /target:module in.cs  
```  
  
 Embeding resourrces ([/resource](../vs140/-resource--csharp-compiler-options-.md)), however, is allowed.