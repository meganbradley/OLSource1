---
title: "IDebugSettingsCallback2::GetEEMetricDword"
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
  - "IDebugSettingsCallback2::GetEEMetricDword"
ms.assetid: c5f8f417-0ef0-4fd0-a779-b0a8ead4effe
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSettingsCallback2::GetEEMetricDword
Retrieves a value that corresponds to the specified metric of the expression evaluator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Unique identifier of the programming language.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Unique identifier of the vendor.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Name of the metric.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns the value that corresponds to the metric string.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSettingsCallback2](../vs140/idebugsettingscallback2.md)