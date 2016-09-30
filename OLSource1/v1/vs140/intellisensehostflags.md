---
title: "IntelliSenseHostFlags"
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
  - "IntellisenseHostFlags"
helpviewer_keywords: 
  - "IntelliSense, IntellisenseHostFlags enumeration"
  - "IntellisenseHostFlags enumeration"
ms.assetid: 0930640b-eb84-48ef-a8f7-d4268f55c99c
caps.latest.revision: 10
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IntelliSenseHostFlags
Specifies IntelliSense host flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Members|Description|  
|-------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Context buffer is read-only.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|No subject text. Context buffer contains IntelliSense-target (implies <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Subject text is not multi-line-capable.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Editing (in subject or context) should be done in overtype mode.|  
  
## Requirements  
 SingleFileeditor.idl  
  
## See Also  
 \<xref:Microsoft.VisualStudio.TextManager.Interop*>