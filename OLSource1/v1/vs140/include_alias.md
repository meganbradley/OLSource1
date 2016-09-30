---
title: "include_alias"
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
  - "vc-pragma.include_alias"
  - "include_alias_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pragmas, include_alias"
  - "include_alias pragma"
ms.assetid: 3256d589-12b3-4af0-a586-199e96eabacc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# include_alias
Specifies that *short_filename* is to be used as an alias for *long_filename*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Some file systems allow longer header filenames than the 8.3 FAT file system limit. The compiler cannot simply truncate the longer names to 8.3, because the first eight characters of the longer header filenames may not be unique. Whenever the compiler encounters the *long_filename* string, it substitutes *short_filename*, and looks for the header file *short_filename* instead. This pragma must appear before the corresponding <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directives. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The alias being searched for must match the specification exactly, in case as well as in spelling and in use of double quotation marks or angle brackets. The **include_alias** pragma performs simple string matching on the filenames; no other filename validation is performed. For example, given the following directives,  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 no aliasing (substitution) is performed, since the header file strings do not match exactly. Also, header filenames used as arguments to the /Yu and /Yc compiler options, or the **hdrstop** pragma, are not substituted. For example, if your source file contains the following directive,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 the corresponding compiler option should be  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You can use the **include_alias** pragma to map any header filename to another. For example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Do not mix filenames enclosed in double quotation marks with filenames enclosed in angle brackets. For example, given the above two **#pragma include_alias** directives, the compiler performs no substitution on the following <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directives:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Furthermore, the following directive generates an error:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Note that the filename reported in error messages, or as the value of the predefined **__FILE\_\_** macro, is the name of the file after the substitution has been performed. For example, after the following directives,  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 an error in VERYLONGFILENAME.H produces the following error message:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Also note that transitivity is not supported. Given the following directives,  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 the compiler searches for the file TWO.H rather than THREE.H.  
  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)