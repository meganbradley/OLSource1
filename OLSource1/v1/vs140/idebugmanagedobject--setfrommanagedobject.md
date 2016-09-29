---
title: "IDebugManagedObject::SetFromManagedObject"
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
  - "IDebugManagedObject::SetFromManagedObject"
helpviewer_keywords: 
  - "IDebugManagedObject::SetFromManagedObject method"
ms.assetid: 8700ee8d-2704-4580-bccc-046837a24edd
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugManagedObject::SetFromManagedObject
Sets the value of the instance of the value class object from the instance of the value class provided as a parameter.  
  
## Syntax  
  
```cpp#  
HRESULT SetFromManagedObject(   
   IUnknown* pManagedObject  
);  
```  
  
```c#  
int SetFromManagedObject(  
   object pManagedObject  
);  
```  
  
#### Parameters  
 `pManagedObject`  
 [in] An interface that represents the managed object containing the new value.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method is used to change the managed object as represented by the [IDebugManagedObject](../vs140/idebugmanagedobject.md) object.  
  
## See Also  
 [IDebugManagedObject](../vs140/idebugmanagedobject.md)