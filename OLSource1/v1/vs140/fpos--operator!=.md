---
title: "fpos::operator!="
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
  - "fpos.operator!="
  - "iosfwd/std::fpos::operator!="
  - "fpos::operator!="
  - "!="
  - "std::fpos::operator!="
  - "std.fpos.operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator!=, file position"
  - "!= operator"
  - "operator !=, file position"
ms.assetid: 451d908a-7a10-487d-9e20-7ffb431e3736
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fpos::operator!=
Tests file-position indicators for inequality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The file-position indicator against which to compare.  
  
## Return Value  
 **true** if the file-position indicators are not equal, otherwise **false**.  
  
## Remarks  
 The member function returns **!**(**\*this ==** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: fpos_op_neq.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)