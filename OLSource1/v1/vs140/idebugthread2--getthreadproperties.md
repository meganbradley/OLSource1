---
title: "IDebugThread2::GetThreadProperties"
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
  - "IDebugThread2::GetThreadProperties"
helpviewer_keywords: 
  - "IDebugThread2::GetThreadProperties"
ms.assetid: 304403fd-f4f8-4096-ac2c-bd3b59663aad
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThread2::GetThreadProperties
Gets the properties that describe this thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [THREADPROPERTY_FIELDS](../vs140/threadproperty_fields.md) enumeration that determines which fields of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are to be filled in.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] A [THREADPROPERTIES](../vs140/threadproperties.md) structure that that is filled in with the properties of the thread.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The information returned from this method is typically shown in the **Threads** debug window.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that implements the [IDebugThread2](../vs140/idebugthread2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugThread2](../vs140/idebugthread2.md)   
 [THREADPROPERTY_FIELDS](../vs140/threadproperty_fields.md)   
 [THREADPROPERTIES](../vs140/threadproperties.md)