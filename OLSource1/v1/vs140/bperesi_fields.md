---
title: "BPERESI_FIELDS"
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
  - "BPERESI_FIELDS"
helpviewer_keywords: 
  - "BPERESI_FIELDS enumeration"
ms.assetid: dd7dd89c-1043-46a1-a929-099cc039c344
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BPERESI_FIELDS
Specifies the information to be retrieved about a failed resolution of a breakpoint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 PERESI_BPRESLOCATION  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (breakpoint resolution location) field of the [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md) structure.  
  
 BPERESI_PROGRAM  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
 BPERESI_THREAD  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
 BPERESI_MESSAGE  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
 BPERESI_TYPE  
 Initialize/use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (breakpoint type) field of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure.  
  
 BPERESI_ALLFIELDS  
 Initialize/use all fields of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 Passed as a parameter to the [GetResolutionInfo](../vs140/idebugerrorbreakpointresolution2--getresolutioninfo.md) method to indicate which fields of the [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md) structure are to be initialized.  
  
 These values are also used to indicate which fields in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure are used and valid when that structure is returned.  
  
 These values may be combined with a bitwise <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [BP_ERROR_RESOLUTION_INFO](../vs140/bp_error_resolution_info.md)   
 [GetResolutionInfo](../vs140/idebugerrorbreakpointresolution2--getresolutioninfo.md)