---
title: "__setusermatherr"
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
  - "__setusermatherr"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "api-ms-win-crt-math-l1-1-0.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__setusermatherr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__setusermatherr"
ms.assetid: f306818d-381a-4d68-8739-71b92bacb5ea
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __setusermatherr
Specifies a user-supplied rountine to handle math errors, instead of the [_matherr](../vs140/_matherr.md) routine.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to an implementation of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that is supplied by the user.  
  
 The type of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is declared as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|__setusermatherr|matherr.c|