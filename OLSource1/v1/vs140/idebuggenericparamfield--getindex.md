---
title: "IDebugGenericParamField::GetIndex"
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
  - "IDebugGenericParamField::GetIndex"
ms.assetid: 8e0bdb26-1247-44d9-8d80-ec6e35187fb4
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugGenericParamField::GetIndex
Retrieves the index of this generic parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Index value of this generic parameter.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 For example, for Dictionary(K,V), K is index 0, V is index 1.  
  
## Example  
 The following example shows how to implement this method for a **CDebugGenericParamFieldType** object that exposes the [IDebugGenericParamField](../vs140/idebuggenericparamfield.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugGenericParamField](../vs140/idebuggenericparamfield.md)