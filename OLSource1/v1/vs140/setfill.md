---
title: "setfill"
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
  - "iomanip/std::setfill"
  - "std::setfill"
  - "std.setfill"
  - "setfill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "setfill function"
ms.assetid: 83980ceb-6801-4195-b664-b2f66a041389
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setfill
Sets the character that will be used to fill spaces in a right-justified display.  
  
## Syntax  
  
```  
  
   template<class Elem>  
T4 setfill(  
   Elem _Ch  
);  
```  
  
#### Parameters  
 `_Ch`  
 The character that will be used to fill spaces in a right-justified display.  
  
## Return Value  
 The template manipulator returns an object that, when extracted from or inserted into the stream **str**, calls **str**.[fill](../vs140/basic_ios--fill.md)(`_Ch`), and then returns **str**. The type **Elem** must be the same as the element type for the stream **str**.  
  
## Example  
 See [setw](../vs140/setw.md) for an example of using `setfill`.  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)