---
title: "Compiler Error CS0616"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0616"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0616"
ms.assetid: ed60f7bb-40cf-4a93-b823-e29e83df7bf7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0616
'class' is not an attribute class  
  
 An attempt was made to use a non-attribute class in an attribute block. All the attribute types need to be inherited from \<xref:System.Attribute*?displayProperty=fullName>.  
  
## Example  
 The following sample generates CS0616.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample shows how you might define an attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>