---
title: "OBJECT_TYPE"
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
  - "OBJECT_TYPE"
helpviewer_keywords: 
  - "OBJECT_TYPE enumeration"
ms.assetid: c4d246f9-8a98-44ec-b2bb-ff5c684f668e
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# OBJECT_TYPE
Specifies the type of an object from the expression evaluator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 OBJECT_TYPE_BOOLEAN  
 Indicates that the object is a Boolean.  
  
 OBJECT_TYPE_CHAR  
 Indicates that the object is a character.  
  
 OBJECT_TYPE_I1  
 Indicates that the object is a one-byte signed integer.  
  
 OBJECT_TYPE_U1  
 Indicates that the object is a one-byte unsigned integer.  
  
 OBJECT_TYPE_I2  
 Indicates that the object is a two-byte signed integer.  
  
 OBJECT_TYPE_U2  
 Indicates that the object is a two-byte unsigned integer.  
  
 OBJECT_TYPE_I4  
 Indicates that the object is a four-byte signed integer.  
  
 OBJECT_TYPE_U4  
 Indicates that the object is a four-byte unsigned integer.  
  
 OBJECT_TYPE_I8  
 Indicates that the object is an eight-byte signed integer.  
  
 OBJECT_TYPE_U8  
 Indicates that the object is an eight-byte unsigned integer.  
  
 OBJECT_TYPE_R4  
 Indicates that the object is a four-byte floating-point number.  
  
 OBJECT_TYPE_R8  
 Indicates that the object is an eight-byte floating-point number.  
  
 OBJECT_TYPE_OBJECT  
 Indicates that the object is an object.  
  
 OBJECT_TYPE_NULL  
 Indicates that the object is NULL.  
  
 OBJECT_TYPE_CLASS  
 Indicates that the object is a class.  
  
## Remarks  
 Passed as an argument to the [CreatePrimitiveObject](../vs140/idebugfunctionobject--createprimitiveobject.md) and [CreateArrayObject](../vs140/idebugfunctionobject--createarrayobject.md) methods.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [CreatePrimitiveObject](../vs140/idebugfunctionobject--createprimitiveobject.md)   
 [CreateArrayObject](../vs140/idebugfunctionobject--createarrayobject.md)