---
title: "MACHINE_INFO"
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
  - "MACHINE_INFO"
helpviewer_keywords: 
  - "MACHINE_INFO structure"
ms.assetid: e7564ff2-00b5-4750-8fd5-dc1029a16912
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# MACHINE_INFO
Describes a particular machine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A combination of flags from the [MACHINE_INFO_FIELDS](../vs140/machine_info_fields.md) enumeration that specify which fields of the structure are initialized.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The machine name. Equivalent to calling [GetMachineName](../vs140/idebugcoreserver2--getmachinename.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A combination of flags from the [MACHINE_INFO_FLAGS](../vs140/machine_info_flags.md) enumeration describing the machine attributes.  
  
## Remarks  
 This structure is returned by a call to the [GetMachineInfo](../vs140/idebugcoreserver2--getmachineinfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [MACHINE_INFO_FIELDS](../vs140/machine_info_fields.md)   
 [GetMachineInfo](../vs140/idebugcoreserver2--getmachineinfo.md)