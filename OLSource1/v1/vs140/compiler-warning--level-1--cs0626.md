---
title: "Compiler Warning (level 1) CS0626"
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
  - "CS0626"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0626"
ms.assetid: 2cd5061c-80e7-48d3-8d14-be7fc642af94
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS0626
Method, operator, or accessor 'method' is marked external and has no attributes on it. Consider adding a DllImport attribute to specify the external implementation  
  
 A method marked <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> should also be marked with an attribute, for example, the [DllImport](frlrfSystemRuntimeInteropServicesDllImportAttributeClassTopic) attribute.  
  
 The attribute specifies where the method is implemented. At run time, the program will need this information.  
  
 The following sample generates CS0626:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>