---
title: "CMetaFileDC::Close"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CMetaFileDC.Close"
  - "CMetaFileDC::Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
  - "CMetaFileDC class, operations"
ms.assetid: 8ff8095a-01e5-40fa-8f82-719ce2c19d5b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMetaFileDC::Close
Closes the metafile device context and creates a Windows metafile handle that can be used to play the metafile by using the [CDC::PlayMetaFile](../vs140/cdc--playmetafile.md) member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A valid **HMETAFILE** if the function is successful; otherwise **NULL**.  
  
## Remarks  
 The Windows metafile handle can also be used to manipulate the metafile with Windows functions such as [CopyMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183480).  
  
 Delete the metafile after use by calling the Windows [DeleteMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183537) function.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CMetaFileDC Class](../vs140/cmetafiledc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::PlayMetaFile](../vs140/cdc--playmetafile.md)   
 [CloseMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183445)   
 [CopyMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183480)   
 [DeleteMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd183537)