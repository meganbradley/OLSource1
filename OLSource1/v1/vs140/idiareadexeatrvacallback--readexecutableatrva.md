---
title: "IDiaReadExeAtRVACallback::ReadExecutableAtRVA"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaReadExeAtRVACallback::ReadExecutableAtRVA method"
ms.assetid: 3c1e965f-8f05-41a8-86d8-01830b2377c9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaReadExeAtRVACallback::ReadExecutableAtRVA
Reads the specified number of bytes starting at the specified relative virtual address (RVA) from the executable file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The RVA in the executable file to begin reading.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Number of bytes to read.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns the number of bytes read.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] An array that is filled in with bytes read from the file.  
  
## Remarks  
 This method is called by the DIA support code to load data bytes from an executable using a relative virtual address. This method is called in support of the [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md) method.  
  
## See Also  
 [IDiaReadExeAtRVACallback](../vs140/idiareadexeatrvacallback.md)   
 [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md)