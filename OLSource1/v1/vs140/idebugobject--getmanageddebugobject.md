---
title: "IDebugObject::GetManagedDebugObject"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugObject::GetManagedDebugObject
helpviewer_keywords: 
  - IDebugObject::GetManagedDebugObject method
ms.assetid: cb89692e-7657-47ff-846d-311943521951
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugObject::GetManagedDebugObject
Creates a copy of the managed object in the address space of the debug engine.  
  
## Syntax  
  
```cpp#  
HRESULT GetManagedDebugObject(   
   IDebugManagedObject** ppObject  
);  
```  
  
```c#  
int GetManagedDebugObject(  
   out IDebugManagedObject ppObject  
);  
```  
  
#### Parameters  
 `ppObject`  
 [out] Returns an [IDebugManagedObject](../vs140/idebugmanagedobject.md) object representing the newly created managed object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code. Returns E_FAIL if this [IDebugObject](../vs140/idebugobject.md) does not represent a managed value class instance.  
  
## Remarks  
 This [IDebugObject](../vs140/idebugobject.md) object must represent a managed value class instance, such as a `System.Decimal` instance. By having a local copy, the overhead of calling [Evaluate](../vs140/idebugfunctionobject--evaluate.md) is eliminated.  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)   
 [IDebugManagedObject](../vs140/idebugmanagedobject.md)