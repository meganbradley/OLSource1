---
title: "IDebugFunctionObject2::CreateObject"
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
  - "IDebugFunctionObject2::CreateObject"
  - "CreateObject"
ms.assetid: 148de615-941e-4b64-ab11-75b692aae465
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject2::CreateObject
Creates an object that uses a constructor given evaluation flag settings and a timeout value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugFunctionObject](../vs140/idebugfunctionobject.md) object that represents the constructor of the object to be created.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The number of parameters in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array. Represents the number of parameters passed to the constructor.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] An array of [IDebugObject](../vs140/idebugobject.md) objects that represents the parameters passed to the constructor.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [EVALFLAGS](../vs140/evalflags.md) enumeration that specify how the evaluation is to be performed.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use **INFINITE** to wait indefinitely.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns an **IDebugObject** representing the newly created object.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an instance of a class, or other complex type that requires a constructor, that is a parameter.  
  
## See Also  
 [IDebugFunctionObject2](../vs140/idebugfunctionobject2.md)