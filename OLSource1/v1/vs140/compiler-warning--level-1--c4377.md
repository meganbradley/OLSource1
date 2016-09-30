---
title: "Compiler Warning (level 1) C4377"
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
  - "C4377"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4377"
ms.assetid: a1c797b8-cd5e-4a56-b430-d07932e811cf
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4377
native types are private by default; -d1PrivateNativeTypes is deprecated  
  
 In previous releases, native types in assemblies were public by default, and an internal, undocumented compiler option (**/d1PrivateNativeTypes**) was used to make them private.  
  
 All types, native and CLR, are now private by default in an assembly, so **/d1PrivateNativeTypes** is no longer needed.  
  
## Example  
 The following sample generates C4377.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>