---
title: "IDebugGenericParamField::ConstraintCount"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "ConstraintCount"
  - "IDebugGenericParamField::ConstraintCount"
ms.assetid: 76bef0cb-8a3c-4ce5-87cc-1809de229f33
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugGenericParamField::ConstraintCount
Returns the number of constraints that are associated with this generic parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] Number of constraints that are associated with this field.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../vs140/idebuggenericparamfield.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugGenericParamField](../vs140/idebuggenericparamfield.md)