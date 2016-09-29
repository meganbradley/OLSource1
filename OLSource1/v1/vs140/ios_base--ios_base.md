---
title: "ios_base::ios_base"
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
  - "ios_base"
  - "std::ios_base::ios_base"
  - "std.ios_base.ios_base"
  - "ios_base.ios_base"
  - "xiosbase/std::ios_base::ios_base"
  - "ios_base::ios_base"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ios_base method"
  - "ios_base class, constructor"
ms.assetid: 0c33c52e-a94d-4c91-a1f2-964a7ba30592
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::ios_base
Constructs ios_base objects.  
  
## Syntax  
  
```  
  
ios  
_  
base( );  
  
```  
  
## Remarks  
 The (protected) constructor does nothing. A later call to **basic_ios::**[init](../vs140/basic_ios--init.md) must initialize the object before it can be safely destroyed. Thus, the only safe use for class ios_base is as a base class for template class [basic_ios](../vs140/basic_ios-class.md).  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)