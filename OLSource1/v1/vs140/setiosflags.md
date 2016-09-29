---
title: "setiosflags"
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
  - "setiosflags"
  - "std::setiosflags"
  - "iomanip/std::setiosflags"
  - "std.setiosflags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setiosflags function"
ms.assetid: 225396ba-bdff-4054-8e58-df78f7a7fd9d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setiosflags
Sets the specified flags.  
  
## Syntax  
  
```  
  
      T2 setiosflags(  
   ios_base::fmtflags _Mask  
);  
```  
  
#### Parameters  
 `_Mask`  
 The flags to set.  
  
## Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**.[setf](../vs140/ios_base--setf.md)(_*Mask*), and then returns **str**.  
  
## Example  
 See [setw](../vs140/setw.md) for an example of using `setiosflags`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)