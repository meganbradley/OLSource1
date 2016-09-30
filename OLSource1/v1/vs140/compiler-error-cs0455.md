---
title: "Compiler Error CS0455"
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
  - "CS0455"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0455"
ms.assetid: a09840ac-ad8c-4c9c-868e-b83d937c7047
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0455
Type parameter 'Type Parameter Name' inherits conflicting constraints 'Constraint Name 1' and 'Constraint Name 2'  
  
 Two common ways to get this error are to set up constraints so that the type parameter derives from two non-related classes, or so that it derives from a class type or reference type constraint and a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type or value type constraint. To resolve this error, remove the conflict from your inheritance hierarchy.  
  
## Example  
 The following code generates error CS0455.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>