---
title: "Compiler Error CS0447"
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
  - "CS0447"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0447"
ms.assetid: a25486c5-e9bf-4528-8533-c1aaab22ace0
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0447
Attributes cannot be used on type arguments, only on type parameters  
  
 This error occurs when you apply an attribute to a type argument that occurs in an invocation statement. It is acceptable to apply an attribute to a type parameter in a class or method declaration statement such as the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following line of code will generate this error. It is assumed that the class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, defined in the previous line of code, has a static method called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code generates error CS0447.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>