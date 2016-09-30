---
title: "Compiler Warning (level 2) C4356"
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
  - "C4356"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4356"
ms.assetid: 3af3defe-de33-43b6-bd6c-2c2e09e34f3f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) C4356
'member' : static data member cannot be initialized via derived class  
  
 The initialization of a static data member was ill formed. The compiler accepted the initialization.  
  
 This is a breaking change in the Visual C++ .NET 2003 compiler.  
  
 For code that works the same in all versions of Visual C++, initialize the member through the base class.  
  
 Use the [warning](../vs140/warning.md) pragma to suppress this warning.  
  
 The following sample generates C4356:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>