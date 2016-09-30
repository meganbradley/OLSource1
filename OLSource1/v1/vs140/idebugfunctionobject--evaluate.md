---
title: "IDebugFunctionObject::Evaluate"
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
  - "IDebugFunctionObject::Evaluate"
helpviewer_keywords: 
  - "IDebugFunctionObject::Evaluate method"
ms.assetid: 29349ea3-d5c1-4135-aa76-ced073ab9683
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject::Evaluate
Calls the function and returns the resulting value as an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of [IDebugObject](../vs140/idebugobject.md) objects representing the input parameters. Each of these parameters was created with one of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods in the [IDebugFunctionObject](../vs140/idebugfunctionobject.md) interface.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The number of parameters in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to wait indefinitely.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugObject](../vs140/idebugobject.md) representing the value of the function as an object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method sets up and executes a call to the function represented by the [IDebugFunctionObject](../vs140/idebugfunctionobject.md) object.  
  
## See Also  
 [IDebugFunctionObject](../vs140/idebugfunctionobject.md)