---
title: "Compiler Warning C4958"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4958"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4958"
ms.assetid: e79b9e9c-d572-4a3a-a3b6-60962b70864a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4958
'operation' : pointer arithmetic is not verifiable  
  
 Using pointer arithmetic will produce an unverifiable image.  
  
 For more information, see [Pure / Verifiable](../vs140/pure-and-verifiable-code--c---cli-.md).  
  
 This warning is issued as an error and can be disabled with the [warning](../vs140/warning.md) pragma or the [/wd](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) compiler option.  
  
 The following sample generates C4958:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The compiler implements array operations with pointer arithmetic. Therefore, native arrays are not verifiable; use a CLR array instead. For more information, see [array](../vs140/arrays--c---component-extensions-.md).  
  
 The following sample generates C4958:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>