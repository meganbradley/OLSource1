---
title: "IDebugSettingsCallback2::GetEEMetricGuid"
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
  - "IDebugSettingsCallback2::GetEEMetricGuid"
ms.assetid: 3d70c19a-595d-44f1-a7b3-a0cf8f15e371
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugSettingsCallback2::GetEEMetricGuid
Retrieves the unique identifier for a expression evaluator metric given its name.  
  
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
 [out] Returns the unique identifier of the metric.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugSettingsCallback2](../vs140/idebugsettingscallback2.md)