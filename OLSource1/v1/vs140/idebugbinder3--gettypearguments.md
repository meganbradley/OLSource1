---
title: "IDebugBinder3::GetTypeArguments"
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
  - "IDebugBinder3::GetTypeArguments"
helpviewer_keywords: 
  - "IDebugBinder3::GetTypeArguments method"
ms.assetid: fa0c37a7-327f-463e-9a9d-bb3f534584cb
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetTypeArguments
This method retrieves a list of argument types associated with this object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in]Number of fields to skip before getting argument types.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of argument fields to return (also specifies the size of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] An array of fields that will be filled in on return of this method.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [out] (optional) The number of argument type fields actually returned.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The number of argument types can be obtained beforehand with [IDebugBinder3::GetTypeArgumentCount](../vs140/idebugbinder3--gettypeargumentcount.md).  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)   
 [IDebugBinder3::GetTypeArgumentCount](../vs140/idebugbinder3--gettypeargumentcount.md)