---
title: "IDebugCoreServer2::GetMachineInfo"
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
  - "IDebugCoreServer2::GetInfo"
helpviewer_keywords: 
  - "IDebugCoreServer2::GetInfo"
ms.assetid: 8fa1a1d3-9fcb-4fb3-bf4e-e7172ac08d77
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCoreServer2::GetMachineInfo
Retrieves a description of the machine the core server is running on.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [MACHINE_INFO_FIELDS](../vs140/machine_info_fields.md) enumeration that specify which fields of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are to be filled out.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] A [MACHINE_INFO](../vs140/machine_info.md) structure that is filled in with a description of the machine.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugCoreServer2](../vs140/idebugcoreserver2.md)   
 [MACHINE_INFO_FIELDS](../vs140/machine_info_fields.md)   
 [MACHINE_INFO](../vs140/machine_info.md)