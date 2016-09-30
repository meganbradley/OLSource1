---
title: "Compiler Warning (level 4) C4256"
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
  - "C4256"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4256"
ms.assetid: a755a32e-895a-4837-a2b5-4ea06b736798
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4256
'function' : constructor for class with virtual bases has '...'; calls may not be compatible with older versions of Visual C++  
  
 Possible incompatibility.  
  
 Consider the following code example. If the definition of the constructor S2::S2( int i, ... ) was compiled by using a version of the Visual C++ compiler before version 7, but the following example is compiled by using the current version, the call to the constructor for S3 would not work correctly because of a special-case calling-convention change. If both were compiled by using Visual C++ 6.0, the call would not work quite right either, unless no parameters were passed for the ellipsis.  
  
 To fix this warning,  
  
1.  Don't use ellipsis in a constructor.  
  
2.  Make sure that all components in their project are built with the current version (including any libraries that may define or reference this class), then disable the warning using the [warning](../vs140/warning.md) pragma.  
  
 The following sample generates C4256:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>