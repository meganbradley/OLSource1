---
title: "IDebugObject2::IsEncOutdated"
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
  - "IDebugObject2::IsEncOutdated"
helpviewer_keywords: 
  - "IDebugObject2::IsEncOutdated method"
ms.assetid: d3a8c02d-895b-478c-9957-d663130f308e
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugObject2::IsEncOutdated
This method determines whether the Edit and Continue status of this object or of the parent container is out of date. A custom expression evaluator does not implement this method and always returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Nonzero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) if the Edit and Continue state is out of date, zero (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) if it is not.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
> [!NOTE]
>  A custom expression evaluator should always return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## See Also  
 [IDebugObject2](../vs140/idebugobject2.md)