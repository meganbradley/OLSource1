---
title: "POPDIRLISTFUNC"
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
  - "POPLISTFUNC"
helpviewer_keywords: 
  - "POPDIRLISTFUNC callback function"
ms.assetid: 0ee90fd2-5467-4154-ab4c-7eb02ac3a14c
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# POPDIRLISTFUNC
This is a callback function given to the [SccPopulateDirList](../vs140/sccpopulatedirlist-function.md) function to update a collection of directories and (optionally) file names to find out which are under source control.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> callback should be called only for those directories and file names (in the list given to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function) that are actually under source control.  
  
## Signature  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parameters  
 pvCallerData  
 [in] User value given to [SccPopulateDirList](../vs140/sccpopulatedirlist-function.md).  
  
 bFolder  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the name in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a directory; otherwise the name is a file name.  
  
 lpDirectoryOrFileName  
 [in] Full local path to a directory or file name that is under source code control.  
  
## Return Value  
 The IDE returns an appropriate error code:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Continue processing.|  
|SCC_I_OPERATIONCANCELED|Stop processing.|  
|SCC_E_xxx|Any appropriate source control error should stop processing.|  
  
## Remarks  
 If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function contains the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> flag, then the list will possibly contain file names as well as directory names.  
  
## See Also  
 [Callback Functions Implemented by the IDE](../vs140/callback-functions-implemented-by-the-ide.md)   
 [SccPopulateDirList](../vs140/sccpopulatedirlist-function.md)   
 [Error Codes](../vs140/error-codes.md)