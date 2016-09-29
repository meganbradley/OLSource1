---
title: "&lt;ios&gt; defaultfloat"
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
  - "defaultfloat"
  - "ios/std::defaultfloat"
  - "std.defaultfloat"
  - "std::defaultfloat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "defaultfloat function"
ms.assetid: 2c1dc533-63c1-4108-a13a-e5fa688e6024
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ios&gt; defaultfloat
Configures the flags of an `ios_base` object to use a default display format for float values.  
  
## Syntax  
  
```  
ios_base& defaultfloat(  
    ios_base& _Iosbase  
);  
```  
  
#### Parameters  
 `_Iosbase`  
 An `ios_base` object.  
  
## Property Value/Return Value  
 Returns the configured `ios_base` object.  
  
## Exceptions  
  
## Remarks  
 The manipulator effectively calls _I`osbase.`[unsetf](../vs140/ios_base--unsetf.md)`(ios_base::floatfield)`, then returns _I`osbase`.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [\<ios>](../vs140/-ios-.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)