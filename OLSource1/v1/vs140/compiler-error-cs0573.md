---
title: "Compiler Error CS0573"
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
  - "CS0573"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0573"
ms.assetid: 10ef9625-44f1-4936-ada3-56938357aa01
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0573
'field declaration' : cannot have instance field initializers in structs  
  
 You cannot initialize an instance field of a [struct](../vs140/struct--csharp-reference-.md). Fields of value types will be initialized to their default values, and reference-type fields will be initialized to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates CS0573:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>