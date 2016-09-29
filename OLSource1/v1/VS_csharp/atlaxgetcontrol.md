---
title: "AtlAxGetControl"
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
  - "ATL::AtlAxGetControl"
  - "AtlAxGetControl"
  - "ATL.AtlAxGetControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxGetControl function"
ms.assetid: 40ac5fe9-3e04-41c2-b1ef-a17832fbaaad
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxGetControl
Obtains a direct interface pointer to the control contained inside a specified window given its handle.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI AtlAxGetControl(  
HWND h,  
IUnknown** pp   
);  
```  
  
#### Parameters  
 `h`  
 [in] A handle to the window that is hosting the control.  
  
 `pp`  
 [out] The **IUnknown** of the control being hosted.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../VS_csharp/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../VS_csharp/atl-composite-control-fundamentals.md)