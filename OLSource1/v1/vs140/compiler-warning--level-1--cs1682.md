---
title: "Compiler Warning (level 1) CS1682"
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
  - "CS1682"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1682"
ms.assetid: 6f3b19ba-29f3-4472-941d-57f6fda6dc3a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1682
Reference to type 'type' claims it is nested within 'nested type', but it could not be found  
  
 This error arises when you import references that do not agree with other references or with code you have written. A common way to get this error is to write code that refers to a class in metadata, and then you either delete that class or modify its definition.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following sample generates CS1682.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>