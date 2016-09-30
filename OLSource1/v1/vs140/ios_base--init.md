---
title: "ios_base::Init"
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
  - "std.ios_base.Init"
  - "Init"
  - "ios_base.Init"
  - "std::ios_base::Init"
  - "ios_base::Init"
  - "ios/std::ios_base::Init"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Init method"
ms.assetid: f78b9732-f3f9-4c28-a6fa-f214c14d7e24
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::Init
Creates the standard iostream objects when constructed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The nested class describes an object whose construction ensures that the standard iostreams objects are properly constructed, even before the execution of a constructor for an arbitrary static object.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)