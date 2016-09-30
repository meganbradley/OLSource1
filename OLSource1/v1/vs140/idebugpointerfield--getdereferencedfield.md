---
title: "IDebugPointerField::GetDereferencedField"
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
  - "IDebugPointerField::GetDereferencedField"
helpviewer_keywords: 
  - "IDebugPointerField::GetDereferencedField method"
ms.assetid: 8de988ab-cd79-4287-be72-3c900f2fe407
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPointerField::GetDereferencedField
This method returns the type of object to which this pointer object points.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugField](../vs140/idebugfield.md) describing the type of target object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 If, for example, the [IDebugPointerField](../vs140/idebugpointerfield.md) object points to an integer, the [IDebugField](../vs140/idebugfield.md) type returned by this method describes that integer type.  
  
## See Also  
 [IDebugPointerField](../vs140/idebugpointerfield.md)   
 [IDebugField](../vs140/idebugfield.md)