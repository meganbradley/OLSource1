---
title: "CONTEXT_INFO_FIELDS"
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
  - "CONTEXT_INFO_FIELDS"
helpviewer_keywords: 
  - "CONTEXT_INFO_FIELDS enumeration"
ms.assetid: ef436bd3-738e-47e8-828c-8febce752439
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# CONTEXT_INFO_FIELDS
Specifies what information to retrieve about a memory context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 CIF_MODULEURL  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field of the [CONTEXT_INFO](../vs140/context_info.md) structure.  
  
 CIF_FUNCTION  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
 CIF_FUNCTIONOFFSET  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
 CIF_ADDRESS  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 CIF_ADDRESSOFFSET  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure.  
  
 CIF_ALLFIELDS  
 Initialize/use all fields of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 These values are passed a parameter to the [GetInfo](../vs140/idebugmemorycontext2--getinfo.md) method to indicate which fields of the [CONTEXT_INFO](../vs140/context_info.md) structure are to be initialized.  
  
 These flags are also used to indicate which fields of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure are used and valid when the structure is returned.  
  
 These values may be combined with a bitwise OR.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [CONTEXT_INFO](../vs140/context_info.md)   
 [GetInfo](../vs140/idebugmemorycontext2--getinfo.md)