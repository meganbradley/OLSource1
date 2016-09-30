---
title: "METADATA_TYPE"
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
  - "METADATA_TYPE"
helpviewer_keywords: 
  - "METADATA_TYPE structure"
ms.assetid: 2d8b78f6-0aef-4d79-809a-cff9b2c24659
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# METADATA_TYPE
This structure specifies information about a field type taken from metadata.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 ulAppDomainID  
 ID of the application from which the symbol came. This is used to uniquely identify an instance of the application.  
  
 guidModule  
 The GUID of the module that contains this field.  
  
 tokClass  
 The metadata token ID of this type.  
  
 [C++] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a 32-bit <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This structure appears as part of the union in the [TYPE_INFO](../vs140/type_info.md) structure when the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (a value from the [dwTYPE_KIND](../vs140/dwtype_kind.md) enumeration).  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value is a metadata token that uniquely identifies a type. For details on how to interpret the upper bits of the metadata token ID, see the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> enumeration in the corhdr.h file in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] SDK.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [TYPE_INFO](../vs140/type_info.md)   
 [dwTYPE_KIND](../vs140/dwtype_kind.md)