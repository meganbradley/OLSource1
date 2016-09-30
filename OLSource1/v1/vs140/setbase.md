---
title: "setbase"
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
  - "std.setbase"
  - "iomanip/std::setbase"
  - "SetBase"
  - "std::setbase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setbase function"
ms.assetid: 9bd714ff-c27d-46e6-a238-26ea144c0a08
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setbase
Set base for integers.  
  
## Syntax  
  
```  
  
      T3 setbase(  
   int _Base  
);  
```  
  
#### Parameters  
 `_Base`  
 The number base.  
  
## Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**.`setf`(**mask**, [ios_base::basefield](../vs140/ios_base--fmtflags.md)), and then returns **str**. Here, **mask** is determined as follows:  
  
-   If _*Base* is 8, then **mask** is `ios_base::`[oct](../vs140/oct---ios--.md).  
  
-   If _*Base* is 10, then mask is `ios_base::`[dec](../vs140/dec.md).  
  
-   If _*Base* is 16, then **mask** is `ios_base::`[hex](../vs140/hex.md).  
  
-   If _*Base* is any other value, then mask is `ios_base::`[fmtflags](../vs140/ios_base--fmtflags.md)(0).  
  
## Example  
 See [setw](../vs140/setw.md) for an example of using `setbase`.  
  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)