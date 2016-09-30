---
title: "Compiler Error CS1617"
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
  - "CS1617"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1617"
ms.assetid: fd3371ed-39eb-4d3d-b8f5-d96ac0c79398
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1617
Invalid option 'option' for /langversion; must be ISO-1, ISO-2 or Default  
  
 This error occurs if you used the [/langversion](../vs140/-langversion--csharp-compiler-options-.md) command line switch or project setting but didn't specify a valid language option. To resolve this error, check the command line syntax or project setting and change it to one of the listed options.  
  
 For example, compiling with <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> will generate error CS1617.