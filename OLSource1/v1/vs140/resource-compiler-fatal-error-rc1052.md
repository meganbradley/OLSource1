---
title: "Resource Compiler Fatal Error RC1052"
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
  - "RC1052"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RC1052"
ms.assetid: 59803673-492b-44fa-80fa-df93b8aaf9fb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Compiler Fatal Error RC1052
compiler limit : #if or #ifdef blocks nested too deeply  
  
 The program exceeded the maximum allowable nesting levels for <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directives.  
  
 This error can be caused by include files that use these preprocessor directives.  
  
 To fix this issue, reduce the number of nested <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directives in your resource file. If the issue is caused by header files that are included in your resource file, reduce the number of nested <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directives in the header files. If this is not possible, consider creating and including a new header file in your resource file, by running the preprocessor on the existing included header files. For more information, see the [/P (Preprocess to a File)](../vs140/-p--preprocess-to-a-file-.md) compiler option.