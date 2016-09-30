---
title: "nounitbuf"
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
  - "std::nounitbuf"
  - "ios/std::nounitbuf"
  - "std.nounitbuf"
  - "nounitbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nounitbuf"
  - "nounitbuf function"
ms.assetid: cb4718e7-cc8b-4887-9443-f844825f1c14
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nounitbuf
Causes output to be buffered and processed on when the buffer is full.  
  
## Syntax  
  
```  
  
      ios  
      _  
      base& nounitbuf(  
   ios_base& _Str  
);  
```  
  
#### Parameters  
 `_Str`  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from `ios_base`.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 [unitbuf](../vs140/unitbuf.md) causes the buffer to be processed when it is not empty.  
  
 The manipulator effectively calls `_Str.`[unsetf](../vs140/ios_base--unsetf.md)(`ios_base::unitbuf`), and then returns `_Str`.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)