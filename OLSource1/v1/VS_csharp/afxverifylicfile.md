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
Call this function to verify that the license file named by `pszLicFileName` is valid for the OLE control.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxVerifyLicFile(  
   HINSTANCE hInstance,  
   LPCTSTR pszLicFileName,  
   LPOLESTR pszLicFileContents,  
   UINT cch = -1   
);  
```  
  
#### Parameters  
 `hInstance`  
 The instance handle of the DLL associated with the licensed control.  
  
 `pszLicFileName`  
 Points to a null-terminated character string containing the license filename.  
  
 `pszLicFileContents`  
 Points to a byte sequence that must match the sequence found at the beginning of the license file.  
  
 `cch`  
 Number of characters in `pszLicFileContents`.  
  
## Return Value  
 Nonzero if the license file exists and begins with the character sequence in `pszLicFileContents`; otherwise 0.  
  
## Remarks  
 If `cch` is – 1, this function uses:  
  
 [!code[NVC_MFC_Utilities#36](../VS_csharp/codesnippet/CPP/afxverifylicfile_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [COleObjectFactory::VerifyUserLicense](../Topic/COleObjectFactory::VerifyUserLicense.md)