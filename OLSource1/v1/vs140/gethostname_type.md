---
title: "GETHOSTNAME_TYPE"
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
  - "GETHOSTNAME_TYPE"
helpviewer_keywords: 
  - "GETHOSTNAME_TYPE enumeration"
ms.assetid: 2be92bea-8133-412b-9015-1833baf16e1b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# GETHOSTNAME_TYPE
Specifies the type of host name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 GHN_FRIENDLY_NAME  
 Specifies a friendly name of the host.  
  
 GHN_FILE_NAME  
 Specifies a file name of the host.  
  
## Remarks  
 These values are passed as an argument to the [GetHostName](../vs140/idebugprogramnode2--gethostname.md) method to retrieve a host name in different formats.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetHostName](../vs140/idebugprogramnode2--gethostname.md)