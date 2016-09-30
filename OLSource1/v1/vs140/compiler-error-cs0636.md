---
title: "Compiler Error CS0636"
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
  - "CS0636"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0636"
ms.assetid: 47597f89-fbe6-4708-9493-3c86c6f0ce56
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0636
The FieldOffset attribute can only be placed on members of types marked with the StructLayout(LayoutKind.Explicit)  
  
 You must use the **StructLayout(LayoutKind.Explicit)** attribute on the struct declaration, if it contains any members marked with the **FieldOffset** attribute. For more information, see [FieldOffset](frlrfsystemruntimeinteropservicesfieldoffsetattributeclasstopic).  
  
 The following sample generates CS0636:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>