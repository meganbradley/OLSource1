---
title: "ios_base::flags"
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
  - "std.ios_base.flags"
  - "ios_base::flags"
  - "std::ios_base::flags"
  - "xiosbase/std::ios_base::flags"
  - "flags"
  - "ios_base.flags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "flags method"
ms.assetid: 40efc25d-1b5f-46b8-a134-f3350cff8233
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::flags
Sets or returns the current flag settings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> setting.  
  
## Return Value  
 The previous or current <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> setting.  
  
## Remarks  
 See [ios_base::fmtflags](../vs140/ios_base--fmtflags.md) for a list of the flags.  
  
 The first member function returns the stored format flags. The second member function stores <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the format flags and returns its previous stored value.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **513**  
**16896**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)