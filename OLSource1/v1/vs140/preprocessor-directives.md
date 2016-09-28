---
title: "Preprocessor Directives"
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
  - "C"
helpviewer_keywords: 
  - "directives, preprocessor"
  - "preprocessor, directives"
ms.assetid: e0fc4564-b6cf-4a36-bf51-6ccd7abd0a94
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Preprocessor Directives
Preprocessor directives, such as `#define` and **#ifdef**, are typically used to make source programs easy to change and easy to compile in different execution environments. Directives in the source file tell the preprocessor to perform specific actions. For example, the preprocessor can replace tokens in the text, insert the contents of other files into the source file, or suppress compilation of part of the file by removing sections of text. Preprocessor lines are recognized and carried out before macro expansion. Therefore, if a macro expands into something that looks like a preprocessor command, that command is not recognized by the preprocessor.  
  
 Preprocessor statements use the same character set as source file statements, with the exception that escape sequences are not supported. The character set used in preprocessor statements is the same as the [execution character set](assetId:///a7901c61-524d-47c6-beb6-d9dacc2e72ed). The preprocessor also recognizes negative character values.  
  
 The preprocessor recognizes the following directives:  
  
|||||  
|-|-|-|-|  
|[#define](../vs140/sharpdefine-directive--c-c---.md)|[#error](../vs140/sharperror-directive--c-c---.md)|[#import](../vs140/sharpimport-directive--c---.md)|[#undef](../vs140/sharpundef-directive--c-c---.md)|  
|[#elif](../vs140/sharpif--sharpelif--sharpelse--and-sharpendif-directives--c-c---.md)|[#if](../vs140/sharpif--sharpelif--sharpelse--and-sharpendif-directives--c-c---.md)|[#include](../vs140/sharpinclude-directive--c-c---.md)|[#using](../vs140/sharpusing-directive--c---.md)|  
|[#else](../vs140/sharpif--sharpelif--sharpelse--and-sharpendif-directives--c-c---.md)|[#ifdef](../vs140/sharpifdef-and-sharpifndef-directives--c-c---.md)|[#line](../vs140/sharpline-directive--c-c---.md)|[#endif](../vs140/sharpif--sharpelif--sharpelse--and-sharpendif-directives--c-c---.md)|  
|[#ifndef](../vs140/sharpifdef-and-sharpifndef-directives--c-c---.md)|[#pragma](../vs140/pragma-directives-and-the-__pragma-keyword.md)|||  
  
 The number sign (**#**) must be the first nonwhite-space character on the line containing the directive; white-space characters can appear between the number sign and the first letter of the directive. Some directives include arguments or values. Any text that follows a directive (except an argument or value that is part of the directive) must be preceded by the single-line comment delimiter (**//**) or enclosed in comment delimiters (**/\* \*/**). Lines containing preprocessor directives can be continued by immediately preceding the end-of-line marker with a backslash (**\\**).  
  
 Preprocessor directives can appear anywhere in a source file, but they apply only to the remainder of the source file.  
  
## See Also  
 [Preprocessor Operators](../vs140/preprocessor-operators.md)   
 [Predefined Macros](../vs140/predefined-macros.md)   
 [C/C++ Preprocessor Reference](../vs140/c-c---preprocessor-reference.md)