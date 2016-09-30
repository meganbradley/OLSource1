---
title: "IDebugBinder3::GetTypeArgumentCount"
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
  - "IDebugBinder3::GetTypeArgumentCount"
helpviewer_keywords: 
  - "IDebugBinder3::GetTypeArgumentCount method"
ms.assetid: caf68de6-6f7c-4efd-b803-121347a5032e
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetTypeArgumentCount
This method returns the number of argument types associated with this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Number of argument types associated with this object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method can be used to allocate an array for use with the [IDebugBinder3::GetTypeArguments](../vs140/idebugbinder3--gettypearguments.md) method.  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)   
 [IDebugBinder3::GetTypeArguments](../vs140/idebugbinder3--gettypearguments.md)