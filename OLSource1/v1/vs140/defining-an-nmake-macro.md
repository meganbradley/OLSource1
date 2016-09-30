---
title: "Defining an NMAKE Macro"
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
  - "macros, NMAKE"
  - "defining NMAKE macros"
  - "NMAKE macros, defining"
ms.assetid: 45aae451-9d33-4a3d-8799-2e0cae17070d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Defining an NMAKE Macro
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The *macroname* is a combination of letters, digits, and underscores (_) up to 1,024 characters, and is case sensitive. The *macroname* can contain an invoked macro. If *macroname* consists entirely of an invoked macro, the macro being invoked cannot be null or undefined.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> can be any sequence of zero or more characters. A null string contains zero characters or only spaces or tabs. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can contain a macro invocation.  
  
## What do you want to know more about?  
 [Special characters in macros](../vs140/special-characters-in-macros.md)  
  
 [Null and undefined macros](../vs140/null-and-undefined-macros.md)  
  
 [Where to define macros](../vs140/where-to-define-macros.md)  
  
 [Precedence in macro definitions](../vs140/precedence-in-macro-definitions.md)  
  
## See Also  
 [Macros and NMAKE](../vs140/macros-and-nmake.md)