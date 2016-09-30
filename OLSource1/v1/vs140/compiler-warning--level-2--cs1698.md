---
title: "Compiler Warning (level 2) CS1698"
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
  - "CS1698"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1698"
ms.assetid: 65cac5d0-e045-40f9-911c-1bf50e710b18
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS1698
Circular assembly reference 'AssemblyName1' does not match the output assembly name 'AssemblyName2'. Try adding a reference to 'AssemblyName1' or changing the output assembly name to match.  
  
 CS1698 occurs when an assembly reference is incorrect. This can happen if a referenced assembly is recompiled. To resolve, do not replace an assembly that itself is a dependency of an assembly you are referencing.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS1698.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>