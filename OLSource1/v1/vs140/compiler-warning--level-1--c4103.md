---
title: "Compiler Warning (level 1) C4103"
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
  - "C4103"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4103"
ms.assetid: 9021b514-375e-4d62-b261-ccb06f299e8e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4103
'filename' : alignment changed after including header, may be due to missing #pragma pack(pop)  
  
 Packing affects the layout of classes, and commonly, if packing changes across header files, there can be problems.  
  
 Use #pragma [pack](../vs140/pack.md)(pop) before exiting the header file to resolve this warning.  
  
 The following sample generates C4103:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 And then,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>