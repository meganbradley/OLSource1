---
title: "IDebugProperty3::SetValueAsStringWithError"
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
  - "IDebugProperty3::SetValueAsStringWithError"
helpviewer_keywords: 
  - "IDebugProperty3::SetValueAsStringWithError"
ms.assetid: b378368f-4a45-4b2f-8e3d-3bff7a18ab17
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty3::SetValueAsStringWithError
Sets the value of this property and returns an error message, if necessary.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Value to set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The radix of the value being set.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The length of time to wait for the value to be set (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> means wait forever).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] If there was an error setting the value, this holds the reason for the failure.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The incoming value could be an expression to be evaluated.  
  
## Example  
 The following example shows how to implement this method for a **CProperty** object that exposes the [IDebugProperty3](../vs140/idebugproperty3.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugProperty3](../vs140/idebugproperty3.md)