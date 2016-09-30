---
title: "Compiler Error CS1650"
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
  - "CS1650"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1650"
ms.assetid: 251a3a67-6e56-4795-874a-d54610c70595
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1650
Fields of static readonly field 'identifier' cannot be assigned to (except in a static constructor or a variable initializer)  
  
 This error occurs when you attempt to modify a member of a field which is readonly and static where it is not allowed to be modified. To resolve this error, limit assignments to readonly fields to the constructor or variable initializer, or remove the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword from the declaration of the field.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>