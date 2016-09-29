---
title: "IDebugClassField::EnumConstructors"
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
  - "IDebugClassField::EnumConstructors"
helpviewer_keywords: 
  - "IDebugClassField::EnumConstructors method"
ms.assetid: 66a250b2-75a0-45aa-8d58-40f91cc4bf7b
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::EnumConstructors
Creates an enumerator for the constructors for this class.  
  
## Syntax  
  
```cpp#  
HRESULT EnumConstructors(   
   CONSTRUCTOR_ENUM   cMatch,  
   IEnumDebugFields** ppEnum  
);  
```  
  
```c#  
int EnumConstructors(  
   CONSTRUCTOR_ENUM     cMatch,   
   out IEnumDebugFields ppEnum  
);  
```  
  
#### Parameters  
 `cMatch`  
 [in] A value from the [CONSTRUCTOR_ENUM](../VS_csharp/constructor_enum.md) enumeration that specifies the type of constructors to enumeration.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugFields](../VS_csharp/ienumdebugfields.md) object representing the list of constructors. Returns a null value if there are no constructors.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no constructors. Otherwise, returns an error code.  
  
## Remarks  
 Each element of the enumeration is an [IDebugMethodField](../VS_csharp/idebugmethodfield.md) object describing a constructor method.  
  
 The list of constructors typically does not include the default constructors supplied by a compiler.  
  
## See Also  
 [IDebugClassField](../VS_csharp/idebugclassfield.md)   
 [IEnumDebugFields](../VS_csharp/ienumdebugfields.md)   
 [IDebugMethodField](../VS_csharp/idebugmethodfield.md)   
 [CONSTRUCTOR_ENUM](../VS_csharp/constructor_enum.md)