---
title: "DECLARE_VIEW_STATUS"
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
  - "DECLARE_VIEW_STATUS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DECLARE_VIEW_STATUS macro"
ms.assetid: 21c27c4b-96d7-4320-a185-c8ce9c7811fc
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DECLARE_VIEW_STATUS
Place this macro in an ATL ActiveX control's control class to specify the **VIEWSTATUS** flags to the container.  
  
## Syntax  
  
```  
  
      DECLARE_VIEW_STATUS(   
   statusFlags    
)  
```  
  
#### Parameters  
 `statusFlags`  
 [in] The **VIEWSTATUS** flags. See [VIEWSTATUS](http://msdn.microsoft.com/library/windows/desktop/ms687201) for a list of flags.  
  
## Example  
 [!code[NVC_ATL_Windowing#126](../vs140/codesnippet/CPP/declare_view_status_1.h)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [Aggregation and Class Factory Macros](../vs140/aggregation-and-class-factory-macros.md)   
 [Macros](../vs140/atl-macros.md)