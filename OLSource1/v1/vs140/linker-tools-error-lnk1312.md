---
title: "Linker Tools Error LNK1312"
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
  - "LNK1312"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1312"
ms.assetid: 48284abb-d849-43fc-ab53-45aded14fd8a
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1312
invalid or corrupt file: unable to import assembly  
  
 When building an assembly, a file other than a module or assembly compiled with **/clr** was passed to the **/ASSEMBLYMODULE** linker option.  If you passed an object file to **/ASSEMBLYMODULE**, just pass the object directly to the linker, instead of to **/ASSEMBLYMODULE**.  
  
## Example  
 The following sample created the .obj file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates LNK1312.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>