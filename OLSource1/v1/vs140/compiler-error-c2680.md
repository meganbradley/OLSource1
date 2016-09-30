---
title: "Compiler Error C2680"
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
  - "C2680"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2680"
ms.assetid: d6f7129e-dd17-4661-b680-18d6b925b1cc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2680
'type' : invalid target type for name  
  
 A casting operator tried to convert to a type that is not a pointer or reference. The [dynamic_cast](../vs140/dynamic_cast-operator.md) operator can be used only for pointers or references.  
  
 The following sample generates C2680:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2680 can also occur when the target is not defined:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>