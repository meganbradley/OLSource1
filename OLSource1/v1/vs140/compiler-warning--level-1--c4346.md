---
title: "Compiler Warning (level 1) C4346"
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
  - "C4346"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4346"
ms.assetid: 68ee562d-cca9-4a2a-9a1b-14ad1a1e7396
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4346
'name' : dependent name is not a type  
  
 The [typename](../vs140/typename.md) keyword is required if a dependent name is to be treated as a type. This is a breaking change in the Visual C++ .NET 2003 compiler, made in order to conform to the ISO C++ standard.  
  
 For code that works the same in all versions of Visual C++, add <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the declaration.  
  
 The following sample generates C4346:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following samples shows other examples where the **typename** keyword is required:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 and this,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>