---
title: "Compiler Error C2027"
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
  - "C2027"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2027"
ms.assetid: a39150c0-ec04-45ec-934c-a838bfe76627
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2027
use of undefined type 'type'  
  
 A type cannot be used until it is defined. To resolve the error, be sure the type is fully defined before referencing it.  
  
## Example  
 The following sample generates C2027.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 It is possible to declare a pointer to a declared but undefined type.  But Visual C++ does not allow a reference to an undefined type.  
  
 The following sample generates C2027.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>