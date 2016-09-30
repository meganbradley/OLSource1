---
title: "#ifdef and #ifndef Directives (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "#ifdef and #ifndef Directives (C/C++)"
f1_keywords: 
  - "#ifndef"
  - "#ifdef"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "#ifdef directive"
  - "preprocessor, directives"
  - "ifdef directive (#ifdef)"
  - "ifndef directive (#ifndef)"
  - "#ifndef directive"
ms.assetid: 2b0be69d-9e72-45d8-8e24-e4130fb2455b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# #ifdef and #ifndef Directives (C-C++)
The **#ifdef** and **#ifndef** directives perform the same task as the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive when it is used with **defined**( *identifier* ).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can use the **#ifdef** and **#ifndef** directives anywhere <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be used. The **#ifdef** *identifier* statement is equivalent to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when *identifier* has been defined, and it is equivalent to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when *identifier* has not been defined or has been undefined with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive. These directives check only for the presence or absence of identifiers defined with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, not for identifiers declared in the C or C++ source code.  
  
 These directives are provided only for compatibility with previous versions of the language. The **defined(** *identifier* **)** constant expression used with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive is preferred.  
  
 The **#ifndef** directive checks for the opposite of the condition checked by **#ifdef**. If the identifier has not been defined (or its definition has been removed with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>), the condition is true (nonzero). Otherwise, the condition is false (0).  
  
 **Microsoft Specific**  
  
 The *identifier* can be passed from the command line using the /D option. Up to 30 macros can be specified with /D.  
  
 This is useful for checking whether a definition exists, because a definition can be passed from the command line. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Preprocessor Directives](../vs140/preprocessor-directives.md)