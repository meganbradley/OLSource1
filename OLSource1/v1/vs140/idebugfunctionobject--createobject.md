---
title: "IDebugFunctionObject::CreateObject"
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
  - "IDebugFunctionObject::CreateObject"
helpviewer_keywords: 
  - "IDebugFunctionObject::CreateObject method"
ms.assetid: c4c99dd5-609a-4e7c-8f29-eb728f57e995
caps.latest.revision: 13
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject::CreateObject
Creates an object using a constructor.  
  
## Syntax  
  
```cpp#  
HRESULT CreateObject(   
   IDebugFunctionObject* pConstructor,  
   DWORD                 dwArgs,  
   IDebugObject*         pArgs[],  
   IDebugObject**        ppObject  
);  
```  
  
```c#  
int CreateObject(  
   IDebugFunctionObject pConstructor,   
   uint                 dwArgs,   
   IDebugObject[]       pArgs,   
   out IDebugObject     ppObject  
);  
```  
  
#### Parameters  
 `pConstructor`  
 [in] An [IDebugFunctionObject](../vs140/idebugfunctionobject.md) object representing the constructor of the object to be created.  
  
 `dwArgs`  
 [in] The number of parameters in the `pArg` array. Represents the number of parameters passed to the constructor.  
  
 `pArg`  
 [in] An array of [IDebugObject](../vs140/idebugobject.md) objects representing the parameters passed to the constructor.  
  
 `ppObject`  
 [out] Returns an `IDebugObject` representing the newly created object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an instance of a class (or other complex type that requires a constructor) that is a parameter to the function which is represented by the [IDebugFunctionObject](../vs140/idebugfunctionobject.md) interface.  
  
 If the object parameter does not require a constructor, call the [IDebugFunctionObject::CreateObjectNoConstructor](../vs140/idebugfunctionobject--createobjectnoconstructor.md) method.  
  
## See Also  
 [IDebugFunctionObject](../vs140/idebugfunctionobject.md)   
 [CreateObjectNoConstructor](../vs140/idebugfunctionobject--createobjectnoconstructor.md)