---
title: "IDebugEngine2::GetEngineID"
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
  - "IDebugEngine2::GetEngineID"
helpviewer_keywords: 
  - "IDebugEngine2::GetEngineID"
ms.assetid: 0d5674c8-a9b9-4b72-8211-d2d68695775a
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine2::GetEngineID
Gets the GUID of the debug engine (DE).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the GUID of the DE.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Some examples of typical GUIDs are <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. New debug engines will create their own GUID for identification.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object that implements the [IDebugEngine2](../vs140/idebugengine2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)