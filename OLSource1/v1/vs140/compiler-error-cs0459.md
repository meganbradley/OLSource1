---
title: "Compiler Error CS0459"
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
  - "CS0459"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0459"
ms.assetid: 01b058dd-8d65-4e9d-9de1-d47f9488d22a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0459
Cannot take the address of a read-only local variable  
  
 There are three common scenarios in the C# language that generate read-only local variables: <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. In each of these cases, you are not allowed to write to the read-only local variable, or to take its address. This error is generated when the compiler realizes you are trying to take the address of a read-only local variable.  
  
## Example  
 The following example generates CS0459 when an attempt is made to take the address of a read-only local variable in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop and in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement block.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>