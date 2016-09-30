---
title: "Compiler Warning (level 1) CS1720"
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
  - "CS1720"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1720"
ms.assetid: 97adc294-3a4c-4418-a4ed-ccff43125b62
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1720
Expression will always cause a System.NullReferenceException because the default value of 'generic type' is null  
  
 If you write an expression involving the default of a generic type variable that is a reference type (for example, a class), this error will occur. Consider the following expression:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Since <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a reference type, its default value is null, and so attempting to apply the \<xref:System.Object.ToString*> method to it will throw a \<xref:System.NullReferenceException*>.  
  
## Example  
 The class reference constraint on type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> ensures that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a reference type.  
  
 The following sample generates CS1720.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>