---
title: "AtlFreeMarshalStream"
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
  - ATL::AtlFreeMarshalStream
  - ATL.AtlFreeMarshalStream
  - AtlFreeMarshalStream
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlFreeMarshalStream function
ms.assetid: dce192eb-dd0f-4103-a22f-e1337c9d913b
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlFreeMarshalStream
Releases the marshal data in the stream, then releases the stream pointer.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      HRESULT AtlFreeMarshalStream(  
IStream* pStream   
);  
```  
  
#### Parameters  
 `pStream`  
 [in] A pointer to the `IStream` interface on the stream used for marshaling.  
  
## Example  
 See the example for [AtlMarshalPtrInProc](../vs140/atlmarshalptrinproc.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Marshaling Global Functions](../vs140/marshaling-global-functions.md)   
 [AtlMarshalPtrInProc](../vs140/atlmarshalptrinproc.md)