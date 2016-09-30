---
title: "Compiler Error CS1651"
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
  - "CS1651"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1651"
ms.assetid: ce1043e3-b453-4b4c-b949-f344834e3845
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1651
Fields of static readonly field 'identifier' cannot be passed ref or out (except in a static constructor)  
  
 This error occurs if you pass a variable to a function that is a member of a static readonly field as a ref argument. Since ref parameters may be modified by the function, this is not allowed. To resolve this error, remove the **readonly** keyword on the field, or do not pass the members of the readonly field to the function. For example, you might try creating a temporary variable which can be modifed and passing the temporary as a ref argument, as shown in the following example.  
  
 The following sample generates CS1651:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>