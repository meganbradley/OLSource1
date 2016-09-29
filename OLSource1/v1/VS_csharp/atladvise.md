---
title: "AtlAdvise"
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
  - "AtlAdvise"
  - "ATL::AtlAdvise"
  - "ATL.AtlAdvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAdvise function"
ms.assetid: 625a2f03-6b7f-4761-be5d-d2871d1d3254
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAdvise
Creates a connection between an object's connection point and a client's sink.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      HRESULT AtlAdvise(  
IUnknown* pUnkCP,  
IUnknown* pUnk,  
const IID& iid,  
LPDWORD pdw   
);  
```  
  
#### Parameters  
 `pUnkCP`  
 [in] A pointer to the **IUnknown** of the object the client wants to connect with.  
  
 *pUnk*  
 [in] A pointer to the client's **IUnknown**.  
  
 `iid`  
 [in] The GUID of the connection point. Typically, this is the same as the outgoing interface managed by the connection point.  
  
 `pdw`  
 [out] A pointer to the cookie that uniquely identifies the connection.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 The sink implements the outgoing interface supported by the connection point. The client uses the `pdw` cookie to remove the connection by passing it to [AtlUnadvise](../VS_csharp/atlunadvise.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#91](../VS_csharp/codesnippet/CPP/atladvise_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Connection Point Global Functions](../VS_csharp/connection-point-global-functions.md)