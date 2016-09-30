---
title: "METADATA_ADDRESS_PARAM"
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
  - "METADATA_ADDRESS_PARAM"
helpviewer_keywords: 
  - "METADATA_ADDRESS_PARAM structure"
ms.assetid: 90904f19-0e71-4cb3-a56e-6a2e92f66dfc
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# METADATA_ADDRESS_PARAM
This structure represents a parameter of a method or function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 tokMethod  
 The ID of the method the parameter is part of.  
  
 tokParam  
 The ID of the parameter.  
  
 dwIndex  
 The index of the parameter in a list of parameters.  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md) structure when the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure is set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (a value from the [ADDRESS_KIND](../vs140/address_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md)   
 [ADDRESS_KIND](../vs140/address_kind.md)