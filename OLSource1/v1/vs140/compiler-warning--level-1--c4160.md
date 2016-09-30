---
title: "Compiler Warning (level 1) C4160"
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
  - "C4160"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4160"
ms.assetid: a9610cb7-cac4-4a74-8b4e-049030ebb92b
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4160
**#pragma**   
 ***pragma* (pop,...) : did not find previously pushed identifier '**   
 ***identifier* '**  
  
 A pragma statement in your source code tries to pop an identifier that has not been pushed. To avoid this warning, be sure that the identifier being popped has been properly pushed.  
  
 The following example generates C4160:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>