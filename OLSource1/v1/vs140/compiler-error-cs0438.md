---
title: "Compiler Error CS0438"
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
  - "CS0438"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0438"
ms.assetid: 92c91ecb-8d6a-4850-84eb-c095c3c957f1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0438
The type 'type' in 'module_1' conflicts with the namespace 'namespace' in 'module_2'.  
  
 This error occurs when a type in a source file conflicts with a namespace in another source file. This typically happens when one or both come from an added module. To resolve, rename the type or the namespace that caused the conflict.  
  
 The following example generates CS0438:  
  
 Compile this file first:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Then compile this file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 And then compile this file:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>