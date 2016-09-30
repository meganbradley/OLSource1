---
title: "Compiler Error C3415"
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
  - "C3415"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3415"
ms.assetid: fa2db8ab-2820-4ec3-a740-fb5e2adcfb29
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3415
multiple 'section_name' sections found with different attributes ('value')  
  
 Conflicting values were specified in [section](../vs140/section.md) pragmas.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the current setting for the section, as specified in ntimage.h. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3415:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>