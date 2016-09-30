---
title: "AtlUnadvise"
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
  - "ATL::AtlUnadvise"
  - "ATL.AtlUnadvise"
  - "AtlUnadvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlUnadvise function"
ms.assetid: 939d2e50-e2df-4e8f-a16a-e9650b8f0340
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlUnadvise
Terminates the connection established through [AtlAdvise](../vs140/atladvise.md).  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the **IUnknown** of the object that the client is connected with.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The GUID of the connection point. Typically, this is the same as the outgoing interface managed by the connection point.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The cookie that uniquely identifies the connection.  
  
## Return Value  
 A standard HRESULT value.  
  
## Example  
 [!code[NVC_ATL_Windowing#96](../vs140/codesnippet/CPP/atlunadvise_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Connection Point Global Functions](../vs140/connection-point-global-functions.md)