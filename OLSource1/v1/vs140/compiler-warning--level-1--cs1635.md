---
title: "Compiler Warning (level 1) CS1635"
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
  - "CS1635"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1635"
ms.assetid: e1795880-f7ea-4dca-b15b-4ba549d7ed78
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1635
Cannot restore warning 'warning code' because it was disabled globally  
  
 This warning occurs if you use the **/nowarn** command line option or project setting to disable a warning for the entire compilation unit, but you use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to attempt to restore that warning. To resolve this error, remove the /nowarn command line option or project setting, or remove the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for any warnings you are disabling via the command line or project settings. For more information, see the [#pragma warning](../vs140/sharppragma-warning--csharp-reference-.md) topic.  
  
 The following sample generates CS1635:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>