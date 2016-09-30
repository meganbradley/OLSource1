---
title: "Compiler Warning (level 1) C4952"
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
  - "C4952"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4952"
ms.assetid: 593324f0-5cfe-42fb-b221-2f71308765dd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4952
'function' : no profile data found in program database 'pgd_file'  
  
 When using [/LTCG:PGUPDATE](../vs140/-ltcg--link-time-code-generation-.md), the compiler detected an input module that was recompiled after <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and has a new function (***function***) present.  
  
 This warning is informational. To resolve this warning, run <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, redo all test runs, and run <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 This warning would be replaced with an error if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> had been used.