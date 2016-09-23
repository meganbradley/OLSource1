---
title: "IAtlAutoThreadModule Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - IAtlAutoThreadModule
dev_langs: 
  - C++
helpviewer_keywords: 
  - IAtlAutoThreadModule class
ms.assetid: fcb58cf9-a427-4be9-89eb-04e1ab5cc3a1
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IAtlAutoThreadModule Class
This class represents an interface to a `CreateInstance` method.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
__interface IAtlAutoThreadModule  
  
```  
  
## Remarks  
 The class [CAtlAutoThreadModuleT](../vs140/catlautothreadmodulet-class.md) derives from `IAtlAutoThreadModule`, using it to provide code for creating an object and retrieving an interface pointer.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)