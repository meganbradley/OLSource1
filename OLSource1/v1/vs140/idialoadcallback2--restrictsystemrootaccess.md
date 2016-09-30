---
title: "IDiaLoadCallback2::RestrictSystemRootAccess"
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
  - "IDiaLoadCallback2::RestrictSystemRootAccess method"
ms.assetid: 39f22db8-632a-4ef0-babc-23f758e6d937
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLoadCallback2::RestrictSystemRootAccess
Determines if searching for .pdb files is allowed in the system root directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Any return code other than <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> prevents searching the system root for .pdb files.  
  
## See Also  
 [IDiaLoadCallback2](../vs140/idialoadcallback2.md)