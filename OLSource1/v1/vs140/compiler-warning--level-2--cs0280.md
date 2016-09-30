---
title: "Compiler Warning (level 2) CS0280"
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
  - "CS0280"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0280"
ms.assetid: 9b453478-92aa-4fd2-9b87-780fd138603a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0280
'type' does not implement the 'pattern name' pattern. 'method name' has the wrong signature.  
  
 Two statements in C#, **foreach** and **using**, rely on predefined patterns, "collection" and "resource" respectively. This warning occurs when the compiler cannot match one of these statements to its pattern due to a method's incorrect signature. For example, the "collection" pattern requires that there be a method called \<xref:System.Collections.IEnumerator.MoveNext*> which takes no parameters and returns a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. Your code might contain a \<xref:System.Collections.IEnumerator.MoveNext*> method that has a parameter or perhaps returns an object.  
  
 The "resource" pattern and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> provide another example. The "resource" pattern requires the \<xref:System.IDisposable.Dispose*> method; if you define a property with the same name, you will get this warning.  
  
 To resolve this warning, ensure that the method signatures in your type match the signatures of the corresponding methods in the pattern, and ensure that you have no properties with the same name as a method required by the pattern.  
  
## Example  
 The following sample generates CS0280.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>