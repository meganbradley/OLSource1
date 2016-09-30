---
title: "IDebugFunctionObject::CreateArrayObject"
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
  - "IDebugFunctionObject::CreateArrayObject"
helpviewer_keywords: 
  - "IDebugFunctionObject::CreateArrayObject method"
ms.assetid: a380e53c-15f1-401f-927f-f366eea789e6
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugFunctionObject::CreateArrayObject
Creates an array object. This array can contain either primitive or object instance values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies a value from the [OBJECT_TYPE](../vs140/object_type.md) enumeration indicating the type of the new array object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An [IDebugField](../vs140/idebugfield.md) object representing the class of an object, if creating an array of object instance values. If creating an array of primitive objects, this parameter is a null value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The rank or number of dimensions of the array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The sizes of each dimension of the array.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The origin of each dimension (typically 0 or 1).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugObject](../vs140/idebugobject.md) object representing the newly created array. This is actually an [IDebugArrayObject](../vs140/idebugarrayobject.md) object.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Call this method to create an object that represents an array parameter to the function which is represented by the [IDebugFunctionObject](../vs140/idebugfunctionobject.md) interface.  
  
## See Also  
 [IDebugFunctionObject](../vs140/idebugfunctionobject.md)