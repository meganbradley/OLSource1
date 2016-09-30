---
title: "Linker Tools Error LNK1179"
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
  - "LNK1179"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK1179"
ms.assetid: 4b1536d7-0d3d-4f29-a9c1-6fa5cf6cb665
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Error LNK1179
invalid or corrupt file: duplicate COMDAT 'filename'  
  
 An object module contains two or more COMDATs with the same name.  
  
 This error can be caused by using [/H](../vs140/-h--restrict-length-of-external-names-.md), which limits the length of external names, and [/Gy](../vs140/-gy--enable-function-level-linking-.md), which packages functions in COMDATs.  
  
## Example  
 In the following code, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are identical in the first eight characters. Compiling with **/Gy** and **/H8** produces a link error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>