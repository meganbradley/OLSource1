---
title: "ADDRESS_KIND"
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
  - "ADDRESS_KIND"
helpviewer_keywords: 
  - "ADDRESS_KIND enumeration"
ms.assetid: 3a12fbec-7088-4cf9-8f6f-ad8ddec6009a
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ADDRESS_KIND
Specifies the kinds of addresses.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 ADDRESS_KIND_NATIVE  
 A native address, represented by the [NATIVE_ADDRESS](../vs140/native_address.md) structure.  
  
 ADDRESS_KIND_UNMANAGED_THIS_RELATIVE  
 An unmanaged address relative to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in Visual Basic) pointer and represented by the [UNMANAGED_ADDRESS_THIS_RELATIVE](../vs140/unmanaged_address_this_relative.md) structure.  
  
 ADDRESS_KIND_UNMANAGED_PHYSICAL  
 An unmanaged physical address, represented by the [UNMANAGED_ADDRESS_PHYSICAL](../vs140/unmanaged_address_physical.md) structure.  
  
 ADDRESS_KIND_METHOD  
 A method of a class, represented by the [METADATA_ADDRESS_METHOD](../vs140/metadata_address_method.md) structure.  
  
 ADDRESS_KIND_FIELD  
 A field of a class, represented by the [METADATA_ADDRESS_FIELD](../vs140/metadata_address_field.md) structure.  
  
 ADDRESS_KIND_LOCAL  
 The address is for a local variable and is represented by the [METADATA_ADDRESS_LOCAL](../vs140/metadata_address_local.md) structure.  
  
 ADDRESS_KIND_PARAM  
 A method or function parameter, represented by the [METADATA_ADDRESS_PARAM](../vs140/metadata_address_param.md) structure.  
  
 ADDRESS_KIND_ARRAYELEM  
 An array element, represented by the [METADATA_ADDRESS_ARRAYELEM](../vs140/metadata_address_arrayelem.md) structure.  
  
 ADDRESS_KIND_RETVAL  
 A return value, represented by the [METADATA_ADDRESS_RETVAL](../vs140/metadata_address_retval.md) structure.  
  
## Remarks  
 The [IDebugAddress::GetAddress](../vs140/idebugaddress--getaddress.md) method returns the [DEBUG_ADDRESS](../vs140/debug_address.md) structure which contains a union of possible structures, the [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md) structure. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure holds the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value and describes how to interpret the union field.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugAddress::GetAddress](../vs140/idebugaddress--getaddress.md)   
 [DEBUG_ADDRESS](../vs140/debug_address.md)   
 [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md)