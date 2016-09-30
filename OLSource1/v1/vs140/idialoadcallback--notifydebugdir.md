---
title: "IDiaLoadCallback::NotifyDebugDir"
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
  - "IDiaLoadCallback::NotifyDebugDir method"
ms.assetid: bd04e2f6-0dbf-4742-a556-96f2cd99aa19
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLoadCallback::NotifyDebugDir
Called when a debug directory was found in the .exe file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the debug directory is read from an executable (rather than a .dbg file).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Count of bytes of data in the debug directory.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An array that is filled in with the debug directory.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, returns an error code. The return code is typically ignored.  
  
## Remarks  
 The [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md) method invokes this callback when it finds a debug directory while processing the executable file.  
  
 This method removes the need for the client to reverse engineer the executable and/or debug file to support debug information other than that found in the .pdb file. With this data, the client can recognize the type of debug information available and whether it resides in the executable file or the .dbg file.  
  
 Most clients will not need this callback because the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method transparently opens both .pdb and .dbg files when necessary to serve symbols.  
  
## See Also  
 [IDiaLoadCallback2](../vs140/idialoadcallback2.md)   
 [IDiaDataSource::loadDataForExe](../vs140/idiadatasource--loaddataforexe.md)