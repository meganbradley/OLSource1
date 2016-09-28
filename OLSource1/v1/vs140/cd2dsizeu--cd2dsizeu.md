---
title: "CD2DSizeU::CD2DSizeU"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CD2DSizeU"
  - "afxrendertarget/CD2DSizeU::CD2DSizeU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DSizeU class, constructor"
ms.assetid: 5720756f-edd2-4395-b953-47704c82b3b5
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DSizeU::CD2DSizeU
Constructs a CD2DSizeU object from CSize object.  
  
## Syntax  
  
```  
CD2DSizeU(  
   const CSize& size  
);  
CD2DSizeU(  
   const D2D1_SIZE_U& size  
);  
CD2DSizeU(  
   const D2D1_SIZE_U* size  
);  
CD2DSizeU(  
   UINT32 cx = 0,  
   UINT32 cy = 0  
);  
```  
  
#### Parameters  
 `size`  
 source size  
  
 `cx`  
 source width  
  
 `cy`  
 source height  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DSizeU Class](../vs140/cd2dsizeu-class.md)