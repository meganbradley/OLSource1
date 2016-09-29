---
title: "CAtlFile::GetOverlappedResult"
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
  - "ATL::CAtlFile::GetOverlappedResult"
  - "CAtlFile::GetOverlappedResult"
  - "ATL.CAtlFile.GetOverlappedResult"
  - "CAtlFile.GetOverlappedResult"
  - "GetOverlappedResult"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOverlappedResult method"
ms.assetid: 87f978a8-7cea-4793-899a-77c82388fb39
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::GetOverlappedResult
Call this method to get the results of an overlapped operation on the file.  
  
## Syntax  
  
```  
  
      HRESULT GetOverlappedResult(  
   LPOVERLAPPED pOverlapped,  
   DWORD& dwBytesTransferred,  
   BOOL bWait   
) throw( );  
```  
  
#### Parameters  
 `pOverlapped`  
 The overlapped structure. See `lpOverlapped` in [GetOverlappedResult](http://msdn.microsoft.com/library/windows/desktop/ms683209) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *dwBytesTransferred*  
 The bytes transferred. See *lpNumberOfBytesTransferred* in `GetOverlappedResult`.  
  
 `bWait`  
 The wait option. See `bWait` in `GetOverlappedResult`.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [GetOverlappedResult](http://msdn.microsoft.com/library/windows/desktop/ms683209) to get the results of an overlapped operation on the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)