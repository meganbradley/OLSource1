---
title: "AtlAxGetHost"
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
  - "AtlAxGetHost"
  - "ATL.AtlAxGetHost"
  - "ATL::AtlAxGetHost"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxGetHost function"
ms.assetid: ad1f4f16-608d-4e96-8d30-04d4ca906a7b
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxGetHost
Obtains a direct interface pointer to the container for a specified window (if any), given its handle.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI AtlAxGetHost(  
HWND h,  
IUnknown** pp   
);  
```  
  
#### Parameters  
 `h`  
 [in] A handle to the window that is hosting the control.  
  
 `pp`  
 [out] The **IUnknown** of the container of the control.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)