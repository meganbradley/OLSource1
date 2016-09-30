---
title: "Compiler Error C3744"
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
  - "C3744"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3744"
ms.assetid: a447d050-80d1-406a-9a6e-f15c527d717c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3744
__unhook must have at least 3 arguments for managed events  
  
 The [__unhook](../vs140/__unhook.md) function must take three parameters when used in a program that is compiled for Managed Extensions for C++.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are not compatible with /clr programming. Use the += and -= operators instead.  
  
 C3744 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3744:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>