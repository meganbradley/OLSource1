---
title: "FIELD_INFO_FIELDS"
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
  - "FIELD_INFO_FIELDS"
helpviewer_keywords: 
  - "FIELD_INFO_FIELDS enumeration"
ms.assetid: a69487d2-e701-4165-804a-8a011df9a3bd
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# FIELD_INFO_FIELDS
Specifies what information to retrieve about an [IDebugField](../vs140/idebugfield.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 FIF_FULLNAME  
 Initialize/use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field in the [FIELD_INFO](../vs140/field_info.md) structure.  
  
 FIF_NAME  
 Initialize/use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure.  
  
 FIF_TYPE  
 Initialize/use the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure.  
  
 FIF_MODIFIERS  
 Initialize/use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 These values are also passed as an argument to the [GetInfo](../vs140/idebugfield--getinfo.md) method to specify which fields of the [FIELD_INFO](../vs140/field_info.md) structure are to be initialized.  
  
 These values are also used in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure to indicate which fields are used and valid.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [FIELD_INFO](../vs140/field_info.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [GetInfo](../vs140/idebugfield--getinfo.md)