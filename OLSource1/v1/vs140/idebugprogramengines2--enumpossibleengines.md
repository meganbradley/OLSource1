---
title: "IDebugProgramEngines2::EnumPossibleEngines"
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
  - "IDebugProgramEngines2::EnumPossibleEngines"
helpviewer_keywords: 
  - "IDebugProgramEngines2::EnumPossibleEngines"
ms.assetid: 993d70a4-f6a5-4e47-a603-0b162b9fde00
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgramEngines2::EnumPossibleEngines
Returns the GUIDs for all the possible debug engines (DE) that can debug this program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The number of DE GUIDs to return. This also specifies the maximum size of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] An array of DE GUIDs to be filled in.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the actual number of DE GUIDs that are returned.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns [C++] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or [C#] 0x8007007A if the buffer is not large enough.  
  
## Remarks  
 In order to determine how many engines there are, call this method once with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter set to 0 and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter set to a null value. This returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (0x8007007A for C#), and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter returns the necessary size of the buffer.  
  
## See Also  
 [IDebugProgramEngines2](../vs140/idebugprogramengines2.md)