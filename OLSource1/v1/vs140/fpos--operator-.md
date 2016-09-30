---
title: "fpos::operator-"
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
  - "fpos::operator-"
  - "-"
  - "operator-"
  - "fpos.operator-"
  - "std.fpos.operator-"
  - "std::fpos::operator-"
  - "iosfwd/std::fpos::operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-"
  - "- operator"
  - "- operator, with specific objects"
ms.assetid: c640f7a5-0e5a-421f-aa3b-d88d9e86d8fc
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# fpos::operator-
Decrements a file-position indicator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 File position.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Stream offset.  
  
## Return Value  
 The first member function returns **(streamoff)\*this - (streamoff)**<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The second member function returns **fpos(\*this) -=** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 See [operator!=](../vs140/fpos--operator!=.md) for a sample of using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [fpos Class](../vs140/fpos-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)