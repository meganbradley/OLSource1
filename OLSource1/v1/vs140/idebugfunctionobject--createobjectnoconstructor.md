---
title: "IDebugFunctionObject::CreateObjectNoConstructor"
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
  - "IDebugFunctionObject::CreateObjectNoConstructor"
helpviewer_keywords: 
  - "IDebugFunctionObject::CreateObjectNoConstructor method"
ms.assetid: 4e2bd6d5-f4bd-4c10-a998-3db451c9a0c8
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject::CreateObjectNoConstructor
Creates an object with no constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugField](../vs140/idebugfield.md) object representing the type of the object to be created.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugObject](../vs140/idebugobject.md) representing the newly created object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an instance of a structure or complex type (that does not require a constructor) that is a parameter to the function which is represented by the [IDebugFunctionObject](../vs140/idebugfunctionobject.md) interface.  
  
 If the object parameter requires a constructor, call the [CreateObject](../vs140/idebugfunctionobject--createobject.md) method.  
  
## See Also  
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugFunctionObject](../vs140/idebugfunctionobject.md)   
 [CreateObject](../vs140/idebugfunctionobject--createobject.md)