---
title: "IDebugField::GetExtendedInfo"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugField::GetExtendedInfo"
helpviewer_keywords: 
  - "IDebugField::GetExtendedInfo method"
ms.assetid: 46c0dd4d-4fd5-4efd-a908-71e4248e8e8d
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugField::GetExtendedInfo
This method gets extended information about a field.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Selects the information to be returned. Valid values are:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The value as a sequence of bytes.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The type as a type signature.|  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the extended information.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in, out] Returns the size of the extended information, in bytes.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Currently, this method returns only the type or value of a constant. The caller must free the buffer returned in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> by calling COM's <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function (C++) or \<xref:System.Runtime.InteropServices.Marshal.FreeCoTaskMem*> (C#).  
  
## See Also  
 [IDebugField](../vs140/idebugfield.md)