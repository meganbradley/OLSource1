---
title: "AfxThrowOleDispatchException"
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
  - "AfxThrowOleDispatchException"
  - "AFXDISP/AfxThrowOleDispatchException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception-throwing functions"
  - "AfxThrowOleDispatchException function"
ms.assetid: 500a4360-0528-4b2e-a129-956bfa8051fd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxThrowOleDispatchException
Use this function to throw an exception within an OLE automation function.  
  
## Syntax  
  
```  
  
      void AFXAPI AfxThrowOleDispatchException(  
   WORD wCode,  
   LPCSTR lpszDescription,  
   UINT nHelpID = 0   
);  
void AFXAPI AfxThrowOleDispatchException(  
   WORD wCode,  
   UINT nDescriptionID,  
   UINT nHelpID =  -1   
);  
```  
  
#### Parameters  
 `wCode`  
 An error code specific to your application.  
  
 `lpszDescription`  
 Verbal description of the error.  
  
 `nDescriptionID`  
 Resource ID for the verbal error description.  
  
 `nHelpID`  
 A help context for your application's help (.HLP) file.  
  
## Remarks  
 The information provided to this function can be displayed by the driving application (Microsoft Visual Basic or another OLE automation client application).  
  
## Example  
 [!code[NVC_MFCExceptions#25](../vs140/codesnippet/CPP/afxthrowoledispatchexception_1.cpp)]  
  
## Requirements  
 **Header:** <afxdisp.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleException Class](../vs140/coleexception-class.md)