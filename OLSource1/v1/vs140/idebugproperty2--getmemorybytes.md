---
title: "IDebugProperty2::GetMemoryBytes"
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
  - "IDebugProperty2::GetMemoryBytes"
helpviewer_keywords: 
  - "IDebugProperty2::GetMemoryBytes"
ms.assetid: b32042ed-7a06-4b4a-99ef-fe03b0aa61cc
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty2::GetMemoryBytes
Gets the memory bytes that compose the value of a property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md) object that can be used to retrieve the memory that contains the value of the property.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise returns error code. Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if there are no memory bytes to retrieve.  
  
## See Also  
 [IDebugProperty2](../vs140/idebugproperty2.md)   
 [IDebugMemoryBytes2](../vs140/idebugmemorybytes2.md)