---
title: "CBindStatusCallback::OnDataAvailable"
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
  - "OnDataAvailable"
  - "ATL.CBindStatusCallback.OnDataAvailable"
  - "CBindStatusCallback.OnDataAvailable"
  - "ATL::CBindStatusCallback::OnDataAvailable"
  - "CBindStatusCallback::OnDataAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "asynchronous data transfer"
  - "BSCF_INTERMEDIARYDATANOTIFICATION"
  - "BSCF_FIRSTDATANOTIFICATION"
  - "OnDataAvailable method"
  - "BSCF_LASTDATANOTIFICATION"
ms.assetid: a0a27b4e-ba93-482b-a7c3-2235e2310dde
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::OnDataAvailable
The system-supplied asynchronous moniker calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to provide data to the object as it becomes available.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *grfBSCF*  
 [in] A **BSCF** enumeration value. One or more of the following: **BSCF_FIRSTDATANOTIFICATION**, **BSCF_INTERMEDIARYDATANOTIFICATION**, or **BSCF_LASTDATANOTIFICATION**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The cumulative amount (in bytes) of data available since the beginning of the binding. Can be zero, indicating that the amount of data is not relevant or that no specific amount became available.  
  
 *pformatetc*  
 [in] Pointer to the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682242) structure that contains the format of the available data. If there is no format, can be **CF_NULL**.  
  
 *pstgmed*  
 [in] Pointer to the [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms695269) structure that holds the actual data now available.  
  
## Return Value  
 One of the standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> values.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> reads the data, then calls a method of your object's class (for example, to store the data or print it to the screen). See [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md) for details.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::StartAsyncDownload](../vs140/cbindstatuscallback--startasyncdownload.md)