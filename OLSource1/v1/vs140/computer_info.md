---
title: "COMPUTER_INFO"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "COMPUTER_INFO structure"
ms.assetid: 943085b2-f165-462d-9a4e-2086f0cdfff4
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# COMPUTER_INFO
Describes the computer on which the debugger is running.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 wProcessorArchitecture  
 Identifies the architecture of the microprocessor.  
  
 wSuiteMask  
 Identifies the suite mask.  
  
 dwOperatingSystemVersion  
 Operating system version number.  
  
## Remarks  
 This structure is returned by the [IDebugWindowsComputerPort2::GetComputerInfo](../vs140/idebugwindowscomputerport2--getcomputerinfo.md) method.  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugWindowsComputerPort2::GetComputerInfo](../vs140/idebugwindowscomputerport2--getcomputerinfo.md)