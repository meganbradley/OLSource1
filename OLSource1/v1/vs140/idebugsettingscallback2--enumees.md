---
title: "IDebugSettingsCallback2::EnumEEs"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugSettingsCallback2::EnumEEs"
ms.assetid: 9f884c49-426f-461b-b547-9d909486e73f
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSettingsCallback2::EnumEEs
Enumerates the available expression evaluators given the language and vendor identifiers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Number of elements in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Unique identifier for the programming language.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in, out] Unique identifier for the vendor.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in, out] Array of expression evaluators.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSettingsCallback2](../vs140/idebugsettingscallback2.md)