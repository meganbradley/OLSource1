---
title: "DEBUG_ADDRESS_UNION"
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
  - "DEBUG_ADDRESS_UNION"
helpviewer_keywords: 
  - "DEBUG_ADDRESS_UNION union"
ms.assetid: e3d11aab-de0d-4109-b5dc-11e07e64382d
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# DEBUG_ADDRESS_UNION
Describes different kinds of addresses.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 dwKind  
 A value from the [ADDRESS_KIND](../vs140/address_kind.md) enumeration, specifying how to interpret the union.  
  
 addr.addrNative  
 [C++ only] Contains the [NATIVE_ADDRESS](../vs140/native_address.md) structure if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> = ADDRESS_KIND_NATIVE.  
  
 addr.addrThisRel  
 [C++ only] Contains the[UNMANAGED_ADDRESS_THIS_RELATIVE](../vs140/unmanaged_address_this_relative.md) structure if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> = ADDRESS_KIND_UNMANAGED_THIS_RELATIVE.  
  
 addr.addUPhysical  
 [C++ only] Contains the[UNMANAGED_ADDRESS_PHYSICAL](../vs140/unmanaged_address_physical.md) structure if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> = ADDRESS_KIND_UNMANAGED_PHYSICAL.  
  
 addr.addrMethod  
 [C++ only] Contains the[METADATA_ADDRESS_METHOD](../vs140/metadata_address_method.md) structure if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> = ADDRESS_KIND_METHOD.  
  
 addr.addrField  
 [C++ only] Contains the[METADATA_ADDRESS_FIELD](../vs140/metadata_address_field.md) structure if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> = ADDRESS_KIND_FIELD.  
  
 addr.addrLocal  
 [C++ only] Contains the[METADATA_ADDRESS_LOCAL](../vs140/metadata_address_local.md) structure if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> = ADDRESS_KIND_LOCAL.  
  
 addr.addrParam  
 [C++ only] Contains the[METADATA_ADDRESS_PARAM](../vs140/metadata_address_param.md) structure if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> = ADDRESS_KIND_PARAM.  
  
 addr.addrArrayElem  
 [C++ only] Contains the[METADATA_ADDRESS_ARRAYELEM](../vs140/metadata_address_arrayelem.md) structure if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> = ADDRESS_KIND_ARRAYELEM.  
  
 addr.addrRetVal  
 [C++ only] Contains the[METADATA_ADDRESS_RETVAL](../vs140/metadata_address_retval.md) structure if <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> = ADDRESS_KIND_RETVAL.  
  
 addr.unused  
 [C++ only] padding.  
  
 addr  
 [C++ only] The name of the union.  
  
 unionmember  
 [C# only] This value needs to be marshaled to the appropriate structure type based on <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. See Remarks for the association between <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and interpretation of the union.  
  
## Remarks  
 This structure is part of the [DEBUG_ADDRESS](../vs140/debug_address.md) structure and represents one of a number of different kinds of addresses (the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure is filled in by a call to the [IDebugAddress::GetAddress](../vs140/idebugaddress--getaddress.md) method).  
  
 [C# only] The following table shows how to interpret the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> member for each kind of address. The Example shows how this is done for one kind of address.  
  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interpreted as|  
|--------------|----------------------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|[NATIVE_ADDRESS](../vs140/native_address.md)|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|[UNMANAGED_ADDRESS_THIS_RELATIVE](../vs140/unmanaged_address_this_relative.md)|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|[UNMANAGED_ADDRESS_PHYSICAL](../vs140/unmanaged_address_physical.md)|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|[METADATA_ADDRESS_METHOD](../vs140/metadata_address_method.md)|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|[METADATA_ADDRESS_FIELD](../vs140/metadata_address_field.md)|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[METADATA_ADDRESS_LOCAL](../vs140/metadata_address_local.md)|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|[METADATA_ADDRESS_PARAM](../vs140/metadata_address_param.md)|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|[METADATA_ADDRESS_ARRAYELEM](../vs140/metadata_address_arrayelem.md)|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|[METADATA_ADDRESS_RETVAL](../vs140/metadata_address_retval.md)|  
  
## Example  
 This example shows how to interpret one kind of address (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>) of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> structure in C#. The remaining elements can be interpreted in exactly the same way.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [DEBUG_ADDRESS](../vs140/debug_address.md)   
 [ADDRESS_KIND](../vs140/address_kind.md)   
 [IDebugAddress::GetAddress](../vs140/idebugaddress--getaddress.md)