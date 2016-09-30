---
title: "&lt;ccomplex&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "<ccomplex>"
dev_langs: 
  - "C++"
ms.assetid: a9fcb5f0-88e3-464b-a5fd-d1afb8cd7e6f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ccomplex&gt;
Includes the STL header [\<complex>](../vs140/-complex-.md), which effectively includes the Standard C library header \<complex.h> and adds the associated names to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> namespace.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Including this header ensures that the names declared using external linkage in the Standard C library header are declared in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> namespace.  
  
 The name <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which is declared in \<complex.h>, is not defined in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace because of potential conflicts with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that is declared in [\<iostream>](../vs140/-iostream-.md).  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Standard C++ Library Overview](../vs140/c---standard-library-overview.md)