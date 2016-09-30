---
title: "IDebugObject::SetValue"
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
  - "IDebugObject::SetValue"
helpviewer_keywords: 
  - "IDebugObject::SetValue method"
ms.assetid: d652e09c-cdc1-4519-8116-d7c743f5679b
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject::SetValue
Sets the value of the object from a consecutive series of bytes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of bytes representing the new value.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The size of the value in bytes.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The values in the array are copied into this [IDebugObject](../vs140/idebugobject.md) object, replacing any existing value. The size of the new value can be larger or smaller than the existing value. This <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be a null reference.  
  
## See Also  
 [IDebugObject](../vs140/idebugobject.md)   
 [GetValue](../vs140/idebugobject--getvalue.md)