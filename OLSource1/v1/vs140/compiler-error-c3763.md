---
title: "Compiler Error C3763"
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
  - "C3763"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3763"
ms.assetid: 58b1f079-cd1d-46e0-9431-ea18210106b7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3763
'type': 'retval' and 'out' can only appear on a data-pointer type  
  
 The [out](../vs140/out--c---.md) or [retval](../vs140/retval.md) attributes can only appear on parameters of type pointer. Either remove the attribute or make the parameter of type pointer.  
  
 The following sample generates C3763:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>