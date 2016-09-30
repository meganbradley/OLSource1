---
title: "METADATA_ADDRESS_METHOD"
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
  - "METADATA_ADDRESS_METHOD"
helpviewer_keywords: 
  - "METADATA_ADDRESS_METHOD structure"
ms.assetid: fc0e5370-1b4f-4867-837f-0d63c4b9dd09
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# METADATA_ADDRESS_METHOD
This structure represents the address of a method of a class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 tokMethod  
 The ID of the method.  
  
 [C++] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a 32-bit <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 dwOffset  
 The offset from the class start to this method (can represent the offset into the vtable).  
  
 dwVersion  
 The version of the method (this value is unique to the symbol provider).  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md) structure when the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (a value from the [ADDRESS_KIND](../vs140/address_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md)   
 [ADDRESS_KIND](../vs140/address_kind.md)