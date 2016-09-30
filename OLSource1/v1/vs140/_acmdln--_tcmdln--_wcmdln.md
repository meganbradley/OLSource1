---
title: "_acmdln, _tcmdln, _wcmdln"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_wcmdln"
  - "_acmdln"
apilocation: 
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_acmdln"
  - "acmdln"
  - "_wcmdln"
  - "wcmdln"
  - "_tcmdln"
  - "tcmdln"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_wcmdln global variable"
  - "wcmdln global variable"
  - "_acmdln global variable"
  - "_tcmdln global variable"
  - "tcmdln global variable"
  - "acmdln global variable"
ms.assetid: 4fc0a6a0-3f93-420a-a19f-5276061ba539
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _acmdln, _tcmdln, _wcmdln
Internal CRT global variable. The command line.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These CRT internal variables store the complete command line. They are exposed in the exported symbols for the CRT, but are not intended for use in your code. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> stores the data as a character string. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> stores the data as a wide character string. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be defined as either <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, depending on which is appropriate.  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)