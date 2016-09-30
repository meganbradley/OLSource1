---
title: "IDiaDataSource::get_lastError"
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
  - "IDiaDataSource::get_lastError method"
ms.assetid: cf08850b-8b75-4e8c-90bd-bd0214756f99
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaDataSource::get_lastError
Retrieves the file name for the last load error.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pRetVal  
 [out] Returns a string that contains the .pdb file name associated with the last load error.  
  
## Return Value  
 Returns the last error code caused by a load operation. Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaDataSource](../vs140/idiadatasource.md)