---
title: "UNMANAGED_ADDRESS_THIS_RELATIVE"
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
  - "UNMANAGED_ADDRESS_THIS_RELATIVE"
helpviewer_keywords: 
  - "UNMANAGED_ADDRESS_THIS_RELATIVE structure"
ms.assetid: e6a91ace-2d47-4ff9-aefb-8d8b68eab0b2
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# UNMANAGED_ADDRESS_THIS_RELATIVE
This structure represents an address that is relative to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in Visual Basic).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 dwOffset  
 Byte offset from a base position (for example, start of a class vtable).  
  
 dwBitOffset  
 Offset in bits from a base position (always 0 unless referring to a bit field).  
  
 dwBitLength  
 Number of bits representing the address (always 0 unless referring to a bit field).  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md) structure when the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure is set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (a value from the [ADDRESS_KIND](../vs140/address_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md)