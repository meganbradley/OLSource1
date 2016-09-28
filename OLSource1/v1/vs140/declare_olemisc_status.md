---
title: "DECLARE_OLEMISC_STATUS"
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
  - "DECLARE_OLEMISC_STATUS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_OLEMISC_STATUS macro"
ms.assetid: bcd80ae6-2ed3-4338-9ab1-4f0952e3dedb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_OLEMISC_STATUS
Used in ATL ActiveX controls to set the OLEMISC flags.  
  
## Syntax  
  
```  
  
      DECLARE_OLEMISC_STATUS(   
   miscstatus    
)  
```  
  
#### Parameters  
 *miscstatus*  
 All applicable OLEMISC flags.  
  
## Remarks  
 This macro is used to set the OLEMISC flags for an ActiveX control. Refer to [IOleObject::GetMiscStatus](http://msdn.microsoft.com/library/windows/desktop/ms678521) for more details.  
  
## Example  
 [!code[NVC_ATL_Windowing#124](../vs140/codesnippet/CPP/declare_olemisc_status_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Object Status Macros](../vs140/object-status-macros.md)   
 [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497)