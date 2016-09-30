---
title: "IDebugPointerObject::Dereference"
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
  - "IDebugPointerObject::Dereference"
helpviewer_keywords: 
  - "IDebugPointerObject::Dereference method"
ms.assetid: 196ec2cc-8569-4780-b217-23b24e7f50ca
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPointerObject::Dereference
Gets the object pointed to.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A simple byte offset from the beginning of the object pointed to.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugObject](../vs140/idebugobject.md) object representing the object pointed to, plus offset, if any.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code. Returns E_FAIL if this object does not point to another object.  
  
## Remarks  
 The object pointed to can be a primitive or a more complex type such as a class or structure.  
  
## See Also  
 [IDebugPointerObject](../vs140/idebugpointerobject.md)