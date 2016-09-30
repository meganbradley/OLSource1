---
title: "IDebugProperty2::GetMemoryContext"
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
  - "IDebugProperty2::GetMemoryContext"
helpviewer_keywords: 
  - "IDebugProperty2::GetMemoryContext"
ms.assetid: 91793d25-790f-4881-a5c0-d0458e534514
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::GetMemoryContext
Gets the memory context of the property value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md) object that represents the memory associated with this property.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise returns error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if there is no memory context to retrieve.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)