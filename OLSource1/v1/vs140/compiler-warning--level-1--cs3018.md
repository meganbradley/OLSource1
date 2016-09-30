---
title: "Compiler Warning (level 1) CS3018"
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
  - "CS3018"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3018"
ms.assetid: 35d2f4bd-10c3-4e9f-8e02-389ab84db2cd
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3018
'type' cannot be marked as CLS-Compliant because it is a member of non CLS-compliant type 'type'  
  
 This warning occurs if a nested class with the CLSCompliant attribute set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is declared as a member of a class declared with the CLSCompliant attribute set to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This is not allowed, since a nested class cannot be CLS-compliant if it is a member of an outer class that is not CLS-compliant. To resolve this warning, remove the CLSCompliant attribute from the nested class, or change it from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information on CLS Compliance, see [Writing CLS-Compliant Code](assetId:///4c705105-69a2-4e5e-b24e-0633bc32c7f3) and [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following sample generates CS3018.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>