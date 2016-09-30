---
title: "IDebugFunctionObject2::Evaluate"
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
  - "IDebugFunctionObject2::Evaluate"
ms.assetid: bc54c652-904b-4297-a6db-faa329684881
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject2::Evaluate
Calls the function and returns the resulting value as an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of [IDebugObject](../vs140/idebugobject.md) objects that represents the input parameters. Each of these parameters was created by using one of the Create methods in this interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of parameters in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [EVALFLAGS](../vs140/evalflags.md) enumeration that specify how the evaluation is to be performed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use **INFINITE** to wait indefinitely.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns an **IDebugObject** that represents the value of the function as an object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionObject2](../vs140/idebugfunctionobject2.md)