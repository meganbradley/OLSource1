---
title: "IDebugField::GetInfo"
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
  - "IDebugField::GetInfo"
helpviewer_keywords: 
  - "IDebugField::GetInfo method"
ms.assetid: 7d508200-89ce-400f-a8ea-f28e7610cb2b
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugField::GetInfo
This method gets displayable information about the field.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of [FIELD_INFO_FIELDS](../vs140/field_info_fields.md) constants that selects the information to be displayed. If the field represents a symbol, this is typically the symbol name and type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the information in the supplied [FIELD_INFO](../vs140/field_info.md) structure.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugField](../vs140/idebugfield.md)   
 [FIELD_INFO](../vs140/field_info.md)