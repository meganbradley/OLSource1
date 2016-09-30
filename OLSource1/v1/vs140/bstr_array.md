---
title: "BSTR_ARRAY"
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
  - "BSTR_ARRAY"
helpviewer_keywords: 
  - "BSTR_ARRAY structure"
ms.assetid: 48da37f7-a237-48a9-9ff9-389c1a00862c
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BSTR_ARRAY
A structure that describes an array of strings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Terms  
 dwCount  
 Number of strings in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array.  
  
 Members  
 Array of strings.  
  
## Remarks  
 This structure is returned from the [IDebugPortSupplier3::EnumPersistedPorts](../vs140/idebugportsupplier3--enumpersistedports.md) method.  
  
 [C++ only] Each individual string must be freed using <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> array must be freed with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugPortSupplier3::EnumPersistedPorts](../vs140/idebugportsupplier3--enumpersistedports.md)