---
title: "IDebugCodeContext2::GetLanguageInfo"
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
  - "IDebugCodeContext2::GetLanguageInfo"
helpviewer_keywords: 
  - "IDebugCodeContext2::GetLanguageInfo"
ms.assetid: 03002ef1-9fe6-44b6-b23b-ef7b86b2b21b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCodeContext2::GetLanguageInfo
Gets the language information for this code context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in, out] Returns a string that contains the name of the language, such as "C++."  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] Returns the GUID for the language of the code context, for example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 At least one of the parameters must return a non-null value.  
  
## See Also  
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)