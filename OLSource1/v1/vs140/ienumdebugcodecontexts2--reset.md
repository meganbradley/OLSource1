---
title: "IEnumDebugCodeContexts2::Reset"
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
  - "IEnumDebugCodeContexts2::Reset"
helpviewer_keywords: 
  - "IEnumDebugCodeContexts2::Reset"
ms.assetid: df6cf1e3-2ef8-4d38-81a0-8e9adf151884
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugCodeContexts2::Reset
Resets the enumeration to the first element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [IEnumDebugCodeContexts2::Next](../vs140/ienumdebugcodecontexts2--next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugCodeContexts2](../vs140/ienumdebugcodecontexts2.md)