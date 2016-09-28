---
title: "FIELD_KIND_EX"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "FIELD_KIND_EX enumeration"
ms.assetid: 922c3208-1e94-485f-b70a-3bc96affeff8
caps.latest.revision: 11
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# FIELD_KIND_EX
Enumerates additional kinds of fields that an [IDebugField](../vs140/idebugfield.md) object can contain. This enumeration extends the [FIELD_KIND](../vs140/field_kind.md) enumeration.  
  
## Syntax  
  
```cpp#  
enum enum_FIELD_KIND_EX  
{  
   FIELD_KIND_EX_NONE = 0,  
   FIELD_TYPE_EX_METHODVAR = 0x1,  
   FIELD_TYPE_EX_CLASSVAR = 0x2  
} ;  
typedef DWORD FIELD_KIND_EX;  
```  
  
```c#  
public enum enum_FIELD_KIND_EX  
{  
   FIELD_KIND_EX_NONE = 0,  
   FIELD_TYPE_EX_METHODVAR = 0x1,  
   FIELD_TYPE_EX_CLASSVAR = 0x2  
};  
```  
  
## Members  
 FIELD_KIND_EX_NONE  
 Field does not contain an extended type.  
  
 FIELD_TYPE_EX_METHODVAR  
 Field contains a method variable.  
  
 FIELD_TYPE_EX_CLASSVAR  
 Field contains a class variable.  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugExtendedField::GetExtendedKind](../vs140/idebugextendedfield--getextendedkind.md)