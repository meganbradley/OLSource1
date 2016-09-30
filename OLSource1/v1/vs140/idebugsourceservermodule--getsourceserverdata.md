---
title: "IDebugSourceServerModule::GetSourceServerData"
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
  - "IDebugSourceServerModule::GetSourceServerData"
ms.assetid: f15d86aa-1bd9-4b16-a64a-21b01c27db2e
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSourceServerModule::GetSourceServerData
Retrieves an array of source server information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Number of bytes in the data array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Reference to the data array.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CModule** object that exposes the [IDebugSourceServerModule](../vs140/idebugsourceservermodule.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugSourceServerModule](../vs140/idebugsourceservermodule.md)