---
title: "Compiler Error CS0694"
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
  - "CS0694"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0694"
ms.assetid: 048615e4-4599-4726-b5db-55322ccc936f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0694
Type parameter 'identifier' has the same name as the containing type, or method  
  
 You must use a different name for the type parameter since the type parameter's name cannot be identical to the type or method name that contains the type parameter.  
  
## Example  
 The following sample generates CS0694.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 In addition to the above case involving a generic class, this error may occur with a method:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>