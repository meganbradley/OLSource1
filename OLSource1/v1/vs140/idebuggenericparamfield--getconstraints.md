---
title: "IDebugGenericParamField::GetConstraints"
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
  - "IDebugGenericParamField::GetConstraints"
  - "GetConstraints"
ms.assetid: 86a78b5a-ee0f-4999-a0ba-919d3dc7d969
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugGenericParamField::GetConstraints
Retrieves the constraints that are associated with this generic parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Number of constraints.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns an array that contains the constraints associated with this field.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] Number of constraints in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> array.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../vs140/idebuggenericparamfield.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugGenericParamField](../vs140/idebuggenericparamfield.md)