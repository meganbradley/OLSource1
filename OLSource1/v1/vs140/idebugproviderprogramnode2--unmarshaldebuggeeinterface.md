---
title: "IDebugProviderProgramNode2::UnmarshalDebuggeeInterface"
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
  - "IDebugProviderProgramNode2::UnmarshalDebuggeeInterface"
helpviewer_keywords: 
  - "IDebugProviderProgramNode2::UnmarshalDebuggeeInterface"
ms.assetid: 2e4653c5-10f1-493c-9973-f31d266c5d48
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProviderProgramNode2::UnmarshalDebuggeeInterface
Obtains a specified interface across process boundaries.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] GUID of the interface to obtain.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the object implementing the desired interface. [C++] this can be cast directly to the desired interface type. [C#] use the \<xref:System.Runtime.InteropServices.Marshal.GetObjectForIUnknown*> method to get the desired interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is used when the debug engine is running in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] process space and the program being debugged is running in its own process space.  
  
## See Also  
 [IDebugProviderProgramNode2](../vs140/idebugproviderprogramnode2.md)