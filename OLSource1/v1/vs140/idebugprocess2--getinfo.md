---
title: "IDebugProcess2::GetInfo"
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
  - "IDebugProcess2::GetInfo"
helpviewer_keywords: 
  - "IDebugProcess2::GetInfo"
ms.assetid: 46021dce-bb97-46c3-b0cc-e5b3b68acc35
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess2::GetInfo
Gets a description of the process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of values from the [PROCESS_INFO_FIELDS](../vs140/process_info_fields.md) enumeration that specifies which fields of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter are to be filled in.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] A [PROCESS_INFO](../vs140/process_info.md) structure that is filled in with a description of the process.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [PROCESS_INFO_FIELDS](../vs140/process_info_fields.md)   
 [PROCESS_INFO](../vs140/process_info.md)