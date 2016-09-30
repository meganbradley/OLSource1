---
title: "Compiler Error CS0625"
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
  - "CS0625"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0625"
ms.assetid: 44091813-9988-436c-b35e-e24094793782
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0625
'field': instance field types marked with StructLayout(LayoutKind.Explicit) must have a FieldOffset attribute  
  
 When a struct is marked with an explicit **StructLayout** attribute, all fields in the struct must have the [FieldOffset](frlrfsystemruntimeinteropservicesfieldoffsetattributeclasstopic) attribute. For more information, see [StructLayoutAttribute Class](frlrfSystemRuntimeInteropServicesStructLayoutAttributeClassTopic).  
  
 The following sample generates CS0625:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>