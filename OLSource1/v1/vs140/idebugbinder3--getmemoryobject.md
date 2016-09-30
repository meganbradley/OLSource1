---
title: "IDebugBinder3::GetMemoryObject"
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
  - "IDebugBinder3::GetMemoryObject"
helpviewer_keywords: 
  - "IDebugBinder3::GetMemoryObject method"
ms.assetid: 71d959c7-45df-485f-b0ee-f1c0439d54fb
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetMemoryObject
This method retrieves a memory object that represents the memory that this object is bound to.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies which field to get the memory object for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Represents a memory address or value for a constant value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] An [IDebugObject](../vs140/idebugobject.md) representing the memory that this object is bound to.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugObject](../vs140/idebugobject.md)