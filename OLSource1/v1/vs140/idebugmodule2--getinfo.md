---
title: "IDebugModule2::GetInfo"
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
  - "IDebugModule2::GetInfo"
helpviewer_keywords: 
  - "GetInfo method"
  - "IDebugModule2::GetInfo method"
ms.assetid: de337e66-294f-4ac9-b21e-71fac7418e36
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugModule2::GetInfo
Gets information about this module.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [MODULE_INFO_FIELDS](../vs140/module_info_fields.md) enumeration that specify which fields of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are to be filled out.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] A [MODULE_INFO](../vs140/module_info.md) structure that is filled in with a description of the module.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The [MODULE_INFO](../vs140/module_info.md) structure contains the name of the module that is displayed in the **Modules** window.  
  
## See Also  
 [IDebugModule2](../vs140/idebugmodule2.md)   
 [MODULE_INFO_FIELDS](../vs140/module_info_fields.md)   
 [MODULE_INFO](../vs140/module_info.md)