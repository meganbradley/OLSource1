---
title: "-SYMBOLS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/SYMBOLS"
f1_keywords: 
  - "/symbols"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "symbols, dumping"
  - "public symbols"
  - "symbols, displaying COFF symbol table"
  - "symbol tables"
  - "SYMBOLS dumpbin option"
  - "/SYMBOLS dumpbin option"
  - "-SYMBOLS dumpbin option"
ms.assetid: 34bcae90-4561-4c77-a80c-065508dec39a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -SYMBOLS
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This option displays the COFF symbol table. Symbol tables exist in all object files. A COFF symbol table appears in an image file only if it is linked with /DEBUG.  
  
 The following is a description of the output for /SYMBOLS. Additional information on the meaning of /SYMBOLS output can be found by looking in winnt.h (IMAGE_SYMBOL and IMAGE_AUX_SYMBOL), or COFF documentation.  
  
 Given the following sample dump:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 The following description, for lines that begin with a symbol number, describes columns that have information relevant to users:  
  
-   The first three-digit number is the symbol index/number.  
  
-   If the third column contains SECT*x*, the symbol is defined in that section of the object file. But if UNDEF appears, it is not defined in that object and must be resolved elsewhere.  
  
-   The fifth column (Static, External) tells whether the symbol is visible only within that object, or whether it is public (visible externally). A Static symbol, _sym, wouldn't be linked to a Public symbol _sym; these would be two different instances of functions named _sym.  
  
 The last column in a numbered line is the symbol name, both decorated and undecorated.  
  
 Only the [/HEADERS](../vs140/-headers.md) DUMPBIN option is available for use on files produced with the [/GL](../vs140/-gl--whole-program-optimization-.md) compiler option.  
  
## See Also  
 [DUMPBIN Options](../vs140/dumpbin-options.md)