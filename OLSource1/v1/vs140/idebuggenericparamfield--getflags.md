---
title: "IDebugGenericParamField::GetFlags"
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
  - "GetFlags"
  - "IDebugGenericParamField::GetFlags"
ms.assetid: adcbbca1-8960-4c88-86b0-8b9467056c97
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugGenericParamField::GetFlags
Retrieves the flags for this generic parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the flags for this generic parameter.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 These flags contain information about various special constraints.  
  
## Example  
 The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../vs140/idebuggenericparamfield.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugGenericParamField](../vs140/idebuggenericparamfield.md)