---
title: "CBindStatusCallback::Download"
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
  - "CBindStatusCallback.Download"
  - "ATL.CBindStatusCallback.Download"
  - "CBindStatusCallback::Download"
  - "Download"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Download method"
ms.assetid: bee60c43-6528-49f2-944e-9ef837433444
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::Download
Creates a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to start downloading data asynchronously from the specified URL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pT*  
 [in] A pointer to the object requesting the asynchronous data transfer. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is templatized on this object's class.  
  
 *pFunc*  
 [in] A pointer to the function that receives the data that is read. The function is a member of your object's class of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. See [StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md) for syntax and an example.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The URL to obtain data from. Can be any valid URL or file name. Cannot be **NULL**. For example:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The **IUnknown** of the container. **NULL** by default.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] A flag indicating whether the URL is relative or absolute. **FALSE** by default, meaning the URL is absolute.  
  
## Return Value  
 One of the standard <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values.  
  
## Remarks  
 Every time data is available it is sent to the object through <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> reads the data and calls the function pointed to by *pFunc* (for example, to store the data or print it to the screen).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)