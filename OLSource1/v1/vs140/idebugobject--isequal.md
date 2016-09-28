---
title: "IDebugObject::IsEqual"
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
  - "IDebugObject::IsEqual"
helpviewer_keywords: 
  - "IDebugObject::IsEqual method"
ms.assetid: 4b76e663-ef2e-41ff-9be1-bf26d666a34a
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject::IsEqual
Compares an object with this object.  
  
## Syntax  
  
```cpp#  
HRESULT IsEqual(   
   IDebugObject* pObject,  
   BOOL*         pfIsEqual  
);  
```  
  
```c#  
int IsEqual(  
   IDebugObject pObject,  
   out int      pfIsEqual  
);  
```  
  
#### Parameters  
 `pObject`  
 [in] An [IDebugObject](../vs140/idebugobject.md) object representing the object to compare to.  
  
 `pfIsEqual`  
 [out] Returns non-zero (`TRUE`) if the values of the objects are equal; otherwise, returns zero (`FALSE`).  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Typically, this method can compare the addresses of the values represented by the `pObject` parameter and this [IDebugObject](../vs140/idebugobject.md) object; if the addresses are equal, then the objects can be considered equal.  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)