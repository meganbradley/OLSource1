---
title: "IDiaLoadCallback2::RestrictOriginalPathAccess"
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
  - "IDiaLoadCallback2::RestrictOriginalPathAccess method"
ms.assetid: 31fde3af-2824-4b0f-8d0d-cee6046596f6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLoadCallback2::RestrictOriginalPathAccess
Determines if it is okay to look for a .pdb file in the original debug directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Any return code other than <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> prevents looking for a .pdb file in the original debug directory. The original debug directory is the path to the symbol file compiled into the executable when debugging is turned on. This path is not necessarily the same as the path where the executable exists.  
  
## See Also  
 [IDiaLoadCallback2](../vs140/idialoadcallback2.md)