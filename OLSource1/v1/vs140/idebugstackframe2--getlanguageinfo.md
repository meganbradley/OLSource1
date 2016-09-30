---
title: "IDebugStackFrame2::GetLanguageInfo"
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
  - "IDebugStackFrame2::GetLanguageInfo"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetLanguageInfo"
ms.assetid: 0e12fd92-f155-46a7-8272-cda279388cfb
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame2::GetLanguageInfo
Gets the language associated with this stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the name of the language that implements the method associated with this stack frame.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> of the language. For the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] languages, for example, the following can be returned:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)