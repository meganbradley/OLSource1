---
title: "IDebugObject::GetValue"
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
  - "IDebugObject::GetValue"
helpviewer_keywords: 
  - "IDebugObject::GetValue method"
ms.assetid: eec6051e-8ecb-49fa-bdd4-dd786f211692
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject::GetValue
Gets the value of the object as a consecutive series of bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in, out] An array that is filled in with a consecutive series of bytes representing the value of the object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The maximum number of bytes to fetch.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Get the total number of value bytes that can be fetched by calling the [IDebugObject::GetSize](../vs140/idebugobject--getsize.md) method.  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)