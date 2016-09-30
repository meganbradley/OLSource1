---
title: "Linker Tools Error LNK1107"
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
  - "LNK1107"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1107"
ms.assetid: a37a893d-5efa-4eba-8f40-6c5518b4b9d0
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1107
invalid or corrupt file: cannot read at location  
  
 The tool could not read the file. Recreate the file.  
  
 LNK1107 could also occur if you attempt to pass a module (.dll or .netmodule extension created with [/clr:noAssembly](../vs140/-clr--common-language-runtime-compilation-.md) or  [/NOASSEMBLY](../vs140/-noassembly--create-a-msil-module-.md)) to the linker; pass the .obj file instead.  
  
 If you compile the following sample:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 and then specify **link LNK1107.dll** on the command line, you will get LNK1107.  To resolve the error, specify **link LNK1107.obj** instead.