---
title: "PDB_TYPE"
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
  - PDB_TYPE
helpviewer_keywords: 
  - PDB_TYPE structure
ms.assetid: 1c1bb772-77d6-4870-90b2-fd9247d0004e
caps.latest.revision: 11
translation.priority.mt: 
  - de-de
  - ja-jp
---
# PDB_TYPE
This structure specifies information about a field type taken from a PDB symbol.  
  
## Syntax  
  
```cpp#  
typedef struct _tagTYPE_PDB {  
   ULONG32 ulAppDomainID;  
   GUID    guidModule;  
   DWORD   symid;  
} PDB_TYPE;  
```  
  
```c#  
public struct PDB_TYPE {  
   public uint ulAppDomainID;  
   public Guid guidModule;  
   public uint symid;  
};  
```  
  
#### Parameters  
 ulAppDomainID  
 ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.  
  
 guidModule  
 The GUID of the module that contains this field.  
  
 symid  
 The ID of the symbol that corresponds to this field.  
  
## Remarks  
 This structure appears as part of the union in the [TYPE_INFO](../vs140/type_info.md) structure when the `dwKind` field of the `TYPE_INFO` structure is set to `TYPE_KIND_PDB` (a value from the [dwTYPE_KIND](../vs140/dwtype_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [TYPE_INFO](../vs140/type_info.md)   
 [dwTYPE_KIND](../vs140/dwtype_kind.md)