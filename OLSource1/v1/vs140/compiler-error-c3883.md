---
title: "Compiler Error C3883"
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
  - "C3883"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3883"
ms.assetid: cdd1c1f4-f268-4469-9c62-d52303114b0c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3883
'var' : an initonly static data member must be initialized  
  
 A variable marked with [initonly](../vs140/initonly--c---cli-.md) was not initialized correctly.  
  
 The following sample generates C3883:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample demonstrates a possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following sample shows how to initialize in a static constructor:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>