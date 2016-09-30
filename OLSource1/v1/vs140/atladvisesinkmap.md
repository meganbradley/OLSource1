---
title: "AtlAdviseSinkMap"
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
  - "ATL::AtlAdviseSinkMap"
  - "AtlAdviseSinkMap"
  - "ATL.AtlAdviseSinkMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAdviseSinkMap function"
ms.assetid: 0757a6af-3de3-4179-8b4f-ccd137d919b4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAdviseSinkMap
Call this function to advise or unadvise all entries in the object's sink event map.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pT*  
 [in] A pointer to the object containing the sink map.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] **true** if all sink entries are to be advised; **false** if all sink entries are to be unadvised.  
  
## Return Value  
 A standard HRESULT value.  
  
## Example  
 [!code[NVC_ATL_Windowing#92](../vs140/codesnippet/CPP/atladvisesinkmap_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Connection Point Global Functions](../vs140/connection-point-global-functions.md)