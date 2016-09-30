---
title: "Compiler Error C2341"
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
  - "C2341"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2341"
ms.assetid: aa2a7da5-e1c8-4225-9939-5bdc50158f31
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2341
'section name' : segment must be defined using #pragma data_seg, code_seg or section prior to use  
  
 An [allocate](../vs140/allocate.md) statement refers to a segment not yet defined by [code_seg](../vs140/code_seg.md), [data_seg](../vs140/data_seg.md), or [section](../vs140/section.md) pragmas.  
  
 The following sample generates C2341:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>