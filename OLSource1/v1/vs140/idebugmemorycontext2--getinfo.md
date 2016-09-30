---
title: "IDebugMemoryContext2::GetInfo"
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
  - "IDebugMemoryContext2::GetInfo"
helpviewer_keywords: 
  - "GetInfo method"
  - "IDebugMemoryContext2::GetInfo method"
ms.assetid: 08c7f091-1816-4d64-8834-f9ecaac5c58d
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMemoryContext2::GetInfo
Retrieves a [CONTEXT_INFO](../vs140/context_info.md) structure that describes the context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [CONTEXT_INFO_FIELDS](../vs140/context_info_fields.md) enumeration that indicate which fields of the [CONTEXT_INFO](../vs140/context_info.md) structure are to be fill in.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure that is filled in.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugMemoryContext2](../vs140/idebugmemorycontext2.md)   
 [CONTEXT_INFO_FIELDS](../vs140/context_info_fields.md)   
 [CONTEXT_INFO](../vs140/context_info.md)