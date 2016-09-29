---
title: "CMFCToolBarImages::Is32BitTransparencySupported"
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
  - "CMFCToolBarImages.Is32BitTransparencySupported"
  - "CMFCToolBarImages::Is32BitTransparencySupported"
  - "Is32BitTransparencySupported"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Is32BitTransparencySupported method"
ms.assetid: bdf71c8c-bbac-43eb-bea9-23f8247c9c2c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::Is32BitTransparencySupported
Specifies whether the operating system supports 32-bit alpha blending.  
  
## Syntax  
  
```  
static BOOL Is32BitTransparencySupported();  
```  
  
## Return Value  
 `TRUE` if 32-bit alpha blending is supported; otherwise `FALSE`.  
  
## Remarks  
 Use this static method to determine at runtime whether the operating system supports 32-bit alpha blending. This feature is supported on [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)] and later versions.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)