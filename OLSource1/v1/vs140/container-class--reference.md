---
title: "Container Class::reference"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - reference method
ms.assetid: ab85a9fb-c628-4761-9a5f-a0231fad7690
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Container Class::reference
> [!NOTE]
>  This topic is in the Visual C++ documentation as a nonfunctional example of containers used in the Standard C++ Library. For more information, see [STL Containers](../vs140/stl-containers.md).  
  
 Describes an object that can serve as a reference to an element of the controlled sequence.  
  
## Syntax  
  
```  
  
typedef T2 reference;  
  
```  
  
## Remarks  
 It is described here as a synonym for the unspecified type **T2** (typically **Alloc::reference**). An object of type **reference** can be cast to an object of type [const_reference](../vs140/container-class--const_reference.md).  
  
## See Also  
 [Sample Container Class](../vs140/sample-container-class.md)