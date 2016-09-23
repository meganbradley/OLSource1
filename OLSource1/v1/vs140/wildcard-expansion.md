---
title: "Wildcard Expansion"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
f1_keywords: 
  - _setargv
dev_langs: 
  - C++
helpviewer_keywords: 
  - asterisk wildcard
  - _setargv function
  - command line, processing arguments
  - command line, wildcards
  - command-line wildcards
  - question mark, wildcard
ms.assetid: 1a543398-607b-4404-93d1-45d290bde638
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Wildcard Expansion
## Microsoft Specific  
 You can use wildcards — the question mark (?) and asterisk (*) — to specify filename and path arguments on the command-line.  
  
 Command-line arguments are handled by a routine called **_setargv** (or **_wsetargv** in the wide-character environment), which by default does not expand wildcards into separate strings in the `argv` string array. For more information on enabling wildcard expansion, refer to [Expanding Wildcard Arguments](../vs140/expanding-wildcard-arguments.md).  
  
## END Microsoft Specific  
  
## See Also  
 [main: Program Startup](../vs140/main--program-startup.md)