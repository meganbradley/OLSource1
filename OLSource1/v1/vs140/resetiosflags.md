---
title: "resetiosflags"
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
  - "resetiosflags"
  - "std::resetiosflags"
  - "iomanip/std::resetiosflags"
  - "std.resetiosflags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resetiosflags function"
ms.assetid: 9da1c8ad-be19-4c93-82d4-2bf3c2f4fa25
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# resetiosflags
Clears the specified flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The flags to clear.  
  
## Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**.[setf](../vs140/ios_base--setf.md)(<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[fmtflags](../vs140/ios_base--fmtflags.md), _*Mask*), and then returns **str**.  
  
## Example  
 See [setw](../vs140/setw.md) for an example of using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)