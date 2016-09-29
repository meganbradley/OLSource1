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
  
```  
  
macroname=string  
```  
  
## Remarks  
 The *macroname* is a combination of letters, digits, and underscores (_) up to 1,024 characters, and is case sensitive. The *macroname* can contain an invoked macro. If *macroname* consists entirely of an invoked macro, the macro being invoked cannot be null or undefined.  
  
 The `string` can be any sequence of zero or more characters. A null string contains zero characters or only spaces or tabs. The `string` can contain a macro invocation.  
  
## What do you want to know more about?  
 [Special characters in macros](../VS_csharp/special-characters-in-macros.md)  
  
 [Null and undefined macros](../VS_csharp/null-and-undefined-macros.md)  
  
 [Where to define macros](../VS_csharp/where-to-define-macros.md)  
  
 [Precedence in macro definitions](../VS_csharp/precedence-in-macro-definitions.md)  
  
## See Also  
 [Macros and NMAKE](../VS_csharp/macros-and-nmake.md)