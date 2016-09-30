---
title: "SccQueryInfo Function"
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
  - "SccQueryInfo"
helpviewer_keywords: 
  - "SccQueryInfo function"
ms.assetid: 3973d336-a9b7-41a2-a4e6-bb8184a96aaf
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccQueryInfo Function
This function obtains status information for a set of selected files under source control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 [in] The source control plug-in context structure.  
  
 nFiles  
 [in] Number of files specified in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> array and the length of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> array.  
  
 lpFileNames  
 [in] An array of names of files to be queried.  
  
 lpStatus  
 [in, out] An array in which the source control plug-in returns the status flags for each file. For more information, see [File Status Code Enumerator](../vs140/file-status-code-enumerator.md).  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Query was successful.|  
|SCC_E_ACCESSFAILURE|There was a problem with accessing the source control system, probably caused by network or contention issues. A retry is recommended.|  
|SCC_E_PROJNOTOPEN|The project is not open under source control.|  
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|  
  
## Remarks  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an empty string, there is currently no status information to update. Otherwise, it is the full path name of the file for which the status information may have changed.  
  
 The return array can be a bitmask of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> bits. For more information, see [File Status Code Enumerator](../vs140/file-status-code-enumerator.md). A source control system may not support all bit types. For example, if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not offered, the bit is just not set.  
  
 When using this function to check out files, note the following <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> status requirements:  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is set when the current user has checked out the file.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> cannot be set unless <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is set.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is only set when the file is checked-out into the designated working directory.  
  
-   If the file is checked-out by the current user into a directory other than the working directory, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is set but <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [File Status Code Enumerator](../vs140/file-status-code-enumerator.md)