---
title: "METADATA_ADDRESS_RETVAL"
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
  - "METADATA_ADDRESS_RETVAL"
helpviewer_keywords: 
  - "METADATA_ADDRESS_RETVAL structure"
ms.assetid: 5b0ec0fb-84b3-4ce7-8e24-becf3d881d7d
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# METADATA_ADDRESS_RETVAL
This structure represents a return value from a method or function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 tokMethod  
 The ID of the method this return value is for.  
  
 dwCorType  
 The base type of return value. This is a value from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> enumeration defined in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] SDK corhdr.h file.  
  
 dwSigSize  
 The size of the return value signature (as stored in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 rgSig  
 An array of bytes forming the signature of the return value.  
  
## Remarks  
 This structure is part of the union in the [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md) structure when the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure is set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (a value from the [ADDRESS_KIND](../vs140/address_kind.md) enumeration).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [DEBUG_ADDRESS_UNION](../vs140/debug_address_union.md)   
 [ADDRESS_KIND](../vs140/address_kind.md)