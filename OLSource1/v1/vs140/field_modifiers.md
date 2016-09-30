---
title: "FIELD_MODIFIERS"
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
  - "FIELD_MODIFIERS"
helpviewer_keywords: 
  - "FIELD_MODIFIERS enumeration"
ms.assetid: 1e44681c-1f03-41a9-9c04-b79f231b0822
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# FIELD_MODIFIERS
Specifies modifiers for a field type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 FIELD_MOD_ACCESS_TYPE  
 Indicates that the field cannot be accessed.  
  
 FIELD_MOD_ACCESS_PUBLIC  
 Indicates that the field has public access.  
  
 FIELD_MOD_ACCESS_PROTECTED  
 Indicates that the field has protected access.  
  
 FIELD_MOD_ACCESS_PRIVATE  
 Indicates that the field has private access.  
  
 FIELD_MOD_NOMODIFIERS  
 Indicates that the field has no modifiers.  
  
 FIELD_MOD_STATIC  
 Indicates that the field is static.  
  
 FIELD_MOD_CONSTANT  
 Indicates that the field is a constant.  
  
 FIELD_MOD_TRANSIENT  
 Indicates that the field is transient.  
  
 FIELD_MOD_VOLATILE  
 Indicates that the field is volatile.  
  
 FIELD_MOD_ABSTRACT  
 Indicates that the field is abstract.  
  
 FIELD_MOD_NATIVE  
 Indicates that the field is native.  
  
 FIELD_MOD_SYNCHRONIZED  
 Indicates that the field is synchronized.  
  
 FIELD_MOD_VIRTUAL  
 Indicates that the field is virtual.  
  
 FIELD_MOD_INTERFACE  
 Indicates that the field is an interface.  
  
 FIELD_MOD_FINAL  
 Indicates that the field is final.  
  
 FIELD_MOD_SENTINEL  
 Indicates that the field is a sentinel.  
  
 FIELD_MOD_INNERCLASS  
 Indicates that the field is an inner class.  
  
 FIELD_TYPE_OPTIONAL  
 Indicates that the field is optional.  
  
 FIELD_MOD_BYREF  
 Indicates that the field is a reference argument. This is specifically for method arguments.  
  
 FIELD_MOD_HIDDEN  
 Indicates that the field must be hidden or presented in another context; for example, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] static locals.  
  
 FIELD_MOD_MARSHALASOBJECT  
 Indicates that the field represents an object with an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface.  
  
 FIELD_MOD_SPECIAL_NAME  
 Indicates that the field has a special name, for example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a constructor ([!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] only).  
  
 FIELD_MOD_HIDEBYSIG  
 Indicates that the field has the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword applied to it ([!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] only).  
  
 FIELD_MOD_WRITEONLY  
 Indicates that the field is write-only. This value is not included in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, as the only use of such write-only fields is for function evaluation. A user must explicitly ask for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> fields.  
  
 FIELD_MOD_ACCESS_MASK  
 Indicates a mask for field access.  
  
 FIELD_MOD_MASK  
 Indicates a mask for field modifiers.  
  
## Remarks  
 Used for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member of the [FIELD_INFO](../vs140/field_info.md) structure.  
  
 These values are also passed to the [IDebugContainerField::EnumFields](../vs140/idebugcontainerfield--enumfields.md) method to filter for specific fields.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [FIELD_INFO](../vs140/field_info.md)   
 [IDebugContainerField::EnumFields](../vs140/idebugcontainerfield--enumfields.md)