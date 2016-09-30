---
title: "Compiler Error C2697"
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
  - "C2697"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2697"
ms.assetid: 0f55b263-4fe0-410c-8e6a-a0943bc61ff4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2697
'array' : must explicitly specify __gc or \__nogc for an array declared in a managed type  
  
 This error indicates that an array was not explicitly marked as unmanaged or managed in a [__gc](../vs140/__gc.md) class.  
  
 C2697 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C2697:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>