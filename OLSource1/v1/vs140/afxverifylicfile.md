---
title: "AfxVerifyLicFile"
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
  - "AFXCTL/AfxVerifyLicFile"
  - "AfxVerifyLicFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxVerifyLicFile function"
ms.assetid: 9fad6b11-bd24-4be1-849a-04ae5ef90b41
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxVerifyLicFile
Call this function to verify that the license file named by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is valid for the OLE control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The instance handle of the DLL associated with the licensed control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a null-terminated character string containing the license filename.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a byte sequence that must match the sequence found at the beginning of the license file.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Number of characters in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if the license file exists and begins with the character sequence in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise 0.  
  
## Remarks  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is – 1, this function uses:  
  
 [!code[NVC_MFC_Utilities#36](../vs140/codesnippet/CPP/afxverifylicfile_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleObjectFactory::VerifyUserLicense](../vs140/coleobjectfactory--verifyuserlicense.md)