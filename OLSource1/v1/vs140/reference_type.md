---
title: "REFERENCE_TYPE"
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
  - "REFERENCE_TYPE"
helpviewer_keywords: 
  - "REFERENCE_TYPE enumeration"
ms.assetid: b1ffba10-eb9d-48ba-bf48-6d8b71d6f270
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# REFERENCE_TYPE
Specifies the reference type.  
  
## Syntax  
  
```cpp#  
enum enum_REFERENCE_TYPE {   
   REF_TYPE_WEAK   = 0x0001,  
   REF_TYPE_STRONG = 0x0002  
};  
typedef DWORD REFERENCE_TYPE;  
```  
  
```c#  
public enum enum_REFERENCE_TYPE {   
   REF_TYPE_WEAK   = 0x0001,  
   REF_TYPE_STRONG = 0x0002  
};  
```  
  
## Members  
 REF_TYPE_WEAK  
 Specifies a weak reference. Cannot be combined with `REF_TYPE_STRONG`.  
  
 REF_TYPE_STRONG  
 Specifies a strong reference. Cannot be combined with `REF_TYPE_WEAK`.  
  
## Remarks  
 Used as the `dwRefType` member of the [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structure.  
  
 Passed as a parameter to the [IDebugReference2::SetReferenceType](../vs140/idebugreference2--setreferencetype.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md)   
 [IDebugReference2::SetReferenceType](../vs140/idebugreference2--setreferencetype.md)