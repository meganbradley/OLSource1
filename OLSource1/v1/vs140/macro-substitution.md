---
title: "Macro Substitution"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NMAKE program, macro substitution"
  - "macros, NMAKE"
  - "substitution macros in NMAKE"
ms.assetid: 47465cfe-fd92-49db-aebe-7c2d7ecceb73
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Macro Substitution
When *macroname* is invoked, each occurrence of *string1* in its definition string is replaced by *string2*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Macro substitution is case sensitive and is literal; *string1* and *string2* cannot invoke macros. Substitution does not modify the original definition. You can substitute text in any predefined macro except [$$@](../vs140/filename-macros.md).  
  
 No spaces or tabs precede the colon; any after the colon are interpreted as literal. If *string2* is null, all occurrences of *string1* are deleted from the macro's definition string.  
  
## See Also  
 [Using an NMAKE Macro](../vs140/using-an-nmake-macro.md)