---
title: "Compiler Error C3166"
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
  - "C3166"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3166"
ms.assetid: ec3e330d-c15d-4158-8268-09101486c566
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3166
'pointer' : cannot declare a pointer to an interior __gc pointer as a member of 'type'  
  
 The compiler found an invalid pointer declaration (a [__nogc](../vs140/__nogc.md) pointer to a [__gc](../vs140/__gc.md) pointer.). This syntax may be supported in a future release.  
  
 C3166 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3166:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>