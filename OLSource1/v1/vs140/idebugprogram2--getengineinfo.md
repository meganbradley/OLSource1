---
title: "IDebugProgram2::GetEngineInfo"
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
  - "IDebugProgram2::GetEngineInfo"
helpviewer_keywords: 
  - "IDebugProgram2::GetEngineInfo"
ms.assetid: 3a4f2dc0-e082-4d8d-aeaf-463ab09d279b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::GetEngineInfo
Gets the name and GUID of the debug engine (DE) running this program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the name of the DE running this program.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the GUID of the DE running this program.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Each DE defines its own GUID for identification.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)