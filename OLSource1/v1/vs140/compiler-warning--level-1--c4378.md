---
title: "Compiler Warning (level 1) C4378"
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
  - "C4378"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4378"
ms.assetid: d08e11ef-891a-4752-9a5e-360e7394acf7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4378
Must obtain function pointers to run initializers; consider System::ModuleHandle::ResolveMethodHandle  
  
 Under **/clr**, initializer symbols contain function tokens, not functions pointers.  You need to convert tokens to pointers using \<xref:System.ModuleHandle.ResolveMethodHandle*>.  
  
## Example  
 The following sample generates C4378.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample shows how to resolve C4378.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>