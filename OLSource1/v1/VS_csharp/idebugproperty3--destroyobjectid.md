---
title: "IDebugProperty3::DestroyObjectID"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugProperty3::DestroyObjectID"
helpviewer_keywords: 
  - "IDebugProperty3::DestroyObjectID"
ms.assetid: bd08f356-cc67-4717-98c9-c3d00cad2040
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty3::DestroyObjectID
Destroys the unique ID associated with this property, indicating that the caller no longer cares to identify this property uniquely from all other properties.  
  
## Syntax  
  
```cpp  
HRESULT DestroyObjectID(  
   void  
);  
```  
  
```c#  
int DestroyObjectID();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 If the debug engine doesn't need to support unique IDs for a property (because it already tracks them uniquely internally), then it can simply return `E_NOTIMPL` for this method.  
  
 Unique IDs are created with a call to the [IDebugProperty3::CreateObjectID](../VS_csharp/idebugproperty3--createobjectid.md) method when the caller wants to make sure that this property is uniquely identified among all other properties.  
  
## See Also  
 [IDebugProperty3](../VS_csharp/idebugproperty3.md)   
 [IDebugProperty3::CreateObjectID](../VS_csharp/idebugproperty3--createobjectid.md)