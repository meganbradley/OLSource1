---
title: "Compiler Error C2477"
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
  - "C2477"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2477"
ms.assetid: 60bc324b-6605-4833-8099-a291efc712e7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2477
'member' : static data member cannot be initialized via derived class  
  
 A static data member of a template class was initialized incorrectly. This is a breaking change with versions of the Visual C++ compiler prior to Visual Studio .NET 2003, in order to conform to the ISO C++ standard.  
  
 The following sample generates C2477:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>