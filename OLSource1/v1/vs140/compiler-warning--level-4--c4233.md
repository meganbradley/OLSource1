---
title: "Compiler Warning (level 4) C4233"
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
  - "C4233"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4233"
ms.assetid: 9aa51fc6-8ef3-43b5-bafb-c9333cf60de3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4233
nonstandard extension used : 'keyword' keyword only supported in C++, not C  
  
 The compiler compiled your source code as C rather than C++, and you used a keyword that is only valid in C++. The compiler compiles your source file as C if the extension of the source file is .c or you use [/Tc](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md).  
  
 This warning is automatically promoted to an error. If you wish to modify this behavior, use [#pragma warning](../vs140/warning.md). For example, to make C4233 into a level 4 warning issue,  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 in your source code file.