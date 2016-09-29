---
title: "AtlUnmarshalPtr"
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
  - "AtlUnmarshalPtr"
  - "ATL.AtlUnmarshalPtr"
  - "ATL::AtlUnmarshalPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlUnmarshalPtr function"
ms.assetid: 15d875dc-5132-4f72-a3dc-6640da0b709e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlUnmarshalPtr
Converts the stream's marshaling data into an interface pointer that can be used by the client.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      HRESULT AtlUnmarshalPtr(  
IStream* pStream,  
const IID& iid,  
IUnknown** ppUnk   
);  
```  
  
#### Parameters  
 `pStream`  
 [in] A pointer to the stream being unmarshaled.  
  
 `iid`  
 [in] The GUID of the interface being unmarshaled.  
  
 `ppUnk`  
 [out] A pointer to the unmarshaled interface.  
  
## Return Value  
 A standard HRESULT value.  
  
## Example  
 See the example for [AtlMarshalPtrInProc](../vs140/atlmarshalptrinproc.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Marshaling Global Functions](../vs140/marshaling-global-functions.md)   
 [AtlMarshalPtrInProc](../vs140/atlmarshalptrinproc.md)