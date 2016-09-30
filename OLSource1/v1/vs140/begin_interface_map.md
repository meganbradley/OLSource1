---
title: "BEGIN_INTERFACE_MAP"
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
  - "BEGIN_INTERFACE_MAP"
  - "AFXWIN/BEGIN_INTERFACE_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_INTERFACE_MAP macro"
ms.assetid: 963ed8be-66a0-4c5c-8a7e-3388287b1aa4
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_INTERFACE_MAP
Begins the definition of the interfaced map when used in the implementation file.  
  
## Syntax  
  
```  
  
BEGIN_INTERFACE_MAP(  
theClass, baseClass )  
```  
  
#### Parameters  
 `theClass`  
 The class in which the interface map is to be defined  
  
 `baseClass`  
 The class from which `theClass` derives from.  
  
## Remarks  
 For each interface that is implemented, there is one or more `INTERFACE_PART` macro invocations. For each aggregate that the class uses, there is one **INTERFACE_AGGREGATE** macro invocation.  
  
 For more information on interface maps, see [Technical Note 38](../vs140/tn038--mfc-ole-iunknown-implementation.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [END_INTERFACE_MAP](../vs140/end_interface_map.md)   
 [INTERFACE_PART](../vs140/interface_part.md)