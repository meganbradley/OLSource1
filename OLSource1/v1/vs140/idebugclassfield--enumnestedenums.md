---
title: "IDebugClassField::EnumNestedEnums"
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
  - "IDebugClassField::EnumNestedEnums"
helpviewer_keywords: 
  - "IDebugClassField::EnumNestedEnums method"
ms.assetid: 90fd0cef-9145-4de6-91d4-6c881df39d6e
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::EnumNestedEnums
Creates an enumerator for the nested enumerators of this class.  
  
## Syntax  
  
```cpp#  
HRESULT EnumNestedEnums(   
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int EnumNestedEnums(  
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of nested enumerations. Returns a null value if there are no nested enumerations.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no nested enumerators. Otherwise, returns an error code.  
  
## Remarks  
 Each element of the enumeration is an [IDebugEnumField](../vs140/idebugenumfield.md) object describing a nested enumeration.  
  
 An enumeration declared inside a class is considered a nested enumeration. For example, given:  
  
```  
class RootClass {  
   enum NestedEnum { EnumValue = 0 }  
};  
```  
  
 The `EnumNestedEnums` method would return an [IEnumDebugFields](../vs140/ienumdebugfields.md) object that contains one [IDebugEnumField](../vs140/idebugenumfield.md) object that represents the `NestedEnum` enumeration.  
  
## See Also  
 [IDebugClassField](../vs140/idebugclassfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugEnumField](../vs140/idebugenumfield.md)