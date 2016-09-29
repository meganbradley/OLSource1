---
title: "IDebugMethodField::EnumStaticLocals"
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
  - "IDebugMethodField::EnumStaticLocals"
helpviewer_keywords: 
  - "IDebugMethodField::EnumStaticLocals method"
ms.assetid: e0c522c4-f759-4c32-ae87-7abcb573e77d
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::EnumStaticLocals
Creates an enumerator for static local variables of the method.  
  
## Syntax  
  
```cpp#  
HRESULT EnumStaticLocals(   
   IEnumDebugFields** ppLocals  
);  
```  
  
```c#  
int EnumStaticLocals(  
   out IEnumDebugFields ppLocals  
);  
```  
  
#### Parameters  
 `ppLocals`  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of static locals. Returns a null value if there are no static locals.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no static locals. Otherwise, returns an error code.  
  
## Remarks  
 Each element is an [IDebugField](../vs140/idebugfield.md) object representing different types of static locals. Call the [IDebugField::GetKind](../vs140/idebugfield--getkind.md) method on each object to determine exactly what kind of static local the object represents.  
  
## See Also  
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugField](../vs140/idebugfield.md)