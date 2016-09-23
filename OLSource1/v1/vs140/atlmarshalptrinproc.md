---
title: "AtlMarshalPtrInProc"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - AtlMarshalPtrInProc
  - ATL.AtlMarshalPtrInProc
  - ATL::AtlMarshalPtrInProc
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlMarshalPtrInProc function
ms.assetid: d6b43d9e-8847-4f84-b003-8b4347074ee0
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlMarshalPtrInProc
Creates a new stream object, writes the CLSID of the proxy to the stream, and marshals the specified interface pointer by writing the data needed to initialize the proxy into the stream.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      HRESULT AtlMarshalPtrInProc(  
IUnknown* pUnk,  
const IID& iid,  
IStream** ppStream   
);  
```  
  
#### Parameters  
 *pUnk*  
 [in] A pointer to the interface to be marshaled.  
  
 `iid`  
 [in] The GUID of the interface being marshaled.  
  
 `ppStream`  
 [out] A pointer to the `IStream` interface on the new stream object used for marshaling.  
  
## Return Value  
 A standard HRESULT value.  
  
## Remarks  
 The **MSHLFLAGS_TABLESTRONG** flag is set so the pointer can be marshaled to multiple streams. The pointer can also be unmarshaled multiple times.  
  
 If marshaling fails, the stream pointer is released.  
  
 `AtlMarshalPtrInProc` can only be used on a pointer to an in-process object.  
  
## Example  
 [!code[NVC_ATL_COM#50](../vs140/codesnippet/CPP/atlmarshalptrinproc_1.cpp)]
  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Marshaling Global Functions](../vs140/marshaling-global-functions.md)   
 [AtlUnmarshalPtr](../vs140/atlunmarshalptr.md)   
 [AtlFreeMarshalStream](../vs140/atlfreemarshalstream.md)   
 [MSHLFLAGS](http://msdn.microsoft.com/library/windows/desktop/ms680759)