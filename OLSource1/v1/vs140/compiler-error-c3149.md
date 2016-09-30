---
title: "Compiler Error C3149"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3149"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3149"
ms.assetid: cf6e2616-2f06-46da-8a8a-d449cb481c51
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3149
'type' : cannot use this type here without a top-level 'char'  
  
 A declaration was not specified correctly.  
  
 For example, you may have defined a CLR type at global scope and tried to create a variable of the type as part of the definition. Because global variables of CLR types are not allowed, the compiler will generate C3149.  
  
 To resolve this error, declare variables of CLR types inside a function or type definition.  
  
 The following sample generates C3149:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3149:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Managed Extensions for C++**  
  
 A managed object was not used correctly.  
  
 The following sample generates C3149:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>