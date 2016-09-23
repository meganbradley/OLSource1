---
title: "BUILT_TYPE"
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
  - BUILT_TYPE
helpviewer_keywords: 
  - BUILT_TYPE structure
ms.assetid: cc02c32c-0f65-4210-ad25-a9b1899066e8
caps.latest.revision: 11
translation.priority.mt: 
  - de-de
  - ja-jp
---
# BUILT_TYPE
This structure specifies information about a field type taken from metadata.  
  
## Syntax  
  
```cpp#  
typedef struct _tagTYPE_BUILT {  
   ULONG32      ulAppDomainID;  
   GUID         guidModule;  
   IDebugField* pUnderlyingField;  
} BUILT_TYPE;  
```  
  
```c#  
public struct BUILT_TYPE {  
   public uint        ulAppDomainID;  
   public Guid        guidModule;  
   public IDebugField pUnderlyingField;  
};  
```  
  
#### Parameters  
 ulAppDomainID  
 ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.  
  
 guidModule  
 The GUID of the module that contains this field.  
  
 pUnderlyingField  
 An [IDebugField](../vs140/idebugfield.md) object identifying the underlying field associated with this built field.  
  
## Remarks  
 This structure appears as part of the union in the [TYPE_INFO](../vs140/type_info.md) structure when the `dwKind` field of the `TYPE_INFO` structure is set to `TYPE_KIND_BUILT` (a value from the [dwTYPE_KIND](../vs140/dwtype_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [TYPE_INFO](../vs140/type_info.md)   
 [dwTYPE_KIND](../vs140/dwtype_kind.md)   
 [IDebugField](../vs140/idebugfield.md)