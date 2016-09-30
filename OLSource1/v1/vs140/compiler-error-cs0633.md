---
title: "Compiler Error CS0633"
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
  - "CS0633"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0633"
ms.assetid: a24d310b-151a-45eb-b150-3407940ec24c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0633
The argument to the 'attribute' attribute must be a valid identifier  
  
 Any argument that you pass to the \<xref:System.Diagnostics.ConditionalAttribute*> or \<xref:System.Runtime.CompilerServices.IndexerNameAttribute*> attributes must be a valid identifier. This means that it may not contain characters such as "+" that are illegal when they occur in identifiers.  
  
## Example  
 This example illustrates CS0633 using the \<xref:System.Diagnostics.ConditionalAttribute*>. The following sample generates CS0633.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This example illustrates CS0633 using the \<xref:System.Runtime.CompilerServices.IndexerNameAttribute*>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>