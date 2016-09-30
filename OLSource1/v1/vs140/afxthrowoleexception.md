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
Creates an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and throws an exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An OLE status code that indicates the reason for the exception.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Handle to a result code that indicates the reason for the exception.  
  
## Remarks  
 The version that takes an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as an argument converts that result code into the corresponding <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For more information on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, see [Structure of COM Error Codes](http://msdn.microsoft.com/library/windows/desktop/ms690088) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** \<afxdisp.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleException Class](../vs140/coleexception-class.md)   
 [THROW](../vs140/throw--mfc-.md)