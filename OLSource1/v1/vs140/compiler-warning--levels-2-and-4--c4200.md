---
title: "Compiler Warning (levels 2 and 4) C4200"
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
  - "C4200"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4200"
ms.assetid: e44d6073-937f-42b7-acc1-65e802b475c6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (levels 2 and 4) C4200
nonstandard extension used : zero-sized array in struct/union  
  
 Indicates that a structure or union contains an array that has zero size.  
  
 Declaration of a zero-sized array is a Microsoft extension. This causes a Level-2 warning when a C++ file is compiled and a Level-4 warning when a C file is compiled. C++ compilation also gives this warning: "Cannot generate copy-ctor or copy-assignment operator when UDT contains a zero-sized array." This example generates warning C4200:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This non-standard extension is often used to interface code with external data structures that have a variable length. If this scenario applies to your code, you can disable the warning:  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>