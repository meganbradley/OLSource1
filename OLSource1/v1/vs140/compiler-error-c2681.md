---
title: "Compiler Error C2681"
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
  - "C2681"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2681"
ms.assetid: eb42da6d-8d2c-43fd-986b-e73e2b004885
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2681
'type' : invalid expression type for name  
  
 A casting operator tried to convert from an invalid type. For example, if you use the [dynamic_cast](../vs140/dynamic_cast-operator.md) operator to convert an expression to a pointer type, the source expression must be a pointer.  
  
 The following sample generates C2681:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>