---
title: "Compiler Warning (level 2) CS0435"
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
  - "CS0435"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0435"
ms.assetid: e70cd8c1-d399-4af8-8b1e-69a1de389aad
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0435
The namespace 'namespace' in 'assembly' conflicts with the imported type 'type' in 'assembly'. Using the namespace defined in 'assembly'..  
  
 This warning is issued when a namespace in a source file (file_2) conflicts with an imported type in file_1. The compiler uses the one in the source file.  
  
 The following example generates CS0435:  
  
 Compile this file first:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Then, compile this file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>