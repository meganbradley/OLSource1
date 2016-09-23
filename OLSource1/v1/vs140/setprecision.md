---
title: "setprecision"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - setprecision
  - iomanip/std::setprecision
  - std.setprecision
  - std::setprecision
dev_langs: 
  - C++
helpviewer_keywords: 
  - setprecision function
ms.assetid: 4a8f9236-8715-4e71-80ac-5e0596cff55f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# setprecision
Sets the precision for floating-point values.  
  
## Syntax  
  
```  
  
      T5 setprecision(  
   streamsize _Prec  
);  
```  
  
#### Parameters  
 `_Prec`  
 The precision for floating-point values.  
  
## Return Value  
 The manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**.[precision](../vs140/ios_base--precision.md)(`_Prec`), and then returns **str**.  
  
## Example  
 See [setw](../vs140/setw.md) for an example of using `setprecision`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)