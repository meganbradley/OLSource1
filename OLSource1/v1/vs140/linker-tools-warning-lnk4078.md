---
title: "Linker Tools Warning LNK4078"
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
  - "LNK4078"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LNK4078"
ms.assetid: 5a16796d-6caf-42d9-8f65-b042843eafb8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Linker Tools Warning LNK4078
multiple 'section name' sections found with different attributes  
  
 LINK found two or more sections that have the same name but different attributes.  
  
 This warning can be caused by an import library or exports file that was created by a previous version of LINK or LIB.  
  
 Recreate the file and relink.  
  
## Example  
 LNK4078 can also be caused by a breaking change: the section named by [init_seg](../vs140/init_seg.md) on x86 was read/write, it is now read only.  
  
 The following sample generates LNK4078.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>