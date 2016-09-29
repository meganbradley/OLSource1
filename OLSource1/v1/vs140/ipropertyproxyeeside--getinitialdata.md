---
title: "IPropertyProxyEESide::GetInitialData"
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
  - "IPropertyProxyEESide::GetInitialData"
helpviewer_keywords: 
  - "IPropertyProxyEESide::GetInitialData"
ms.assetid: 36cceb19-2604-4ef9-b42b-5dd30cbe24b1
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IPropertyProxyEESide::GetInitialData
Returns the initial data for this object.  
  
## Syntax  
  
```cpp#  
HRESULT GetInitialData(  
   IEEDataStorage** dataOut  
);  
```  
  
```c#  
int GetInitialData(  
   out IEEDataStorage dataOut  
);  
```  
  
#### Parameters  
 `dataOut`  
 [out] Returns an [IEEDataStorage](../vs140/ieedatastorage.md) object containing the initial data of this object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md)   
 [IEEDataStorage](../vs140/ieedatastorage.md)