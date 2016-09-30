---
title: "setvbuf Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_IOFBF"
  - "_IONBF"
  - "_IOLBF"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_IOFBF constant"
  - "IOFBF constant"
  - "IONBF constant"
  - "_IOLBF constant"
  - "IOLBF constant"
  - "_IONBF constant"
ms.assetid: a6ec4dd5-1f24-498c-871a-e874cd28d33c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# setvbuf Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These constants represent the type of buffer for <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 The possible values are given by the following manifest constants:  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Full buffering: Buffer specified in call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used and its size is as specified in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> call. If buffer pointer is **NULL**, automatically allocated buffer of specified size is used.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Same as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|No buffer is used, regardless of arguments in call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
## See Also  
 [setbuf](../vs140/setbuf.md)   
 [Global Constants](../vs140/global-constants.md)