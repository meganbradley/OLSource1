---
title: "Compiler Error C3873"
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
  - "C3873"
helpviewer_keywords: 
  - "C3873"
ms.assetid: e68fd3be-2391-492b-ac3f-d2428901b2e9
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3873
'char': this character is not allowed as a first character of an identifier  
  
 The C++ compiler follows the C++11 standard on characters allowed in an identifier. Only certain ranges of characters and universal character names are allowed in an identifier. Additional restrictions apply to the initial character of an identifier. For more information and a list of allowed characters and universal character name ranges, see [Identifiers](../vs140/identifiers--c---.md).  
  
 The range of characters allowed in an identifier is less restrictive when compiling C++/CLI code. Identifiers in code compiled by using /clr should follow  [Standard ECMA-335: Common Language Infrastructure (CLI)](http://www.ecma-international.org/publications/standards/Ecma-335.htm).  
  
 The following sample generates C3873:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>