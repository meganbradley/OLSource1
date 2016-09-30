---
title: "Compiler Error CS0308"
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
  - "CS0308"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0308"
ms.assetid: b52ef9d2-f5b3-4baf-9a7e-bb1371e79463
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0308
The non-generic type-or-method 'identifier' cannot be used with type arguments.  
  
 The method or type is not generic, but it was used with type arguments. To avoid this error, remove the angled brackets and type arguments, or redeclare the method or type as a generic method or type.  
  
 The following example generates CS0308:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following example also generates CS0308. To resolve the error, use the directive "using System.Collections.Generic."  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>