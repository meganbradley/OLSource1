---
title: "IDebugProgram2::GetENCUpdate"
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
  - "IDebugProgram2::GetENCUpdate"
helpviewer_keywords: 
  - "IDebugProgram2::GetENCUpdate"
ms.assetid: 9832aac8-6320-4fd8-91dd-2a0852febb00
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::GetENCUpdate
This method gets the Edit and Continue (ENC) update for this program. A custom debug engine always returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an internal interface that can be used to update this program.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
> [!NOTE]
>  A custom debug engine should always return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)