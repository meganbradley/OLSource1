---
title: "CBindStatusCallback::StartAsyncDownload"
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
  - "ATL.CBindStatusCallback.StartAsyncDownload"
  - "CBindStatusCallback::StartAsyncDownload"
  - "ATL::CBindStatusCallback::StartAsyncDownload"
  - "StartAsyncDownload"
  - "CBindStatusCallback.StartAsyncDownload"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "callback functions, ATL"
  - "asynchronous data transfer"
  - "StartAsyncDownload method"
ms.assetid: 6c8b2d79-b1be-4c6a-995d-af42fd26ab58
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::StartAsyncDownload
Starts downloading data asynchronously from the specified URL.  
  
## Syntax  
  
```  
  
      HRESULT StartAsyncDownload(  
   T* pT,  
   ATL_PDATAAVAILABLE pFunc,  
   BSTR bstrURL,  
   IUnknown* pUnkContainer = NULL,   
   BOOL bRelative = FALSE   
);  
```  
  
#### Parameters  
 *pT*  
 [in] A pointer to the object requesting the asynchronous data transfer. The `CBindStatusCallback` object is templatized on this object's class.  
  
 *pFunc*  
 [in] A pointer to the function that receives the data being read. The function is a member of your object's class of type `T`. See **Remarks** for syntax and an example.  
  
 `bstrURL`  
 [in] The URL to obtain data from. Can be any valid URL or file name. Cannot be **NULL**. For example:  
  
 `CComBSTR mybstr =_T("http://somesite/data.htm")`  
  
 `pUnkContainer`  
 [in] The **IUnknown** of the container. **NULL** by default.  
  
 `bRelative`  
 [in] A flag indicating whether the URL is relative or absolute. **FALSE** by default, meaning the URL is absolute.  
  
## Return Value  
 One of the standard `HRESULT` values.  
  
## Remarks  
 Every time data is available it is sent to the object through `OnDataAvailable`. `OnDataAvailable` reads the data and calls the function pointed to by *pFunc* (for example, to store the data or print it to the screen).  
  
 The function pointed to by *pFunc* is a member of your object's class and has the following syntax:  
  
 `void Function_Name(`  
  
 `CBindStatusCallback<T>*`  `pbsc` `,`  
  
 `BYTE*`  `pBytes` `,`  
  
 `DWORD`  `dwSize`  
  
 `);`  
  
 In the following example (taken from the [ASYNC](../vs140/visual-c---samples.md) sample), the function `OnData` writes the received data into a text box.  
  
## Example  
 [!code[NVC_ATL_Windowing#87](../vs140/codesnippet/CPP/cbindstatuscallback--startasyncdownload_1.h)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)   
 [CBindStatusCallback::OnDataAvailable](../vs140/cbindstatuscallback--ondataavailable.md)