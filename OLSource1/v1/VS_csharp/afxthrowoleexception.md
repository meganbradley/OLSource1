---
title: "AfxThrowOleException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxThrowOleException"
  - "AFXDISP/AfxThrowOleException"
  - "AFX/AfxThrowOleException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception-throwing functions"
  - "AfxThrowOleException function"
ms.assetid: 90af5c1b-e875-4194-bab7-c04da1d0ef32
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxThrowOleException
Creates an object of type `COleException` and throws an exception.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxThrowOleException(  
   SCODE sc   
);  
void AFXAPI AfxThrowOleException(  
   HRESULT hr   
);  
```  
  
#### Parameters  
 `sc`  
 An OLE status code that indicates the reason for the exception.  
  
 `hr`  
 Handle to a result code that indicates the reason for the exception.  
  
## Remarks  
 The version that takes an `HRESULT` as an argument converts that result code into the corresponding `SCODE`. For more information on `HRESULT` and `SCODE`, see [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** <afxdisp.h>  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [COleException Class](../VS_csharp/coleexception-class.md)   
 [THROW](../VS_csharp/throw--mfc-.md)