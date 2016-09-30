---
title: "METADATA_ADDRESS_LOCAL"
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
  - "METADATA_ADDRESS_LOCAL"
helpviewer_keywords: 
  - "METADATA_ADDRESS_LOCAL structure"
ms.assetid: 635f6bc5-c486-4e0e-83db-36f15e543843
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# METADATA_ADDRESS_LOCAL
This structure represents the address of a local variable within a scope (usually a function or method).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 tokMethod  
 The ID of the method or function the local variable is part of.  
  
 [C++] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for a 32-bit <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 pLocal  
 The token whose address this structure represents.  
  
 dwIndex  
 Can be the index of this local variable in the method or function, or some other value (language-specific).  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md) structure when the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure is set to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (a value from the [ADDRESS_KIND](../vs140/address_kind.md) enumeration).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> [C++ only]  If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is not null, then you must call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> on the token pointer (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a field in the [DEBUG_ADDRESS](../vs140/debug_address.md) structure):  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md)   
 [DEBUG_ADDRESS](../vs140/debug_address.md)   
 [ADDRESS_KIND](../vs140/address_kind.md)