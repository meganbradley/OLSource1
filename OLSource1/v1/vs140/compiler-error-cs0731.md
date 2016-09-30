---
title: "Compiler Error CS0731"
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
  - "CS0731"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0731"
ms.assetid: b2df5d5c-b1cd-4620-881f-f5a492669784
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0731
The type forwarder for type 'type' in assembly 'assembly' causes a cycle  
  
 This error can only occur with improperly formed imported metadata. It cannot occur with only C# source.  
  
## Example  
 The following sample generates CS0731. The example consists of three files:  
  
 1. Circular.IL  
  
 2. Circular2.IL  
  
 3. CS0731.cs  
  
 First compile the .IL files as libraries, and then compile the .cs code referencing the two files.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>