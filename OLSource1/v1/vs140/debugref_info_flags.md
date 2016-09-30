---
title: "DEBUGREF_INFO_FLAGS"
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
  - "DEBUGREF_INFO_FLAGS"
helpviewer_keywords: 
  - "DEBUGREF_INFO_FLAGS enumeration"
ms.assetid: 1b043327-302a-4f6d-b51d-f94f9d7c7f9d
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DEBUGREF_INFO_FLAGS
Specifies what information to retrieve about a debug reference object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 DEBUGREF_INFO_NAME  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field in the structure.  
  
 DEBUGREF_INFO_TYPE  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field in the structure.  
  
 DEBUGREF_INFO_VALUE  
 Initialize/use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field in the structure.  
  
 DEBUGREF_INFO_ATTRIB  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field in the structure.  
  
 DEBUGREF_INFO_REFTYPE  
 Initialize/use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field in the structure.  
  
 DEBUGREF_INFO_REF  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field in the structure.  
  
 DEBUGREF_INFO_VALUE_AUTOEXPAND  
 The value field should contain the auto-expanded value, if available, for this type of object.  
  
 DEBUGREF_INFO_NONE  
 Indicates that no flags are set.  
  
 DEBUGREF_INFO_ALL  
 Indicates a mask of the flags.  
  
## Remarks  
 These flags are passed to the [IDebugReference2::EnumChildren](../vs140/idebugreference2--enumchildren.md) and [IDebugReference2::GetReferenceInfo](../vs140/idebugreference2--getreferenceinfo.md) methods to indicate which fields of the [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md) structure are to be initialized.  
  
 Used for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure to indicate which fields are used and valid when the structure is returned.  
  
 These values may be combined with a bitwise <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [DEBUG_REFERENCE_INFO](../vs140/debug_reference_info.md)   
 [IDebugReference2::EnumChildren](../vs140/idebugreference2--enumchildren.md)   
 [IDebugReference2::GetReferenceInfo](../vs140/idebugreference2--getreferenceinfo.md)