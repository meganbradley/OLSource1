---
title: "FIELD_KIND"
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
  - "FIELD_KIND"
helpviewer_keywords: 
  - "FIELD_KIND enumeration"
ms.assetid: fd522b9c-52e2-42fa-939d-343347d5c3b1
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# FIELD_KIND
Specifies the kind of field contained in an [IDebugField](../vs140/idebugfield.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 FIELD_KIND_TYPE  
 Indicates that the field is a type only.  
  
 FIELD_KIND_SYMBOL  
 Indicates that the field is a symbol, with type, name, and other information.  
  
 FIELD_TYPE_PRIMITIVE  
 Indicates that the field is a primitive data type.  
  
 FIELD_TYPE_STRUCT  
 Indicates that the field is a structure.  
  
 FIELD_TYPE_CLASS  
 Indicates that the field is a class.  
  
 FIELD_TYPE_INTERFACE  
 Indicates that the field is an interface.  
  
 FIELD_TYPE_UNION  
 Indicates that the field is a union.  
  
 FIELD_TYPE_ARRAY  
 Indicates that the field is an array.  
  
 FIELD_TYPE_METHOD  
 Indicates that the field is a method.  
  
 FIELD_TYPE_BLOCK  
 Indicates that the field is a block.  
  
 FIELD_TYPE_POINTER  
 Indicates that the field is a pointer.  
  
 FIELD_TYPE_ENUM  
 Indicates that the field is an enumerated data type.  
  
 FIELD_TYPE_LABEL  
 Indicates that the field is a label.  
  
 FIELD_TYPE_TYPEDEF  
 Indicates that the field is a typedef.  
  
 FIELD_TYPE_BITFIELD  
 Indicates that the field is a bitfield.  
  
 FIELD_TYPE_NAMESPACE  
 Indicates that the field is a namespace.  
  
 FIELD_TYPE_MODULE  
 Indicates that the field is a module.  
  
 FIELD_TYPE_DYNAMIC  
 Indicates that the field is dynamic.  
  
 FIELD_TYPE_PROP  
 Indicates that the field is a property.  
  
 FIELD_TYPE_INNERCLASS  
 Indicates that the field is an inner class.  
  
 FIELD_TYPE_REFERENCE  
 Indicates that the field is a reference.  
  
 FIELD_TYPE_EXTENDED  
 Reserved for future use.  
  
 FIELD_SYM_MEMBER  
 Indicates that the field is a member.  
  
 FIELD_SYM_LOCAL  
 Indicates that the field is local.  
  
 FIELD_SYM_PARAMETER  
 Indicates that the field is a parameter.  
  
 FIELD_SYM_THIS  
 Indicates that the field is the "this" pointer.  
  
 FIELD_SYM_GLOBAL  
 Indicates that the field is global.  
  
 FIELD_SYM_PROP_GETTER  
 Indicates that the field retrieves properties.  
  
 FIELD_SYM_PROP_SETTER  
 Indicates that the field sets properties.  
  
 FIELD_SYM_EXTENDED  
 Reserved for future use.  
  
 FIELD_KIND_MASK  
 Indicates a mask for field kinds.  
  
 FIELD_TYPE_MASK  
 Indicates a mask for field types.  
  
 FIELD_SYM_MASK  
 Indicates a mask for symbol information.  
  
## Remarks  
 Returned from a call to the [GetKind](../vs140/idebugfield--getkind.md) method.  
  
 Depending on the kind of field, [QueryInterface](../vs140/queryinterface.md) can be called on the [IDebugField](../vs140/idebugfield.md) interface for a more specific form of interface. For example, if [GetKind](../vs140/idebugfield--getkind.md) returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, you can then call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on I<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to obtain the [IDebugMethodField](../vs140/idebugmethodfield.md) interface.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [FIELD_MODIFIERS](../vs140/field_modifiers.md)   
 [GetKind](../vs140/idebugfield--getkind.md)   
 [IDebugField](../vs140/idebugfield.md)