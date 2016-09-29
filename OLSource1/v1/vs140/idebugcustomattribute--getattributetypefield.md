---
title: "IDebugCustomAttribute::GetAttributeTypeField"
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
  - "IDebugCustomAttribute::GetAttributeTypeField"
helpviewer_keywords: 
  - "IDebugCustomAttribute::GetAttributeTypeField"
ms.assetid: d6ce26d5-42ba-44c1-8659-0516db5bc82d
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCustomAttribute::GetAttributeTypeField
Gets the custom attribute class type.  
  
## Syntax  
  
```cpp#  
HRESULT GetAttributeTypeField(   
   IDebugClassField** ppCAType  
);  
```  
  
```c#  
int GetAttributeTypeField(  
   out IDebugClassField ppCAType  
);  
```  
  
#### Parameters  
 `ppCAType`  
 [out] Returns the [IDebugClassField](../vs140/idebugclassfield.md) object that represents the class of which the custom attribute is an instance.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 A custom attribute is always a class. This method provides access to an [IDebugClassField](../vs140/idebugclassfield.md) object that describes that class.  
  
## See Also  
 [IDebugCustomAttribute](../vs140/idebugcustomattribute.md)   
 [IDebugClassField](../vs140/idebugclassfield.md)