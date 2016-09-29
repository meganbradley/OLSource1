---
title: "IDebugClassField::GetEnclosingClass"
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
  - "IDebugClassField::GetEnclosingClass"
helpviewer_keywords: 
  - "IDebugClassField::GetEnclosingClass method"
ms.assetid: a0c12e3c-9ea0-4dfb-9e45-8cea18725022
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::GetEnclosingClass
Gets the class that encloses this class.  
  
## Syntax  
  
```cpp#  
HRESULT GetEnclosingClass(   
   IDebugClassField** ppClassField  
);  
```  
  
```c#  
int GetEnclosingClass(  
   out IDebugClassField ppClassField  
);  
```  
  
#### Parameters  
 `ppClassField`  
 [out] Returns an [IDebugClassField](../vs140/idebugclassfield.md) object representing the enclosing class. Returns a null value if there is no enclosing class.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 If the class represented by this [IDebugClassField](../vs140/idebugclassfield.md) object is a nested class, then the `ppClassField` parameter returns an `IDebugClassField` object representing the enclosing class. For example, given this class definition:  
  
```  
class RootClass {  
   class NestedClass { }  
};  
```  
  
 Calling the `GetEnclosingClass` method on the `IDebugClassField` object representing the `NestedClass` class returns an `IDebugClassField` object representing the class `RootClass`.  
  
## See Also  
 [IDebugClassField](../vs140/idebugclassfield.md)